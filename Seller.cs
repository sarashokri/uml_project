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
            Console.WriteLine("Plz Input your data like : string name, string password, string address, string email_address, string phone_number, string store_name");
              string input = Console.ReadLine();
            string[] all = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            this.Name = all[0];
            this.password = all[1];
            this.Address = all[2];
            this.Email_address = all[3];
            this.Phone_number = all[4];
            this.Store_name = all[5];

        }
        void Login_For_Seller_account()
        {
            Console.WriteLine("Email address ");
            string em = Console.ReadLine();
            Console.WriteLine("Password ");
            string pa = Console.ReadLine();
            foreach (Seller l in Program.all_Seller)
            {
                if (l.email_address.Equals(em) && l.password.Equals(pa))
                {
                    Program.login_s = l;
                    break;
                }
            }

        }
        void Adding_new_Listings()
        {
            Console.WriteLine("Input All info : ");
            Console.WriteLine("Plz Input your data like : string name_of_the_listing, string description, int price, int number_of_items");
            string input = Console.ReadLine();
            string[] all = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            Listings a = new Listings(all[0], all[1], int.Parse(all[3]), int.Parse(all[4]));
            a.s = this;
            this.Listings.Add(a);
            Program.all_Listings.Add(a);
          
        }

void Delete_existing_listing()
        {
            Console.WriteLine("Input Listings id");
            string input = Console.ReadLine();
            foreach (Listings l in Listings)
            {
                if (l.id == int.Parse(input))
                {
                    Listings.Remove(l);
                    break;

                }
            }
        }

void Change_info_and_price_for_existing_listing(Listings s)
        {
            Console.WriteLine("Input Listings id");
            string input = Console.ReadLine();
            foreach (Listings l in Listings)
            {
                if (l.id == int.Parse(input))
                {
                    Console.WriteLine("Input new price");
                    Listings.Remove(l);

                    Console.WriteLine("Plz Input your data like : string name_of_the_listing, string description, int price, int number_of_items");
                    input = Console.ReadLine();
                    string[] all = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    Listings a = new Listings(all[0], all[1], int.Parse(all[3]), int.Parse(all[4]));
                    a.s = this;
                 
                    this.Listings.Add(a);
                    Program.all_Listings.Add(a);
                   
                    break;

                }
            }
        }
void view_all_listings()
        {
            foreach (Listings l in Program.all_Listings)
            {
                Console.WriteLine(l.ToString());
            }
        }

void view_sold_listings_information()
        {
            foreach (Listings l in Program.sold_Listings)
            {
                Console.WriteLine(l.ToString());
            }
        }

void Change_account_information()
        {

        }

        public Seller()
        {
            Listings1 = new List<Listings>();
        }

        public Seller(string name, string password, string address, string email_address, string phone_number, string store_name)
        {
            this.Name = name;
            this.password = password;
            this.Address = address;
            this.Email_address = email_address;
            this.Phone_number = phone_number;
            this.Store_name = store_name;
            Listings1 = new List<Listings>();
        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Email_address { get => email_address; set => email_address = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public string Store_name { get => store_name; set => store_name = value; }
        internal List<Listings> Listings1 { get => Listings; set => Listings = value; }
    }
}
