using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Logic;
using Models;

namespace KillerappS2.Controllers
{
    public class Log_inController : Controller
    {
        const string SessionKeyName = "_Name";
        const string SessionKeyId = "_Id" ;
        
        Account_Logic logic = new Account_Logic();
        public IActionResult Log_inpage()
        {
            Account account = new Account();
            return View(account);
        }

        public IActionResult Registerpage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Log_in(Account account)
        {
            
            if(logic.Log_in(account.Name, account.Password))
            {
                logic.GetAccount_Id(account);
                HttpContext.Session.SetString(SessionKeyName, account.Name);
                HttpContext.Session.SetInt32(SessionKeyId, account.Account_Id);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Log_inpage");
            }
            
        }

        [HttpPost]
        public IActionResult Register(Account account)
        {
            logic.CheckRegisterPassword(account);
            return RedirectToAction("Log_inpage");
        }
    }
}