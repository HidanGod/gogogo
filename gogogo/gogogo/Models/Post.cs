using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gogogo.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public int AvtoraId { get; set; }
        public string Zaglav { get; set; }
        public string Text { get; set; }
        public string Karma { get; set; }
        public string URL { get; set; }
        public string Date { get; set; }
        public int Prosmotrov { get; set; }
        public string Category { get; set; }
        public string Razdel { get; set; }
        public string Kratk { get; set; }
    }
}