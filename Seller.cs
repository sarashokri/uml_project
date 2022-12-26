using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Project_online_Shopping
{
    class Seller
    {
        private string name;
        private string password;
        private string address;

        private string email_address;
        private string phone_number;
        private string store_name;
        private List<Listings> Listings;
        void Sign_up_for_seller_account()
        {

        }

void Adding_new_Listings()
        {

        }

void Delete_existing_listing()
        {

        }

void Change_info_and_price_for_existing_listing(Listings s)
        {

        }
void view_all_listings()
        {

        }

void view_sold_listings_information()
        {

        }

void Change_account_information()
        {

        }

        public Seller()
        {
            Listings1 = new List<Listings>();
        }

        public Seller(string name, string password, string address, string email_address, string phone_number, string store_name, List<Listings> listings)
        {
            this.Name = name;
            this.password = password;
            this.Address = address;
            this.Email_address = email_address;
            this.Phone_number = phone_number;
            this.Store_name = store_name;
            Listings1 = listings;
        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Email_address { get => email_address; set => email_address = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public string Store_name { get => store_name; set => store_name = value; }
        internal List<Listings> Listings1 { get => Listings; set => Listings = value; }
    }
}
