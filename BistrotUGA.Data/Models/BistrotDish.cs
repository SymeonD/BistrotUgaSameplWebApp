using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistrotUGA.Data.Models
{
    public class BistrotDish
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public MenuType MenuType { get; set; }

        public Restaurant Restaurant { get; set; }

        public float Price { get; set; }

        public byte[] Image { get; set; }   

        public String[] Ingredients { get; set; }

    }
}
