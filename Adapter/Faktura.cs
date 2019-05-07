using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Faktura : IFaktury
    {
        private decimal _sumaFaktury;
        public decimal DajSumuFaktury()
        {
            return _sumaFaktury;
        }
    }
}
