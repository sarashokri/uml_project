using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Project_online_Shopping
{
    class Payment
    {
      private  int card_number;
        private int pin_code;
        private string billing_addres;

        public Payment(int card_number, int pin_code, string billing_addres)
        {
            this.Card_number = card_number;
            this.Pin_code = pin_code;
            this.Billing_addres = billing_addres;
        }

        public override string ToString()
        {
            return "Card_number : "+ Card_number+ " pin_code : " + pin_code + " billing_addres : " + Billing_addres;
        }
        public bool Holder(Customer c)
        {
            return c.Payment_info.pin_code == this.pin_code && c.Payment_info.Billing_addres == this.Billing_addres && c.Payment_info.Card_number == this.Card_number;
        }
        public int Card_number { get => card_number; set => card_number = value; }
        public int Pin_code { get => pin_code; set => pin_code = value; }
        public string Billing_addres { get => billing_addres; set => billing_addres = value; }
    }
}
