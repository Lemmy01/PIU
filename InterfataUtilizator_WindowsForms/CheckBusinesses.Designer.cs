namespace InterfataUtilizator_WindowsForms
{
    partial class CheckBusinesses
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
            this.listBusinesses = new System.Windows.Forms.ListBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBusinesses
            // 
            this.listBusinesses.FormattingEnabled = true;
            this.listBusinesses.Location = new System.Drawing.Point(27, 54);
            this.listBusinesses.Name = "listBusinesses";
            this.listBusinesses.Size = new System.Drawing.Size(180, 303);
            this.listBusinesses.TabIndex = 0;
            this.listBusinesses.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(61, 374);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(119, 39);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // CheckBusinesses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 425);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.listBusinesses);
            this.Name = "CheckBusinesses";
            this.Text = "CheckBusinesses";
            this.Load += new System.EventHandler(this.CheckBusinesses_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBusinesses;
        private System.Windows.Forms.Button closeButton;
    }
}