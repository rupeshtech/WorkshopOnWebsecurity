using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkShopOnWebSecurity.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        [AllowHtml]
        public string Comment { get; set; }
    }
}