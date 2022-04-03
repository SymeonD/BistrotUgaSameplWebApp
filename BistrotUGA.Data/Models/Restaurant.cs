using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistrotUGA.Data.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BistrotDish[] Dishes { get; set; }
        public byte[] Images { get; set; }
        public string Adress { get; set; }
        public void addDish(BistrotDish dish)
        {
            if(Dishes != null)
            {
                Dishes = Dishes.Concat(new BistrotDish[] { dish }).ToArray();
            }
            else
            {
                Dishes = new BistrotDish[] { dish };
            }
        }
    }
}
