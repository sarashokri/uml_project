using System;
using System.Collections.Generic;

namespace UML_Project_online_Shopping
{
    class Program
    {
       public static List<buyer> all_Customer=new List<buyer>();
        public static List<Seller> all_Seller = new List<Seller>();
        public static List<Listings> all_Listings = new List<Listings>();
        public static List<Listings> allSold_Listings = new List<Listings>();
        public static buyer login_c =null;
        public static Seller login_s = null;
        public static List<Listings> sold_Listings = new List<Listings>();
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
        }
    }
}
