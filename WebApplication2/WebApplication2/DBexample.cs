using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public static class DBexample
    {
        public static List<User> Users { get; set; }
        static DBexample()
        {
            Users = new List<User>();

            User Kira;
            Kira = new User();
            Kira.name = "Kirill";
            Kira.login = "meoleki";
            Kira.password = "qqqqqq";
            Kira.age = 1998;
            Users.Add(Kira);

            User Vlad;
            Vlad = new User();
            Vlad.name = "Vladislav";
            Vlad.login = "smetanka";
            Vlad.password = "adohat64";
            Vlad.age = 1998;
            Users.Add(Vlad);
        }
    }
    public class User
    {
        public string name { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public double age { get; set; }
    }

}