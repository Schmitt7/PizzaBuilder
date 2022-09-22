
namespace PizzaBuilder
{
    partial class frmConfirm
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblConfirm2 = new System.Windows.Forms.Label();
            this.rtbConfirm = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(340, 385);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(109, 53);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblConfirm2
            // 
            this.lblConfirm2.AutoSize = true;
            this.lblConfirm2.Location = new System.Drawing.Point(575, 121);
            this.lblConfirm2.Name = "lblConfirm2";
            this.lblConfirm2.Size = new System.Drawing.Size(0, 25);
            this.lblConfirm2.TabIndex = 2;
            // 
            // rtbConfirm
            // 
            this.rtbConfirm.Location = new System.Drawing.Point(24, 12);
            this.rtbConfirm.Name = "rtbConfirm";
            this.rtbConfirm.ReadOnly = true;
            this.rtbConfirm.Size = new System.Drawing.Size(764, 324);
            this.rtbConfirm.TabIndex = 3;
            this.rtbConfirm.Text = "";
            // 
            // frmConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbConfirm);
            this.Controls.Add(this.lblConfirm2);
            this.Controls.Add(this.btnConfirm);
            this.Name = "frmConfirm";
            this.Text = "Confirm";
            this.Load += new System.EventHandler(this.frmConfirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        internal System.Windows.Forms.Label lblConfirm2;
        private System.Windows.Forms.RichTextBox rtbConfirm;
    }
}