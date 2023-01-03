using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Project_online_Shopping
{
    class Listings
    {
        public int id;
        public Seller s;
      private  string name_of_the_listing;
        private string description;

        private int price;

        private int number_of_items;

        public Listings(string name_of_the_listing, string description, int price, int number_of_items)
        {
            this.Name_of_the_listing = name_of_the_listing;
            this.Description = description;
            this.Price = price;
            this.Number_of_items = number_of_items;
        }

        public override string ToString()
        {
            return s.ToString()+"\n"+ id+"\t"+name_of_the_listing+ "\t" + description+"\t"+ price+ "\t" + number_of_items;
        }

        public string Name_of_the_listing { get => name_of_the_listing; set => name_of_the_listing = value; }
        public string Description { get => description; set => description = value; }
        public int Price { get => price; set => price = value; }
        public int Number_of_items { get => number_of_items; set => number_of_items = value; }
    }
}
