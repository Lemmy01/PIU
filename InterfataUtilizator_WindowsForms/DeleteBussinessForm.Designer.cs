namespace InterfataUtilizator_WindowsForms
{
    partial class DeleteBussinessForm
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(56, 153);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(133, 47);
            this.deleteBtn.TabIndex = 0;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(56, 235);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(133, 51);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Bussiness Id";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(64, 88);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(113, 20);
            this.idBox.TabIndex = 3;
            // 
            // DeleteBussinessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 325);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.deleteBtn);
            this.Name = "DeleteBussinessForm";
            this.Text = "DeleteBussinessForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idBox;
    }
}