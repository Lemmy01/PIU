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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // viewEmplButton
            // 
            this.viewEmplButton.Location = new System.Drawing.Point(44, 115);
            this.viewEmplButton.Name = "viewEmplButton";
            this.viewEmplButton.Size = new System.Drawing.Size(109, 23);
            this.viewEmplButton.TabIndex = 0;
            this.viewEmplButton.Text = "View Employees";
            this.viewEmplButton.UseVisualStyleBackColor = true;
            this.viewEmplButton.Click += new System.EventHandler(this.viewEmplButton_Click);
            // 
            // AddEmplButton
            // 
            this.AddEmplButton.Location = new System.Drawing.Point(44, 167);
            this.AddEmplButton.Name = "AddEmplButton";
            this.AddEmplButton.Size = new System.Drawing.Size(109, 23);
            this.AddEmplButton.TabIndex = 2;
            this.AddEmplButton.Text = "Add Employees";
            this.AddEmplButton.UseVisualStyleBackColor = true;
            this.AddEmplButton.Click += new System.EventHandler(this.AddEmplButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 598);
            this.Controls.Add(this.AddEmplButton);
            this.Controls.Add(this.viewEmplButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewEmplButton;
        private System.Windows.Forms.Button AddEmplButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

