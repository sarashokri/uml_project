using System;

public class Customer {
	private string name;
	private string shipping_address;
	private string email_address;
	private string phone_number;
	private string password;
	private Payment payment_information;

	public string GetName() {
		return this.name;
	}
	public void SetName(ref string name) {
		this.name = name;
	}
	public string GetShipping_address() {
		return this.shipping_address;
	}
	public void SetShipping_address(ref string shipping_address) {
		this.shipping_address = shipping_address;
	}
	public string GetEmail_address() {
		return this.email_address;
	}
	public void SetEmail_address(ref string email_address) {
		this.email_address = email_address;
	}
	public string GetPhone_number() {
		return this.phone_number;
	}
	public void SetPhone_number(ref string phone_number) {
		this.phone_number = phone_number;
	}
	public string GetPassword() {
		return this.password;
	}
	public void SetPassword(ref string password) {
		this.password = password;
	}
	public Payment GetPayment_information() {
		return this.payment_information;
	}
	public void SetPayment_information(ref Payment payment_information) {
		this.payment_information = payment_information;
	}
	public void Sign_up() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void Login() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void Search_for_a_listing() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void Change_account_information() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void Checkout_listings() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void View_added_listings_to_their_cart() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void Edit_added_listings_to_their_cart() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void Add_a_listing_to_their_cart() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void View_a_chosen_listing_information() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void View_all_available_listings() {
		throw new System.NotImplementedException("Not implemented");
	}
	public Customer() {
		throw new System.NotImplementedException("Not implemented");
	}

}
