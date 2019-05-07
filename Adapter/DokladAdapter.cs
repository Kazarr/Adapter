using ConsoleApp1.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Adapter
{
    public class DokladAdapter : IFaktury
    {
        private Doklad _doklad;

        public DokladAdapter(Doklad doklad)
        {
            _doklad = doklad;
        }
        public decimal DajSumuFaktury()
        {
            return (decimal)_doklad.DajSumuDokladu();
        }
    }
}
