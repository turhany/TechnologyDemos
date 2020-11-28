using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _11_HelperMethods.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public int Level { get; set; }
        public string Text { get; set; }
    }
}