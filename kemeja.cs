using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class kemeja : Pakaian 
    {
        public override void atasan()
        {
            Console.WriteLine("Ini adalah Pakaian jenis Kemeja : ");
            Console.WriteLine("Batik, resmi");

        }
    }
}