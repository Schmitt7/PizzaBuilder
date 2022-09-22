using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    public class Pizza
    {
        private string Size;
        private string Crust;
        private string Sauce;
        
        
        string ExtraList;

        private Boolean Pep;
        private Boolean Beef;
        private Boolean Pineapple;
        private Boolean Rpep;
        private Boolean Bacon;
        private Boolean Sasuage;
        private Boolean Ham;
        private Boolean Anchov;
        private Boolean Gpep;
        private Boolean Mush;
        private Boolean ExCheese;
        private Boolean ExSauce;
        private Boolean ExMeat;
        private Boolean ExVeg;
        private Boolean HalfMeat;
        private Boolean HalfVeg;
        private Boolean ExCrispy;
        private Boolean Mozz;
        private Boolean Feta;
        private Boolean Goat;

        public Pizza() { }

        public Pizza(string Size, string Crust, string Sauce)
        {
            this.Size = Size;
            this.Crust = Crust;
            this.Sauce = Sauce;

        }

        public Pizza(string Size, string Crust, string Sauce, Boolean Pep, Boolean Beef,
                     Boolean Pineapple, Boolean Rpep, Boolean Bacon, Boolean Sasuage,
                     Boolean Ham, Boolean Anchov, Boolean Gpep, Boolean Mush, Boolean ExCheese,
                     Boolean ExSauce, Boolean ExMeat, Boolean ExVeg, Boolean HalfMeat,
                     Boolean HalfVeg, Boolean ExCrispy, Boolean Mozz, Boolean Feta, Boolean Goat) {
            
            this.Size = Size;
            this.Crust = Crust;
            this.Sauce = Sauce;
            this.Pep = Pep;
            this.Beef = Beef;
            this.Pineapple = Pineapple;
            this.Rpep = Rpep;
            this.Bacon = Bacon;
            this.Sasuage = Sasuage;
            this.Ham = Ham;
            this.Anchov = Anchov;
            this.Gpep = Gpep;
            this.Mush = Mush;
            this.ExCheese = ExCheese;
            this.ExSauce = ExSauce;
            this.ExMeat = ExMeat;
            this.ExVeg = ExVeg;
            this.HalfMeat = HalfMeat;
            this.HalfVeg = HalfVeg;
            this.ExCrispy = ExCrispy;
            this.Mozz = Mozz;
            this.Feta = Feta;
            this.Goat = Goat;
        }


        public string GetSize() {
            return Size;
        }
        public string GetCrust() {
            return Crust;
        }
        public string GetSauce() {
            return Sauce;
        }

        public Boolean GetPep()
        {
            return Pep;
        }

        public Boolean GetBeef()
        {
            return Beef;
        }

        public Boolean GetPineapple()
        {
            return Pineapple;
        }

        public Boolean GetRpep()
        {
            return Rpep;
        }

        public Boolean GetBacon()
        {
            return Bacon;
        }

        public Boolean GetSasuage()
        {
            return Sasuage;
        }

        public Boolean GetHam()
        {
            return Ham;
        }

        public Boolean GetAnchov()
        {
            return Anchov;
        }

        public Boolean GetGpep()
        {
            return Gpep;
        }

        public Boolean GetMush()
        {
            return Mush;
        }

        public Boolean GetExCheese()
        {
            return ExCheese;
        }

        public Boolean GetExSauce()
        {
            return ExSauce;
        }

        public Boolean GetExMeat()
        {
            return ExMeat;
        }

        public Boolean GetExVeg()
        {
            return ExVeg;
        }

        public Boolean GetHalfMeat()
        {
            return HalfMeat;
        }

        public Boolean GetHalfVeg()
        {
            return HalfVeg;
        }

        public Boolean GetExCrispy()
        {
            return ExCrispy;
        }

        public Boolean GetMozz()
        {
            return Mozz;
        }

        public Boolean GetFeta()
        {
            return Feta;
        }

        public Boolean GetGoat()
        {
            return Goat;
        }
        public void SetSize(string value)
        {
            Size = value;
        }

        public void SetCrust(string value)
        {
            Crust = value;
        }

        public void SetSauce(string value)
        {
            Sauce = value;
        }

        public void SetPep(Boolean value) {
            Pep = value;
        }

        public void SetBeef(Boolean value)
        {
            Beef = value;
        }

        public void SetPineapple(Boolean value)
        {
            Pineapple = value;
        }

        public void SetRpep(Boolean value)
        {
            Rpep = value;
        }

        public void SetBacon(Boolean value)
        {
            Bacon = value;
        }

        public void SetSasuage(Boolean value)
        {
            Sasuage = value;
        }

        public void SetHam(Boolean value)
        {
            Ham = value;
        }

        public void SetAnchov(Boolean value)
        {
            Anchov = value;
        }

        public void SetGpep(Boolean value)
        {
            Gpep = value;
        }

        public void SetExCheese(Boolean value)
        {
            ExCheese = value;
        }

        public void SetExSauce(Boolean value)
        {
            ExSauce = value;
        }

        public void SetExMeat(Boolean value)
        {
            ExMeat = value;
        }

        public void SetExVeg(Boolean value)
        {
            ExVeg = value;
        }

        public void SetHalfMeat(Boolean value)
        {
            HalfMeat = value;
        }

        public void SetHalfVeg(Boolean value)
        {
            HalfVeg = value;
        }

        public void SetExCrispy(Boolean value)
        {
            ExCrispy = value;
        }

        public void SetMozz(Boolean value)
        {
            Mozz = value;
        }

        public void SetFeta(Boolean value)
        {
            Feta = value;
        }

        public void SetGoat(Boolean value)
        {
            Goat = value;
        }





        public string extras()
        {

            if (Pep == true)
            {

                ExtraList = ExtraList + ", Pepperoni";
            }
            if (Beef == true)
            {

                ExtraList = ExtraList + ", Ground Beef";
            }
            if (Pineapple == true)
            {

                ExtraList = ExtraList + ", Pineapple";
            }
            if (Rpep == true)
            {

                ExtraList = ExtraList + ", Red Peppers";
            }
            if (Bacon == true)
            {

                ExtraList = ExtraList + ", Bacon";
            }
            if (Sasuage == true)
            {

                ExtraList = ExtraList + ", Sasuage";
            }
            if (Ham == true)
            {

                ExtraList = ExtraList + ", Ham";
            }
            if (Anchov == true)
            {

                ExtraList = ExtraList + ", Anchovies";
            }
            if (Gpep == true)
            {

                ExtraList = ExtraList + ", Green Peppers";
            }
            if (Mush == true)
            {

                ExtraList = ExtraList + ", Mushrooms";
            }
            if (ExCheese == true)
            {

                ExtraList = ExtraList + ", Extra Cheese";
            }
            if (ExSauce == true)
            {

                ExtraList = ExtraList + ", Extra Sauce";
            }
            if (ExMeat == true)
            {

                ExtraList = ExtraList + ", Extra Meat";
            }
            if (ExVeg == true)
            {

                ExtraList = ExtraList + ", Extra Veggies";
            }
            if (HalfMeat == true)
            {

                ExtraList = ExtraList + ", Half Meat";
            }
            if (HalfVeg == true)
            {

                ExtraList = ExtraList + ", Half Veggies";
            }
            if (ExCrispy == true)
            {

                ExtraList = ExtraList + ", Extra Crispy";
            }
            if (Mozz == true)
            {

                ExtraList = ExtraList + ", Fresh Mozzerella";
            }
            if (Feta == true)
            {

                ExtraList = ExtraList + ", Feta Cheese";
            }
            if (Goat == true)
            {

                ExtraList = ExtraList + ", Goat Cheese";
            }

            

            return ExtraList;

            
        }


        public string PrintPizza() {
            return "Size: " + Size + System.Environment.NewLine
                    + "Crust: " + Crust + System.Environment.NewLine
                    + "Sauce: " + Sauce + System.Environment.NewLine
                    + "Extras: " + ExtraList + System.Environment.NewLine;
        }
    }
}
