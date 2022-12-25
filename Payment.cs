using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Shopping_Project
{
    class Payment
    {
		private int card_number;
		private int pin_code;
		private string billing_address;

		public Payment()
		{
			throw new System.NotImplementedException("Not implemented");
		}
		public int GetCard_number()
		{
			return this.card_number;
		}
		public void SetCard_number(ref int card_number)
		{
			this.card_number = card_number;
		}
		public int GetPin_code()
		{
			return this.pin_code;
		}
		public void SetPin_code(ref int pin_code)
		{
			this.pin_code = pin_code;
		}
		public string GetBilling_address()
		{
			return this.billing_address;
		}
		public void SetBilling_address(ref string billing_address)
		{
			this.billing_address = billing_address;
		}
	}
}
