namespace InterfataUtilizator_WindowsForms
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
            this.viewEmplButton = new System.Windows.Forms.Button();
            this.AddEmplButton = new System.Windows.Forms.Button();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // viewEmplButton
            // 
            this.viewEmplButton.Location = new System.Drawing.Point(48, 368);
            this.viewEmplButton.Name = "viewEmplButton";
            this.viewEmplButton.Size = new System.Drawing.Size(109, 23);
            this.viewEmplButton.TabIndex = 0;
            this.viewEmplButton.Text = "View Employees";
            this.viewEmplButton.UseVisualStyleBackColor = true;
            this.viewEmplButton.Click += new System.EventHandler(this.viewEmplButton_Click);
            // 
            // AddEmplButton
            // 
            this.AddEmplButton.Location = new System.Drawing.Point(48, 420);
            this.AddEmplButton.Name = "AddEmplButton";
            this.AddEmplButton.Size = new System.Drawing.Size(109, 23);
            this.AddEmplButton.TabIndex = 2;
            this.AddEmplButton.Text = "Add Employees";
            this.AddEmplButton.UseVisualStyleBackColor = true;
            this.AddEmplButton.Click += new System.EventHandler(this.AddEmplButton_Click);
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(135, 82);
            this.txtPrenume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(277, 20);
            this.txtPrenume.TabIndex = 36;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(135, 47);
            this.txtNume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(277, 20);
            this.txtNume.TabIndex = 35;
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(31, 91);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(49, 13);
            this.lblPrenume.TabIndex = 34;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(31, 55);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 33;
            this.lblNume.Text = "Nume";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(197, 190);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 37;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 598);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.AddEmplButton);
            this.Controls.Add(this.viewEmplButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewEmplButton;
        private System.Windows.Forms.Button AddEmplButton;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

