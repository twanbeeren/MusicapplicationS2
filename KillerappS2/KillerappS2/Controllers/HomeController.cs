using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KillerappS2.Models;
using System.Data.SqlClient;
using Logic;
using Models;
using Microsoft.AspNetCore.Http;

namespace KillerappS2.Controllers
{
    public class HomeController : Controller
    {
        private Song_Logic songlogic = new Song_Logic();
        private Account_Logic accountlogic = new Account_Logic();
        private static View_Model viewmodel = new View_Model();
        public IActionResult Index()
        {
            viewmodel.Account.Name = HttpContext.Session.GetString("_Name");
            viewmodel.Account.Account_Id = HttpContext.Session.GetInt32("_Id").GetValueOrDefault(0);
            if(viewmodel.Account.Name == null && viewmodel.Account.Account_Id == 0)
            {
                return RedirectToAction("Log_in", "Log_in");
            }
            else
            {
                viewmodel.GetFriendsDatabase();
                viewmodel.GetFriendRequestsDatabase();
                viewmodel.GetPlaylistsDatabase();
                viewmodel.GetNumberOfFriends();
                return View(viewmodel);
            }
            
        }

        public IActionResult Searchpage(View_Model viewmod)
        {
            viewmodel.Account.Name = HttpContext.Session.GetString("_Name");
            viewmodel.Account.Account_Id = HttpContext.Session.GetInt32("_Id").GetValueOrDefault(0);
            if (viewmodel.Account.Name == null && viewmodel.Account.Account_Id == 0)
            {
                return RedirectToAction("Log_in", "Log_in");
            }
            else
            {
                viewmodel.GetFriendsDatabase();
                viewmodel.GetFriendRequestsDatabase();
                viewmodel.GetPlaylistsDatabase();
                viewmodel.GetNumberOfFriends();
                return View(viewmodel); 
            }
        }
        
        [HttpPost]
        public IActionResult SearchSongs(View_Model viewmod)
        {
            viewmodel.Songs.Clear();
            viewmodel.GetSongsDatabase(viewmod.Song);
            return RedirectToAction("Searchpage");
        }

        [HttpPost]
        public IActionResult SearchListeners(string searchterm)
        {
            accountlogic.GetAccountsBySearch(searchterm);
            return RedirectToAction("Searchpage");
        }

        public IActionResult SendFriendRequest(int account_id)
        {
            int user_id = HttpContext.Session.GetInt32("_Id").GetValueOrDefault(0);
            accountlogic.SendFriendRequest(new Account(account_id), new Account(account_id));
            return RedirectToAction("Searchpage");
        }

        public IActionResult UpdateTotal_Streams(Song song)
        {
            songlogic.UpdateTotal_Streams(song);
            return RedirectToAction("Searchpage");
        }
        
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
  
    }
}
