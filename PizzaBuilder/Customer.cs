using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    public class Customer
    {
        private string name;
        private string address;
        private string phone;
        

        public Customer() { }

        public Customer(string name, string address, string phone) {

            this.name = name;
            this.address = address;
            this.phone = phone;
            
        }

        public string GetName() {
            return name;
        }

        public string GetAddress() {
            return address;
        }

        public string GetPhone() {
            return phone;
        }

        

        public void SetName(string value) {
            name = value;
        }

        public void SetAddress(string value) {
            address = value;
        }

        public void SetPhone(string value) {
            phone = value;
        }

        

        public string PrintCust() {
            return "Name: " + name + System.Environment.NewLine
                    + "Address: " + address + System.Environment.NewLine
                    + "Phone: " + phone.ToString();
        }
        
        //public void PrintCust() {
            /*MessageBox.Show("Name: " + name + System.Environment.NewLine
                          + "Address: " + address + System.Environment.NewLine
                          + "Phone: " + phone);
            */
        //}
        

    }
}
