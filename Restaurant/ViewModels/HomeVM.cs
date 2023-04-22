using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.ViewModels
{
    public class HomeVM
    {
        public About About { get; set; }
        public List<Team> Teams { get; set; }
    }
}
