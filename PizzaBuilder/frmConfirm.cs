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
    public partial class frmConfirm : Form
    {

        String PrintOrderPizza;

        private Form1 ownerForm;

        public void SetOwner(Form theForm) {
            ownerForm = (Form1)theForm;
        }


        public frmConfirm()
        {
            
            InitializeComponent();
        }

        public frmConfirm(String PrintOrderPizza) {

            InitializeComponent();
            this.PrintOrderPizza = PrintOrderPizza;
            

        }

        private void frmConfirm_Load(object sender, EventArgs e) {

            rtbConfirm.Text = PrintOrderPizza; 
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
