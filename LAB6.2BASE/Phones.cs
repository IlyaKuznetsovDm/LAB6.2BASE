using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6._2BASE
{
    public class Phones
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string? ToString()
        {
            return $"Название:{Name}, " +
                $"Цена:{Price}";
        }
    }
}
