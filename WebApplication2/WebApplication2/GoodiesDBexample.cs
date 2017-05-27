using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public static class GoodiesDBexample
    {
        public static List<Goodie> Goodies { get; set; }
        static GoodiesDBexample()
        {
            Goodies = new List<Goodie>();

            Goodie P70;
            P70 = new Goodie();
            P70.name = "Lenovo";
            P70.model = "P70";
            P70.price = 250;
            P70.age = 2015;

            Goodie P90;
            P90 = new Goodie();
            P90.name = "Lenovo";
            P90.model = "P90";
            P90.price = 320;
            P90.age = 2015;

            Goodie P780;
            P780 = new Goodie();
            P780.name = "Lenovo";
            P780.model = "P780";
            P780.price = 200;
            P780.age = 2014;

        }
    }
    public class Goodie
    {
        public string name { get; set; }
        public string model { get; set; }
        public double price { get; set; }
        public double age { get; set; }
    }

}