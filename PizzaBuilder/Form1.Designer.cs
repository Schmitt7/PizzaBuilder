
namespace PizzaBuilder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.rbPickUp = new System.Windows.Forms.RadioButton();
            this.rbDelivery = new System.Windows.Forms.RadioButton();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbPizza = new System.Windows.Forms.GroupBox();
            this.cmbSauce = new System.Windows.Forms.ComboBox();
            this.cmbCrust = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPizzaSize = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.gbBasicExtra = new System.Windows.Forms.GroupBox();
            this.cbMush = new System.Windows.Forms.CheckBox();
            this.cbBacon = new System.Windows.Forms.CheckBox();
            this.cbGPeppers = new System.Windows.Forms.CheckBox();
            this.cbRPeppers = new System.Windows.Forms.CheckBox();
            this.cbAnchov = new System.Windows.Forms.CheckBox();
            this.cbPineapple = new System.Windows.Forms.CheckBox();
            this.cbHam = new System.Windows.Forms.CheckBox();
            this.cbBeef = new System.Windows.Forms.CheckBox();
            this.cbSausage = new System.Windows.Forms.CheckBox();
            this.cbPep = new System.Windows.Forms.CheckBox();
            this.gbPreemExtra = new System.Windows.Forms.GroupBox();
            this.cbGoat = new System.Windows.Forms.CheckBox();
            this.cbFeta = new System.Windows.Forms.CheckBox();
            this.cbMozz = new System.Windows.Forms.CheckBox();
            this.cbHalfMeat = new System.Windows.Forms.CheckBox();
            this.cbEveg = new System.Windows.Forms.CheckBox();
            this.cbEmeat = new System.Windows.Forms.CheckBox();
            this.cbHalfVeg = new System.Windows.Forms.CheckBox();
            this.cbEcrispy = new System.Windows.Forms.CheckBox();
            this.cbEsauce = new System.Windows.Forms.CheckBox();
            this.cbEcheese = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.gbCustomer.SuspendLayout();
            this.gbPizza.SuspendLayout();
            this.gbBasicExtra.SuspendLayout();
            this.gbPreemExtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.rbPickUp);
            this.gbCustomer.Controls.Add(this.rbDelivery);
            this.gbCustomer.Controls.Add(this.txtPhone);
            this.gbCustomer.Controls.Add(this.txtAddress);
            this.gbCustomer.Controls.Add(this.txtName);
            this.gbCustomer.Controls.Add(this.lblPhone);
            this.gbCustomer.Controls.Add(this.lblAddress);
            this.gbCustomer.Controls.Add(this.lblName);
            this.gbCustomer.Location = new System.Drawing.Point(29, 12);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(497, 251);
            this.gbCustomer.TabIndex = 0;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer Info";
            // 
            // rbPickUp
            // 
            this.rbPickUp.AutoSize = true;
            this.rbPickUp.Location = new System.Drawing.Point(234, 196);
            this.rbPickUp.Name = "rbPickUp";
            this.rbPickUp.Size = new System.Drawing.Size(117, 29);
            this.rbPickUp.TabIndex = 7;
            this.rbPickUp.TabStop = true;
            this.rbPickUp.Text = "Pick Up";
            this.rbPickUp.UseVisualStyleBackColor = true;
            // 
            // rbDelivery
            // 
            this.rbDelivery.AutoSize = true;
            this.rbDelivery.Location = new System.Drawing.Point(12, 196);
            this.rbDelivery.Name = "rbDelivery";
            this.rbDelivery.Size = new System.Drawing.Size(121, 29);
            this.rbDelivery.TabIndex = 6;
            this.rbDelivery.TabStop = true;
            this.rbDelivery.Text = "Delivery";
            this.rbDelivery.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(234, 137);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 31);
            this.txtPhone.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(234, 86);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 31);
            this.txtAddress.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(234, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 31);
            this.txtName.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(7, 137);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(155, 25);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 89);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(91, 25);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // gbPizza
            // 
            this.gbPizza.Controls.Add(this.cmbSauce);
            this.gbPizza.Controls.Add(this.cmbCrust);
            this.gbPizza.Controls.Add(this.label2);
            this.gbPizza.Controls.Add(this.label1);
            this.gbPizza.Controls.Add(this.lblPizzaSize);
            this.gbPizza.Controls.Add(this.cmbSize);
            this.gbPizza.Location = new System.Drawing.Point(558, 12);
            this.gbPizza.Name = "gbPizza";
            this.gbPizza.Size = new System.Drawing.Size(408, 251);
            this.gbPizza.TabIndex = 1;
            this.gbPizza.TabStop = false;
            this.gbPizza.Text = "Pizza Basics";
            // 
            // cmbSauce
            // 
            this.cmbSauce.FormattingEnabled = true;
            this.cmbSauce.Items.AddRange(new object[] {
            "Tomato",
            "White",
            "Pesto",
            "No Sauce"});
            this.cmbSauce.Location = new System.Drawing.Point(209, 137);
            this.cmbSauce.Name = "cmbSauce";
            this.cmbSauce.Size = new System.Drawing.Size(121, 33);
            this.cmbSauce.TabIndex = 5;
            // 
            // cmbCrust
            // 
            this.cmbCrust.FormattingEnabled = true;
            this.cmbCrust.Items.AddRange(new object[] {
            "regular",
            "stuffed",
            "deep dish",
            "thin",
            "cheesy garlic butter"});
            this.cmbCrust.Location = new System.Drawing.Point(209, 89);
            this.cmbCrust.Name = "cmbCrust";
            this.cmbCrust.Size = new System.Drawing.Size(121, 33);
            this.cmbCrust.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sauce";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Crust";
            // 
            // lblPizzaSize
            // 
            this.lblPizzaSize.AutoSize = true;
            this.lblPizzaSize.Location = new System.Drawing.Point(15, 48);
            this.lblPizzaSize.Name = "lblPizzaSize";
            this.lblPizzaSize.Size = new System.Drawing.Size(113, 25);
            this.lblPizzaSize.TabIndex = 1;
            this.lblPizzaSize.Text = "Pizza Size";
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "small",
            "medium",
            "large",
            "extra-large"});
            this.cmbSize.Location = new System.Drawing.Point(209, 40);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(121, 33);
            this.cmbSize.TabIndex = 0;
            // 
            // gbBasicExtra
            // 
            this.gbBasicExtra.Controls.Add(this.cbMush);
            this.gbBasicExtra.Controls.Add(this.cbBacon);
            this.gbBasicExtra.Controls.Add(this.cbGPeppers);
            this.gbBasicExtra.Controls.Add(this.cbRPeppers);
            this.gbBasicExtra.Controls.Add(this.cbAnchov);
            this.gbBasicExtra.Controls.Add(this.cbPineapple);
            this.gbBasicExtra.Controls.Add(this.cbHam);
            this.gbBasicExtra.Controls.Add(this.cbBeef);
            this.gbBasicExtra.Controls.Add(this.cbSausage);
            this.gbBasicExtra.Controls.Add(this.cbPep);
            this.gbBasicExtra.Location = new System.Drawing.Point(558, 298);
            this.gbBasicExtra.Name = "gbBasicExtra";
            this.gbBasicExtra.Size = new System.Drawing.Size(408, 312);
            this.gbBasicExtra.TabIndex = 2;
            this.gbBasicExtra.TabStop = false;
            this.gbBasicExtra.Text = "Basic Extras";
            // 
            // cbMush
            // 
            this.cbMush.AutoSize = true;
            this.cbMush.Location = new System.Drawing.Point(201, 262);
            this.cbMush.Name = "cbMush";
            this.cbMush.Size = new System.Drawing.Size(156, 29);
            this.cbMush.TabIndex = 9;
            this.cbMush.Text = "Mushrooms";
            this.cbMush.UseVisualStyleBackColor = true;
            // 
            // cbBacon
            // 
            this.cbBacon.AutoSize = true;
            this.cbBacon.Location = new System.Drawing.Point(12, 262);
            this.cbBacon.Name = "cbBacon";
            this.cbBacon.Size = new System.Drawing.Size(105, 29);
            this.cbBacon.TabIndex = 8;
            this.cbBacon.Text = "Bacon";
            this.cbBacon.UseVisualStyleBackColor = true;
            // 
            // cbGPeppers
            // 
            this.cbGPeppers.AutoSize = true;
            this.cbGPeppers.Location = new System.Drawing.Point(201, 206);
            this.cbGPeppers.Name = "cbGPeppers";
            this.cbGPeppers.Size = new System.Drawing.Size(189, 29);
            this.cbGPeppers.TabIndex = 7;
            this.cbGPeppers.Text = "Green Peppers";
            this.cbGPeppers.UseVisualStyleBackColor = true;
            // 
            // cbRPeppers
            // 
            this.cbRPeppers.AutoSize = true;
            this.cbRPeppers.Location = new System.Drawing.Point(12, 206);
            this.cbRPeppers.Name = "cbRPeppers";
            this.cbRPeppers.Size = new System.Drawing.Size(169, 29);
            this.cbRPeppers.TabIndex = 6;
            this.cbRPeppers.Text = "Red Peppers";
            this.cbRPeppers.UseVisualStyleBackColor = true;
            // 
            // cbAnchov
            // 
            this.cbAnchov.AutoSize = true;
            this.cbAnchov.Location = new System.Drawing.Point(201, 152);
            this.cbAnchov.Name = "cbAnchov";
            this.cbAnchov.Size = new System.Drawing.Size(144, 29);
            this.cbAnchov.TabIndex = 5;
            this.cbAnchov.Text = "Anchovies";
            this.cbAnchov.UseVisualStyleBackColor = true;
            // 
            // cbPineapple
            // 
            this.cbPineapple.AutoSize = true;
            this.cbPineapple.Location = new System.Drawing.Point(12, 152);
            this.cbPineapple.Name = "cbPineapple";
            this.cbPineapple.Size = new System.Drawing.Size(140, 29);
            this.cbPineapple.TabIndex = 4;
            this.cbPineapple.Text = "Pineapple";
            this.cbPineapple.UseVisualStyleBackColor = true;
            // 
            // cbHam
            // 
            this.cbHam.AutoSize = true;
            this.cbHam.Location = new System.Drawing.Point(201, 100);
            this.cbHam.Name = "cbHam";
            this.cbHam.Size = new System.Drawing.Size(88, 29);
            this.cbHam.TabIndex = 3;
            this.cbHam.Text = "Ham";
            this.cbHam.UseVisualStyleBackColor = true;
            // 
            // cbBeef
            // 
            this.cbBeef.AutoSize = true;
            this.cbBeef.Location = new System.Drawing.Point(12, 100);
            this.cbBeef.Name = "cbBeef";
            this.cbBeef.Size = new System.Drawing.Size(165, 29);
            this.cbBeef.TabIndex = 2;
            this.cbBeef.Text = "Ground Beef";
            this.cbBeef.UseVisualStyleBackColor = true;
            // 
            // cbSausage
            // 
            this.cbSausage.AutoSize = true;
            this.cbSausage.Location = new System.Drawing.Point(201, 42);
            this.cbSausage.Name = "cbSausage";
            this.cbSausage.Size = new System.Drawing.Size(129, 29);
            this.cbSausage.TabIndex = 1;
            this.cbSausage.Text = "Sausage";
            this.cbSausage.UseVisualStyleBackColor = true;
            // 
            // cbPep
            // 
            this.cbPep.AutoSize = true;
            this.cbPep.Location = new System.Drawing.Point(12, 42);
            this.cbPep.Name = "cbPep";
            this.cbPep.Size = new System.Drawing.Size(142, 29);
            this.cbPep.TabIndex = 0;
            this.cbPep.Text = "Pepperoni";
            this.cbPep.UseVisualStyleBackColor = true;
            // 
            // gbPreemExtra
            // 
            this.gbPreemExtra.Controls.Add(this.cbGoat);
            this.gbPreemExtra.Controls.Add(this.cbFeta);
            this.gbPreemExtra.Controls.Add(this.cbMozz);
            this.gbPreemExtra.Controls.Add(this.cbHalfMeat);
            this.gbPreemExtra.Controls.Add(this.cbEveg);
            this.gbPreemExtra.Controls.Add(this.cbEmeat);
            this.gbPreemExtra.Controls.Add(this.cbHalfVeg);
            this.gbPreemExtra.Controls.Add(this.cbEcrispy);
            this.gbPreemExtra.Controls.Add(this.cbEsauce);
            this.gbPreemExtra.Controls.Add(this.cbEcheese);
            this.gbPreemExtra.Location = new System.Drawing.Point(29, 298);
            this.gbPreemExtra.Name = "gbPreemExtra";
            this.gbPreemExtra.Size = new System.Drawing.Size(497, 301);
            this.gbPreemExtra.TabIndex = 3;
            this.gbPreemExtra.TabStop = false;
            this.gbPreemExtra.Text = "Premium Extras";
            // 
            // cbGoat
            // 
            this.cbGoat.AutoSize = true;
            this.cbGoat.Location = new System.Drawing.Point(253, 261);
            this.cbGoat.Name = "cbGoat";
            this.cbGoat.Size = new System.Drawing.Size(231, 29);
            this.cbGoat.TabIndex = 9;
            this.cbGoat.Text = "Fresh Goat Cheese";
            this.cbGoat.UseVisualStyleBackColor = true;
            // 
            // cbFeta
            // 
            this.cbFeta.AutoSize = true;
            this.cbFeta.Location = new System.Drawing.Point(20, 261);
            this.cbFeta.Name = "cbFeta";
            this.cbFeta.Size = new System.Drawing.Size(228, 29);
            this.cbFeta.TabIndex = 8;
            this.cbFeta.Text = "Fresh Feta Cheese";
            this.cbFeta.UseVisualStyleBackColor = true;
            // 
            // cbMozz
            // 
            this.cbMozz.AutoSize = true;
            this.cbMozz.Location = new System.Drawing.Point(253, 204);
            this.cbMozz.Name = "cbMozz";
            this.cbMozz.Size = new System.Drawing.Size(210, 29);
            this.cbMozz.TabIndex = 7;
            this.cbMozz.Text = "Fresh Mozzarella";
            this.cbMozz.UseVisualStyleBackColor = true;
            // 
            // cbHalfMeat
            // 
            this.cbHalfMeat.AutoSize = true;
            this.cbHalfMeat.Location = new System.Drawing.Point(20, 150);
            this.cbHalfMeat.Name = "cbHalfMeat";
            this.cbHalfMeat.Size = new System.Drawing.Size(209, 29);
            this.cbHalfMeat.TabIndex = 6;
            this.cbHalfMeat.Text = "Meat only on half";
            this.cbHalfMeat.UseVisualStyleBackColor = true;
            // 
            // cbEveg
            // 
            this.cbEveg.AutoSize = true;
            this.cbEveg.Location = new System.Drawing.Point(253, 100);
            this.cbEveg.Name = "cbEveg";
            this.cbEveg.Size = new System.Drawing.Size(178, 29);
            this.cbEveg.TabIndex = 3;
            this.cbEveg.Text = "Extra Veggies";
            this.cbEveg.UseVisualStyleBackColor = true;
            // 
            // cbEmeat
            // 
            this.cbEmeat.AutoSize = true;
            this.cbEmeat.Location = new System.Drawing.Point(20, 100);
            this.cbEmeat.Name = "cbEmeat";
            this.cbEmeat.Size = new System.Drawing.Size(148, 29);
            this.cbEmeat.TabIndex = 2;
            this.cbEmeat.Text = "Extra Meat";
            this.cbEmeat.UseVisualStyleBackColor = true;
            // 
            // cbHalfVeg
            // 
            this.cbHalfVeg.AutoSize = true;
            this.cbHalfVeg.Location = new System.Drawing.Point(253, 152);
            this.cbHalfVeg.Name = "cbHalfVeg";
            this.cbHalfVeg.Size = new System.Drawing.Size(239, 29);
            this.cbHalfVeg.TabIndex = 5;
            this.cbHalfVeg.Text = "Veggies only on half";
            this.cbHalfVeg.UseVisualStyleBackColor = true;
            // 
            // cbEcrispy
            // 
            this.cbEcrispy.AutoSize = true;
            this.cbEcrispy.Location = new System.Drawing.Point(20, 204);
            this.cbEcrispy.Name = "cbEcrispy";
            this.cbEcrispy.Size = new System.Drawing.Size(161, 29);
            this.cbEcrispy.TabIndex = 4;
            this.cbEcrispy.Text = "Extra Crispy";
            this.cbEcrispy.UseVisualStyleBackColor = true;
            // 
            // cbEsauce
            // 
            this.cbEsauce.AutoSize = true;
            this.cbEsauce.Location = new System.Drawing.Point(253, 42);
            this.cbEsauce.Name = "cbEsauce";
            this.cbEsauce.Size = new System.Drawing.Size(161, 29);
            this.cbEsauce.TabIndex = 1;
            this.cbEsauce.Text = "Extra Sauce";
            this.cbEsauce.UseVisualStyleBackColor = true;
            // 
            // cbEcheese
            // 
            this.cbEcheese.AutoSize = true;
            this.cbEcheese.Location = new System.Drawing.Point(20, 42);
            this.cbEcheese.Name = "cbEcheese";
            this.cbEcheese.Size = new System.Drawing.Size(174, 29);
            this.cbEcheese.TabIndex = 0;
            this.cbEcheese.Text = "Extra Cheese";
            this.cbEcheese.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(29, 743);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 50);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(163, 743);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(168, 49);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Confirm Order";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(24, 687);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(140, 25);
            this.lblTip.TabIndex = 6;
            this.lblTip.Text = "Optional Tip: ";
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(163, 684);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(168, 31);
            this.txtTip.TabIndex = 7;
            this.txtTip.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 923);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbPreemExtra);
            this.Controls.Add(this.gbBasicExtra);
            this.Controls.Add(this.gbPizza);
            this.Controls.Add(this.gbCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.gbPizza.ResumeLayout(false);
            this.gbPizza.PerformLayout();
            this.gbBasicExtra.ResumeLayout(false);
            this.gbBasicExtra.PerformLayout();
            this.gbPreemExtra.ResumeLayout(false);
            this.gbPreemExtra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.RadioButton rbPickUp;
        private System.Windows.Forms.RadioButton rbDelivery;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbPizza;
        private System.Windows.Forms.Label lblPizzaSize;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.ComboBox cmbSauce;
        private System.Windows.Forms.ComboBox cmbCrust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbBasicExtra;
        private System.Windows.Forms.CheckBox cbMush;
        private System.Windows.Forms.CheckBox cbBacon;
        private System.Windows.Forms.CheckBox cbGPeppers;
        private System.Windows.Forms.CheckBox cbRPeppers;
        private System.Windows.Forms.CheckBox cbAnchov;
        private System.Windows.Forms.CheckBox cbPineapple;
        private System.Windows.Forms.CheckBox cbHam;
        private System.Windows.Forms.CheckBox cbBeef;
        private System.Windows.Forms.CheckBox cbSausage;
        private System.Windows.Forms.CheckBox cbPep;
        private System.Windows.Forms.GroupBox gbPreemExtra;
        private System.Windows.Forms.CheckBox cbGoat;
        private System.Windows.Forms.CheckBox cbFeta;
        private System.Windows.Forms.CheckBox cbMozz;
        private System.Windows.Forms.CheckBox cbHalfMeat;
        private System.Windows.Forms.CheckBox cbEveg;
        private System.Windows.Forms.CheckBox cbEmeat;
        private System.Windows.Forms.CheckBox cbHalfVeg;
        private System.Windows.Forms.CheckBox cbEcrispy;
        private System.Windows.Forms.CheckBox cbEsauce;
        private System.Windows.Forms.CheckBox cbEcheese;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox txtTip;
    }
}

