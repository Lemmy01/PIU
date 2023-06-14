namespace InterfataUtilizator_WindowsForms
{
    partial class MainEmployeePage
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.bsnButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.buttonPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewEmplButton
            // 
            this.viewEmplButton.Location = new System.Drawing.Point(51, 41);
            this.viewEmplButton.Name = "viewEmplButton";
            this.viewEmplButton.Size = new System.Drawing.Size(109, 42);
            this.viewEmplButton.TabIndex = 0;
            this.viewEmplButton.Text = "View Employees";
            this.viewEmplButton.UseVisualStyleBackColor = true;
            this.viewEmplButton.Click += new System.EventHandler(this.viewEmplButton_Click);
            // 
            // AddEmplButton
            // 
            this.AddEmplButton.Location = new System.Drawing.Point(51, 107);
            this.AddEmplButton.Name = "AddEmplButton";
            this.AddEmplButton.Size = new System.Drawing.Size(109, 45);
            this.AddEmplButton.TabIndex = 2;
            this.AddEmplButton.Text = "Add Employee";
            this.AddEmplButton.UseVisualStyleBackColor = true;
            this.AddEmplButton.Click += new System.EventHandler(this.AddEmplButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(51, 179);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(109, 45);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete Employee";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // bsnButton
            // 
            this.bsnButton.Location = new System.Drawing.Point(51, 382);
            this.bsnButton.Name = "bsnButton";
            this.bsnButton.Size = new System.Drawing.Size(109, 47);
            this.bsnButton.TabIndex = 4;
            this.bsnButton.Text = "Bussinesses";
            this.bsnButton.UseVisualStyleBackColor = true;
            this.bsnButton.Click += new System.EventHandler(this.bsnButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(275, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 378);
            this.dataGridView1.TabIndex = 10;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPanel.Controls.Add(this.AddEmplButton);
            this.buttonPanel.Controls.Add(this.viewEmplButton);
            this.buttonPanel.Controls.Add(this.deleteButton);
            this.buttonPanel.Controls.Add(this.bsnButton);
            this.buttonPanel.Location = new System.Drawing.Point(-8, -4);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(211, 483);
            this.buttonPanel.TabIndex = 11;
            this.buttonPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonPanel_Paint);
            // 
            // MainEmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 478);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainEmployeePage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainEmployeePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewEmplButton;
        private System.Windows.Forms.Button AddEmplButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button bsnButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel buttonPanel;
    }
}

