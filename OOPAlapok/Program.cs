﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAlapok
{
    public class Szemely
    {
        public string nev = "Peti";
        public int kor=34;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely();
            Console.WriteLine($"A tanulo neve: {tanulo1.nev} és {tanulo1.kor} éves.");
        }
    }
}
