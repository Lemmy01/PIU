namespace InterfataUtilizator_WindowsForms
{
    partial class MainBussinessesForm
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
            this.emplButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPanel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.buttonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // emplButton
            // 
            this.emplButton.Location = new System.Drawing.Point(40, 401);
            this.emplButton.Name = "emplButton";
            this.emplButton.Size = new System.Drawing.Size(109, 47);
            this.emplButton.TabIndex = 8;
            this.emplButton.Text = "Employees";
            this.emplButton.UseVisualStyleBackColor = true;
            this.emplButton.Click += new System.EventHandler(this.emplButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(40, 178);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(109, 45);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete Bussiness";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click_1);
            // 
            // addButton
            // 
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addButton.Location = new System.Drawing.Point(40, 106);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(109, 45);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add Bussiness";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(40, 40);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(109, 42);
            this.viewButton.TabIndex = 5;
            this.viewButton.Text = "View Bussiness";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(269, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 378);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonPanel2
            // 
            this.buttonPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPanel2.Controls.Add(this.viewButton);
            this.buttonPanel2.Controls.Add(this.addButton);
            this.buttonPanel2.Controls.Add(this.emplButton);
            this.buttonPanel2.Controls.Add(this.deleteButton);
            this.buttonPanel2.Location = new System.Drawing.Point(-4, 2);
            this.buttonPanel2.Name = "buttonPanel2";
            this.buttonPanel2.Size = new System.Drawing.Size(195, 484);
            this.buttonPanel2.TabIndex = 10;
            // 
            // MainBussinessesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 481);
            this.Controls.Add(this.buttonPanel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainBussinessesForm";
            this.Text = "MainBussinessesForm";
            this.Load += new System.EventHandler(this.MainBussinessesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.buttonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button emplButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel buttonPanel2;
    }
}