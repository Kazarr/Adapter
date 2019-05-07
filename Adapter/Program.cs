using ConsoleApp1.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFaktury> faktury = new List<IFaktury>();
            IFaktury f1 = new Faktura();

            faktury.Add(f1);

            Doklad doklad = new Doklad();
            IFaktury f2 = new DokladAdapter(doklad);

            faktury.Add(f2);
        }
    }
}
