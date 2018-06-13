using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Album
    {
        private string title;
        private DateTime releasedate;
        private bool privé;

        public string Title { get => title; set => title = value; }
        public DateTime Releasedate { get => releasedate; set => releasedate = value; }
        public bool Privé { get => privé; set => privé = value; }
    }
}
