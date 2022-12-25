using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Shopping_Project
{
    class Seller
    {

		private string name;
		private List<Listings> listings_;
		private string store_name;
		private string phone_number;
		private string email_address;
		private string address;

        public string Name { get => name; set => name = value; }
        internal List<Listings> Listings_ { get => listings_; set => listings_ = value; }
        public string Store_name { get => store_name; set => store_name = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public string Email_address { get => email_address; set => email_address = value; }
        public string Address { get => address; set => address = value; }

        public Seller()
		{
			throw new System.NotImplementedException("Not implemented");
		}
		public  void Sign_up()
		{
			throw new System.NotImplementedException("Not implemented");
		}
		public  void Change_account_information()
		{
			throw new System.NotImplementedException("Not implemented");
		}
		public void View_sold_listings_information()
		{
			throw new System.NotImplementedException("Not implemented");
		}
		public void  View_all_listings()
		{
			throw new System.NotImplementedException("Not implemented");
		}
		public void Change_info_and_price_for_existing_listing()
		{
			throw new System.NotImplementedException("Not implemented");
		}
		public void  Delete_existing_listing()
		{
			throw new System.NotImplementedException("Not implemented");
		}
		public void Adding_new_listing()
		{
			throw new System.NotImplementedException("Not implemented");
		}
		public  void Login()
		{
			throw new System.NotImplementedException("Not implemented");
		}
	}
}
