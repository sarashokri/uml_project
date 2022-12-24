using System;

public class Listings {
	private string name_of_the_listing;
	private string description;
	private double price_;
	private int number_of_items;

	public Listings() {
		throw new System.NotImplementedException("Not implemented");
	}
	public string GetName_of_the_listing() {
		return this.name_of_the_listing;
	}
	public void SetName_of_the_listing(ref string name_of_the_listing) {
		this.name_of_the_listing = name_of_the_listing;
	}
	public string GetDescription() {
		return this.description;
	}
	public void SetDescription(ref string description) {
		this.description = description;
	}
	public double GetPrice_() {
		return this.price_;
	}
	public void SetPrice_(ref double price_) {
		this.price_ = price_;
	}
	public int GetNumber_of_items() {
		return this.number_of_items;
	}
	public void SetNumber_of_items(ref int number_of_items) {
		this.number_of_items = number_of_items;
	}

}
