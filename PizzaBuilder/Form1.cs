using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaBuilder
{


    public partial class Form1 : Form
    {
        String PizzaPrintLabel;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            String size = Convert.ToString(cmbSize.SelectedItem);
            String crust = Convert.ToString(cmbCrust.SelectedItem);
            String sauce = Convert.ToString(cmbSauce.SelectedItem);

            //String PizzaPrintLabel;

            Boolean Pep = false;
            Boolean Beef = false;
            Boolean Pineapple = false;
            Boolean Rpep = false;
            Boolean Bacon = false;
            Boolean Sasuage = false;
            Boolean Ham = false;
            Boolean Anchov = false;
            Boolean Gpep = false;
            Boolean Mush = false;
            Boolean ExCheese = false;
            Boolean ExSauce = false;
            Boolean ExMeat = false;
            Boolean ExVeg = false;
            Boolean HalfMeat = false;
            Boolean HalfVeg = false;
            Boolean ExCrispy = false;
            Boolean Mozz = false;
            Boolean Feta = false;
            Boolean Goat = false;


            String name = txtName.Text;
            String address = txtAddress.Text;
            String phone = txtPhone.Text;
            double tip;
            Boolean delivery = false;

            

            tip = Convert.ToDouble(txtTip.Text);

            if (rbDelivery.Checked == true) {
                delivery = true;
            }

            if (cbEcheese.Checked) {
                ExCheese = true;
            }
            if (cbEmeat.Checked)
            {
                ExMeat = true;
            }
            if (cbEsauce.Checked)
            {
                ExSauce = true;
            }
            if (cbEveg.Checked)
            {
                ExVeg = true;
            }
            if (cbHalfMeat.Checked)
            {
                HalfMeat = true;
            }
            if (cbHalfVeg.Checked)
            {
                HalfVeg = true;
            }
            if (cbEcrispy.Checked)
            {
                ExCrispy = true;
            }
            if (cbMozz.Checked)
            {
                Mozz = true;
            }
            if (cbFeta.Checked)
            {
                Feta = true;
            }
            if (cbGoat.Checked)
            {
                Goat = true;
            }

            if (cbPep.Checked) {

                Pep = true;
            }
            if (cbSausage.Checked)
            {
                Sasuage = true;
            }
            if (cbBeef.Checked)
            {
                Beef = true;
            }
            if (cbHam.Checked) {

                Ham = true;
            }
            if (cbPineapple.Checked)
            {
                Pineapple = true;
            }
            if (cbAnchov.Checked)
            {
                Anchov = true;
            }
            if (cbRPeppers.Checked)
            {
                Rpep = true;
            }
            if (cbGPeppers.Checked)
            {
                Gpep = true;
            }
            if (cbBacon.Checked)
            {
                Bacon = true;
            }
            if (cbMush.Checked)
            {
                Mush = true;
            }


            //Get Date time of order
            DateTime orderTime = DateTime.Now;

            //Create customer object with data from name, address, and phone
            Customer cust;
            cust = new Customer(name, address, phone);


            //Create pizza object with all options 
            Pizza pizza;
            pizza = new Pizza(size, crust, sauce, Pep, Beef,
                     Pineapple, Rpep, Bacon, Sasuage,
                     Ham, Anchov, Gpep, Mush, ExCheese,
                     ExSauce, ExMeat, ExVeg, HalfMeat,
                     HalfVeg, ExCrispy, Mozz, Feta, Goat);


            //Build a string that holds all the data from extras
            pizza.extras();
            
            
            //Create new order object and pass in pizza/customer objects
            Order order;
            order = new Order(pizza, cust, tip, delivery, orderTime);

            //Calculate cost of pizza
            order.BasicCalc(pizza);
            //MessageBox.Show(Convert.ToString(order.BasicCalc(pizza)));

            //Shows full order info in a message box
            MessageBox.Show(order.PrintOrder(cust, pizza));

           

            //Create new form
            frmConfirm ConfirmForm = new frmConfirm(order.PrintOrder(cust, pizza));
            

            //Gotten from class slide examples

            // Pass an instance of the current form (Form1 object) to the
            // frmConfirm object so that it knows the object that created and opened it.
            ConfirmForm.SetOwner(this);
            ConfirmForm.ShowDialog();


            // Get the Form1 object's data from it's controls. These textboxes
            // were given the internal access modifier in their declarations stored in
            // the form's designer file (frmCustomer.designer.cs file).

            //Set string PizzaPrintLabel to the pizza print return string

            
            //PizzaPrintLabel = order.PrintOrder(cust, pizza);
            //PizzaPrintLabel = ConfirmForm.lblConfirm1.Text;



        }
    }
}
