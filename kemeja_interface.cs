using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class kemeja : IPakaian
    {
        public void atasan()
        {

                Console.WriteLine("Ini adalah pakaian jenis kemeja : ");
                Console.WriteLine("Batik, resmi");
        }
    }
}