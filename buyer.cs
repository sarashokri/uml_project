using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UML_Project_online_Shopping
{
    class buyer
    {
      private  int customer_id;
        private List<Listings> cart;
        public buyer(int customer_id, string name, string shipping_address, string email_address, int phone_number, string password, Payment payment_info)
        {
            this.Customer_id = customer_id;
            this.Name = name;
            this.Shipping_address = shipping_address;
            this.Email_address = email_address;
            this.Phone_number = phone_number;
            this.Password = password;
            this.Payment_info = payment_info;
            cart = new List<Listings>();
        }
        void Sign_upFor_buyer_account()
        {
            Console.WriteLine("Plz Input your data like : int customer_id, string name, string shipping_address, string email_address, int phone_number, string password,int card_number, int pin_code, string billing_addres");
            string input = Console.ReadLine();
            string[] all = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            this.Customer_id = int.Parse(all[0]);
            this.Name = all[1];
            this.Shipping_address = all[2];
            this.Email_address = all[3];
            this.Phone_number = int.Parse(all[4]); 
            this.Password = all[5];
            this.Payment_info = new Payment(int.Parse(all[6]), int.Parse(all[7]), (all[8]));
            cart = new List<Listings>();
        }
void View_all_available_listings()
        {
            foreach(Listings l in Program.all_Listings)
            {
                Console.WriteLine(l.ToString());
            }
        }
        void View_a_hosen_listing_information()
        {
            Console.WriteLine("ID : ");
            int f = int.Parse(Console.ReadLine());
            foreach (Listings l in Program.all_Listings)
            {
                if(l.id==f)
                Console.WriteLine(l.ToString());
            }

        }
        void Add_A_listing_to_their_cart()
        {
            Console.WriteLine("ID : ");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("How Many : ");
            int m = int.Parse(Console.ReadLine());
            foreach (Listings l in Program.all_Listings)
            {
                if (l.id == f)
                {
                    if (m < l.Number_of_items)
                    {
                        l.Number_of_items = m;
                        cart.Add(l);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sorray but the Number_of_items is " + l.Number_of_items);
                        break;
                    }
                }
            }
        }
        void View_Edit_added_listings_to_their_cart()
        {
            foreach (Listings l in cart)
            {
              
                    Console.WriteLine(l.ToString());
            }
        }
        void Checkout_listingsO()
        {
            double sum = 0;
            foreach (Listings l in cart)
            {
                sum += l.Price * l.Number_of_items;
                Console.WriteLine(l.ToString());
            }
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Done Go to pay press 1 no press 2 ");
            int c = int.Parse(Console.ReadLine());
            if (c == 1)
            {
                Console.WriteLine("Input card number ");
                int card= int.Parse(Console.ReadLine());
                Console.WriteLine("Input card pin number ");
                int pin = int.Parse(Console.ReadLine());
             bool a=   this.payment_info.Holder(card, pin);
                if (a)
                {
                    Console.WriteLine("Done");
                    for(int i = 0; i < cart.Count; i++)
                    {
                        Listings l = cart.ElementAt(i);
                        Program.allSold_Listings.Add(l);
                       for(int j = 0; j < Program.all_Listings.Count; j++)
                        {
                            if (Program.all_Listings.ElementAt(j).id == l.id)
                            {
                                Program.all_Listings.ElementAt(j).Number_of_items -= l.Number_of_items;
                                if (Program.all_Listings.ElementAt(j).Number_of_items == 0)
                                {
                                    Program.all_Listings.RemoveAt(j);

                                }
                                break;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("payment_info is wrong");
                }
            }
        }
        void Change_account_information()
        {
            Program.all_Customer.Remove(this);
            Console.WriteLine("Plz Input your data like : int customer_id, string name, string shipping_address, string email_address, int phone_number, string password,int card_number, int pin_code, string billing_addres");
            string input = Console.ReadLine();
            string[] all = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            this.Customer_id = int.Parse(all[0]);
            this.Name = all[1];
            this.Shipping_address = all[2];
            this.Email_address = all[3];
            this.Phone_number = int.Parse(all[4]);
            this.Password = all[5];
            this.Payment_info = new Payment(int.Parse(all[6]), int.Parse(all[7]), (all[8]));
            Program.all_Customer.Add(this);
            
        }
        void search_fora_listing()
        {
            Console.WriteLine("Name or part : ");
            string f = (Console.ReadLine());
            foreach (Listings l in Program.all_Listings)
            {
                if (l.Name_of_the_listing.Contains(f))
                    Console.WriteLine(l.ToString());
            }
        }
        void Login_For_buyer_account()
        {
            Console.WriteLine("Email address ");
            string em = Console.ReadLine();
            Console.WriteLine("Password ");
            string pa = Console.ReadLine();
            foreach (buyer l in Program.all_Customer)
            {
                if (l.email_address.Equals(em) && l.password.Equals(pa))
                {
                    Program.login_c = l;
                    break;
                }
            }

        }
        private string name;

        private string shipping_address;
        private string email_address;

        private int phone_number;
        private string password;

        private Payment payment_info;

        public int Customer_id { get => customer_id; set => customer_id = value; }
        public string Name { get => name; set => name = value; }
        public string Shipping_address { get => shipping_address; set => shipping_address = value; }
        public string Email_address { get => email_address; set => email_address = value; }
        public int Phone_number { get => phone_number; set => phone_number = value; }
        public string Password { get => password; set => password = value; }
        internal Payment Payment_info { get => payment_info; set => payment_info = value; }
    }
}
