using System.Collections.Generic;
using _12_MVC_EF_CodeFirst.Models;

namespace _12_MVC_EF_CodeFirst.ViewModels.Home
{
    public class HomePageViewModel
    {
        public List<Kisiler> Kisiler { get; set; }
        public List<Adresler> Adresler { get; set; }
    }
}