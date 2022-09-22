using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    public class Order
    {
        private object pizza;
        private object customer;
        private Boolean delivery;
        private double tip;
        private DateTime timeOrder;
        private String picDel;
        

        double BasicFeeCalc;

        public Order() { }

        public Order(object pizza, object customer,double tip, Boolean delivery, DateTime timeOrder) {
            
            this.pizza = pizza;
            this.customer = customer;
            this.delivery = delivery;
            this.tip = tip;
            this.timeOrder = timeOrder;
        }

        public object GetPizza() {
            return pizza;
        }

        public object GetCustomer() {
            return customer;
        }

        public Boolean GetDelivery() {
            return delivery;
        }

        public double GetTip() {
            return tip;
        }

        public DateTime GetDateTime() {
            return timeOrder;
        }

        public void SetPizza(object value) {
            pizza = value;
        }

        public void SetCustomer(object value) {
            customer = value;
        }

        public void SetDelivery(Boolean value) {
            delivery = value;
        }

        public void SetTip(double value) {
            tip = value;
        }

        public void SetDatetime(DateTime value) {
            timeOrder = value;
        }


        public string PrintOrder(Customer customer, Pizza pizza) {
            
            return  "Date and Time: " + System.Environment.NewLine + 
                    timeOrder.ToString("f") + System.Environment.NewLine + System.Environment.NewLine +
                    "Delivery / Pick-up: " + System.Environment.NewLine +
                    picDel + System.Environment.NewLine + System.Environment.NewLine +
                    "Customer: " + System.Environment.NewLine +
                    customer.PrintCust() + System.Environment.NewLine + System.Environment.NewLine +
                    "Pizza: " + System.Environment.NewLine +
                    pizza.PrintPizza() + System.Environment.NewLine + System.Environment.NewLine +
                    "Total Cost: " + BasicFeeCalc.ToString("c");
        }

        public double BasicCalc(Pizza pizza)
        {

            if (pizza.GetSize() == "small")
            {
                BasicFeeCalc = BasicFeeCalc + 10;
            }

            else if (pizza.GetSize() == "medium")
            {
                BasicFeeCalc = BasicFeeCalc + 12;
            }

            else if (pizza.GetSize() == "large")
            {
                BasicFeeCalc = BasicFeeCalc + 15;
            }

            else if (pizza.GetSize() == "extra-large")
            {
                BasicFeeCalc = BasicFeeCalc + 20;
            }
            //regular
            //stuffed
            //deep dish
            //thin
            //cheesy garlic butter

            if (pizza.GetCrust() == "regular")
            {
                BasicFeeCalc = BasicFeeCalc + 0;
            }

            else if (pizza.GetCrust() == "stuffed")
            {
                BasicFeeCalc = BasicFeeCalc + 5;
            }

            else if (pizza.GetCrust() == "deep dish")
            {
                BasicFeeCalc = BasicFeeCalc + 4;
            }

            else if (pizza.GetCrust() == "thin")
            {
                BasicFeeCalc = BasicFeeCalc + 2;
            }

            else if (pizza.GetCrust() == "cheesy garlic butter")
            {
                BasicFeeCalc = BasicFeeCalc + 6;
            }
            //Tomato
            //White
            //Pesto
            //No Sauce
            if (pizza.GetSauce() == "Tomato")
            {
                BasicFeeCalc = BasicFeeCalc + 1;
            }

            else if (pizza.GetSauce() == "White")
            {
                BasicFeeCalc = BasicFeeCalc + 2;
            }

            else if (pizza.GetSauce() == "Pesto")
            {
                BasicFeeCalc = BasicFeeCalc + 3;
            }

            else if (pizza.GetSauce() == "No Sauce")
            {
                BasicFeeCalc = BasicFeeCalc + 0;
            }

            if (pizza.GetPep() == true)
            {
                BasicFeeCalc = BasicFeeCalc + 3;
                
            }
            if (pizza.GetBeef() == true)
            {
                BasicFeeCalc = BasicFeeCalc + 3;
                
            }
            if (pizza.GetPineapple() == true)
            {
                BasicFeeCalc = BasicFeeCalc + 3;
                
            }
            if (pizza.GetRpep() == true)
            {
                BasicFeeCalc = BasicFeeCalc + 2;
                
            }
            if (pizza.GetBacon() == true)
            {
                BasicFeeCalc = BasicFeeCalc + 3;
                
            }
            if (pizza.GetSasuage() == true)
            {
                BasicFeeCalc = BasicFeeCalc + 3;
                
            }
            if (pizza.GetHam() == true)
            {
                BasicFeeCalc = BasicFeeCalc + 3;
                
            }
            if (pizza.GetAnchov() == true)
            {
                BasicFeeCalc = BasicFeeCalc + 3;
                
            }
            if (pizza.GetGpep() == true)
            {
                BasicFeeCalc = BasicFeeCalc + 2;
                
            }
            if (pizza.GetMush() == true)
            {
                BasicFeeCalc = BasicFeeCalc + 2;
                
            }
            if (pizza.GetExCheese() == true)
            {
                BasicFeeCalc = BasicFeeCalc + 3;
                
            }
            if (pizza.GetExSauce() == true)
            {
                BasicFeeCalc = BasicFeeCalc + 3;
                
            }
            if (pizza.GetExMeat() == true)
            {
                BasicFeeCalc = BasicFeeCalc + 3;
                
            }
            if (pizza.GetExVeg() == true)
            {
                BasicFeeCalc = BasicFeeCalc + 3;
                
            }
            if (pizza.GetHalfMeat() == true)
            {
                BasicFeeCalc = BasicFeeCalc + 1;
                
            }
            if (pizza.GetHalfVeg() == true)
            {
                BasicFeeCalc = BasicFeeCalc + 1;
                
            }
            if (pizza.GetExCrispy() == true)
            {
                BasicFeeCalc = BasicFeeCalc + 1;
                
            }
            if (pizza.GetMozz() == true)
            {
                BasicFeeCalc = BasicFeeCalc + 4;
                
            }
            if (pizza.GetFeta() == true)
            {
                BasicFeeCalc = BasicFeeCalc + 4;
                
            }
            if (pizza.GetGoat() == true)
            {
                BasicFeeCalc = BasicFeeCalc + 4;
                
            }

            if (delivery == true)
            {
                BasicFeeCalc = BasicFeeCalc + 5;
                picDel = "Delivery";
            }
            else {
                picDel = "Pick Up";
            }

            if (tip != 0) {
                BasicFeeCalc = BasicFeeCalc + tip;
            }
            
            return BasicFeeCalc;
        }
 
    }
}
