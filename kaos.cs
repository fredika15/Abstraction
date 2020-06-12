using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class kaos : Pakaian 
    {
        public override void atasan()
        {
            Console.WriteLine("ini adalah pakaian jenis kaos");
            Console.WriteLine("lengan panjang, lengan pendek");
        }
    }
}