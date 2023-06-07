namespace InterfataUtilizator_WindowsForms
{
    partial class AddBussinessForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.nameTxT = new System.Windows.Forms.TextBox();
            this.adressTxT = new System.Windows.Forms.TextBox();
            this.cityTxT = new System.Windows.Forms.TextBox();
            this.phoneTxT = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(61, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(61, 126);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(39, 13);
            this.lblAdress.TabIndex = 1;
            this.lblAdress.Text = "Adress";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(61, 180);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(59, 13);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City Adress";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(61, 230);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 13);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone Number";
            // 
            // nameTxT
            // 
            this.nameTxT.Location = new System.Drawing.Point(156, 74);
            this.nameTxT.Name = "nameTxT";
            this.nameTxT.Size = new System.Drawing.Size(100, 20);
            this.nameTxT.TabIndex = 4;
            // 
            // adressTxT
            // 
            this.adressTxT.Location = new System.Drawing.Point(156, 126);
            this.adressTxT.Name = "adressTxT";
            this.adressTxT.Size = new System.Drawing.Size(100, 20);
            this.adressTxT.TabIndex = 5;
            // 
            // cityTxT
            // 
            this.cityTxT.Location = new System.Drawing.Point(156, 172);
            this.cityTxT.Name = "cityTxT";
            this.cityTxT.Size = new System.Drawing.Size(100, 20);
            this.cityTxT.TabIndex = 6;
            // 
            // phoneTxT
            // 
            this.phoneTxT.Location = new System.Drawing.Point(156, 222);
            this.phoneTxT.Name = "phoneTxT";
            this.phoneTxT.Size = new System.Drawing.Size(100, 20);
            this.phoneTxT.TabIndex = 7;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(91, 334);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(129, 43);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // AddBussinessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.phoneTxT);
            this.Controls.Add(this.cityTxT);
            this.Controls.Add(this.adressTxT);
            this.Controls.Add(this.nameTxT);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblName);
            this.Name = "AddBussinessForm";
            this.Text = "AddBussinessForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox nameTxT;
        private System.Windows.Forms.TextBox adressTxT;
        private System.Windows.Forms.TextBox cityTxT;
        private System.Windows.Forms.TextBox phoneTxT;
        private System.Windows.Forms.Button addBtn;
    }
}