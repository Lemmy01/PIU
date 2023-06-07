namespace InterfataUtilizator_WindowsForms
{
    partial class AddEmployeeForm
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
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblCNP = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.lblBusid = new System.Windows.Forms.Label();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            this.cnpTextBox = new System.Windows.Forms.TextBox();
            this.busIdTextBox = new System.Windows.Forms.TextBox();
            this.mRadButton = new System.Windows.Forms.RadioButton();
            this.fRadButton = new System.Windows.Forms.RadioButton();
            this.manCBox = new System.Windows.Forms.CheckBox();
            this.barCBox = new System.Windows.Forms.CheckBox();
            this.ingCBox = new System.Windows.Forms.CheckBox();
            this.porCBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.chkBussiness = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(66, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nume";
          
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(66, 98);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(49, 13);
            this.lblPrenume.TabIndex = 1;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Location = new System.Drawing.Point(66, 144);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(29, 13);
            this.lblCNP.TabIndex = 2;
            this.lblCNP.Text = "CNP";
         
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(66, 186);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(23, 13);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Rol";
        
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Location = new System.Drawing.Point(66, 227);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(27, 13);
            this.lblGen.TabIndex = 4;
            this.lblGen.Text = "Gen";
       
            // 
            // lblBusid
            // 
            this.lblBusid.AutoSize = true;
            this.lblBusid.Location = new System.Drawing.Point(66, 272);
            this.lblBusid.Name = "lblBusid";
            this.lblBusid.Size = new System.Drawing.Size(58, 13);
            this.lblBusid.TabIndex = 5;
            this.lblBusid.Text = "BusinessId";
            // 
            // numeTextBox
            // 
            this.numeTextBox.Location = new System.Drawing.Point(164, 51);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeTextBox.TabIndex = 6;
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.Location = new System.Drawing.Point(164, 98);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenumeTextBox.TabIndex = 7;
            // 
            // cnpTextBox
            // 
            this.cnpTextBox.Location = new System.Drawing.Point(164, 144);
            this.cnpTextBox.Name = "cnpTextBox";
            this.cnpTextBox.Size = new System.Drawing.Size(100, 20);
            this.cnpTextBox.TabIndex = 8;
            // 
            // busIdTextBox
            // 
            this.busIdTextBox.Location = new System.Drawing.Point(164, 272);
            this.busIdTextBox.Name = "busIdTextBox";
            this.busIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.busIdTextBox.TabIndex = 9;
            // 
            // mRadButton
            // 
            this.mRadButton.AutoSize = true;
            this.mRadButton.Checked = true;
            this.mRadButton.Location = new System.Drawing.Point(164, 227);
            this.mRadButton.Name = "mRadButton";
            this.mRadButton.Size = new System.Drawing.Size(67, 17);
            this.mRadButton.TabIndex = 10;
            this.mRadButton.TabStop = true;
            this.mRadButton.Text = "Masculin";
            this.mRadButton.UseVisualStyleBackColor = true;
            this.mRadButton.CheckedChanged += new System.EventHandler(this.mRadButton_CheckedChanged);
            // 
            // fRadButton
            // 
            this.fRadButton.AutoSize = true;
            this.fRadButton.Location = new System.Drawing.Point(280, 227);
            this.fRadButton.Name = "fRadButton";
            this.fRadButton.Size = new System.Drawing.Size(61, 17);
            this.fRadButton.TabIndex = 11;
            this.fRadButton.Text = "Feminin";
            this.fRadButton.UseVisualStyleBackColor = true;
            // 
            // manCBox
            // 
            this.manCBox.AutoSize = true;
            this.manCBox.Location = new System.Drawing.Point(163, 186);
            this.manCBox.Name = "manCBox";
            this.manCBox.Size = new System.Drawing.Size(68, 17);
            this.manCBox.TabIndex = 12;
            this.manCBox.Text = "Manager";
            this.manCBox.UseVisualStyleBackColor = true;
            this.manCBox.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // barCBox
            // 
            this.barCBox.AutoSize = true;
            this.barCBox.Location = new System.Drawing.Point(273, 186);
            this.barCBox.Name = "barCBox";
            this.barCBox.Size = new System.Drawing.Size(62, 17);
            this.barCBox.TabIndex = 13;
            this.barCBox.Text = "Barman";
            this.barCBox.UseVisualStyleBackColor = true;
            this.barCBox.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // ingCBox
            // 
            this.ingCBox.AutoSize = true;
            this.ingCBox.Location = new System.Drawing.Point(359, 186);
            this.ingCBox.Name = "ingCBox";
            this.ingCBox.Size = new System.Drawing.Size(62, 17);
            this.ingCBox.TabIndex = 14;
            this.ingCBox.Text = "Ingrijitor";
            this.ingCBox.UseVisualStyleBackColor = true;
            this.ingCBox.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // porCBox
            // 
            this.porCBox.AutoSize = true;
            this.porCBox.Location = new System.Drawing.Point(446, 186);
            this.porCBox.Name = "porCBox";
            this.porCBox.Size = new System.Drawing.Size(54, 17);
            this.porCBox.TabIndex = 15;
            this.porCBox.Text = "Portar";
            this.porCBox.UseVisualStyleBackColor = true;
            this.porCBox.CheckedChanged += new System.EventHandler(this.Ckb_CheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveButton.Location = new System.Drawing.Point(154, 338);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 33);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkBussiness
            // 
            this.chkBussiness.Location = new System.Drawing.Point(382, 338);
            this.chkBussiness.Name = "chkBussiness";
            this.chkBussiness.Size = new System.Drawing.Size(118, 33);
            this.chkBussiness.TabIndex = 17;
            this.chkBussiness.Text = "Check Bussinesses";
            this.chkBussiness.UseVisualStyleBackColor = true;
            this.chkBussiness.Click += new System.EventHandler(this.chkBussiness_Click);
            // 
            // MainBussinessesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkBussiness);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.porCBox);
            this.Controls.Add(this.ingCBox);
            this.Controls.Add(this.barCBox);
            this.Controls.Add(this.manCBox);
            this.Controls.Add(this.fRadButton);
            this.Controls.Add(this.mRadButton);
            this.Controls.Add(this.busIdTextBox);
            this.Controls.Add(this.cnpTextBox);
            this.Controls.Add(this.prenumeTextBox);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(this.lblBusid);
            this.Controls.Add(this.lblGen);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblCNP);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblName);
            this.Name = "MainBussinessesForm";
            this.Text = "MainBussinessesForm";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Label lblBusid;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.TextBox cnpTextBox;
        private System.Windows.Forms.TextBox busIdTextBox;
        private System.Windows.Forms.RadioButton mRadButton;
        private System.Windows.Forms.RadioButton fRadButton;
        private System.Windows.Forms.CheckBox manCBox;
        private System.Windows.Forms.CheckBox barCBox;
        private System.Windows.Forms.CheckBox ingCBox;
        private System.Windows.Forms.CheckBox porCBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button chkBussiness;
    }
}