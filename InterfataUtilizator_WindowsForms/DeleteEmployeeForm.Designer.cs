namespace InterfataUtilizator_WindowsForms
{
    partial class DeleteEmployeeForm
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.lblDelete = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(52, 138);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(141, 38);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(52, 195);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(141, 41);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(74, 41);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(95, 13);
            this.lblDelete.TabIndex = 2;
            this.lblDelete.Text = "Enter Employee ID";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(61, 85);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(118, 20);
            this.idBox.TabIndex = 3;
            // 
            // DeleteEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 285);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Name = "DeleteEmployeeForm";
            this.Text = "DeleteEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.TextBox idBox;
    }
}