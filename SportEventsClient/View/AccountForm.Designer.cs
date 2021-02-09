
namespace View
{
    partial class AccountForm
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
            this.name_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.shippingAddress_label = new System.Windows.Forms.Label();
            this.bankId_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.shippingAddress_textBox = new System.Windows.Forms.TextBox();
            this.bankId_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edit_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.done_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(83, 172);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(45, 17);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(86, 256);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(42, 17);
            this.email_label.TabIndex = 1;
            this.email_label.Text = "Email";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(591, 167);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(60, 17);
            this.address_label.TabIndex = 2;
            this.address_label.Text = "Address";
            // 
            // shippingAddress_label
            // 
            this.shippingAddress_label.AutoSize = true;
            this.shippingAddress_label.Location = new System.Drawing.Point(591, 224);
            this.shippingAddress_label.Name = "shippingAddress_label";
            this.shippingAddress_label.Size = new System.Drawing.Size(119, 17);
            this.shippingAddress_label.TabIndex = 3;
            this.shippingAddress_label.Text = "Shipping Address";
            // 
            // bankId_label
            // 
            this.bankId_label.AutoSize = true;
            this.bankId_label.Location = new System.Drawing.Point(591, 283);
            this.bankId_label.Name = "bankId_label";
            this.bankId_label.Size = new System.Drawing.Size(55, 17);
            this.bankId_label.TabIndex = 4;
            this.bankId_label.Text = "Bank id";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(156, 172);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.ReadOnly = true;
            this.name_textBox.Size = new System.Drawing.Size(100, 22);
            this.name_textBox.TabIndex = 5;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(156, 256);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.ReadOnly = true;
            this.email_textBox.Size = new System.Drawing.Size(100, 22);
            this.email_textBox.TabIndex = 6;
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(729, 167);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.ReadOnly = true;
            this.address_textBox.Size = new System.Drawing.Size(210, 22);
            this.address_textBox.TabIndex = 7;
            // 
            // shippingAddress_textBox
            // 
            this.shippingAddress_textBox.Location = new System.Drawing.Point(729, 224);
            this.shippingAddress_textBox.Name = "shippingAddress_textBox";
            this.shippingAddress_textBox.ReadOnly = true;
            this.shippingAddress_textBox.Size = new System.Drawing.Size(210, 22);
            this.shippingAddress_textBox.TabIndex = 8;
            // 
            // bankId_textBox
            // 
            this.bankId_textBox.Location = new System.Drawing.Point(729, 283);
            this.bankId_textBox.Name = "bankId_textBox";
            this.bankId_textBox.ReadOnly = true;
            this.bankId_textBox.Size = new System.Drawing.Size(210, 22);
            this.bankId_textBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(587, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 42);
            this.label6.TabIndex = 10;
            this.label6.Text = "Personal Information";
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.edit_button.Location = new System.Drawing.Point(398, 356);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(75, 23);
            this.edit_button.TabIndex = 11;
            this.edit_button.Text = "Edit ✏";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.editButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // done_button
            // 
            this.done_button.ForeColor = System.Drawing.Color.Green;
            this.done_button.Location = new System.Drawing.Point(821, 382);
            this.done_button.Name = "done_button";
            this.done_button.Size = new System.Drawing.Size(108, 35);
            this.done_button.TabIndex = 13;
            this.done_button.Text = "Done ✔";
            this.done_button.UseVisualStyleBackColor = true;
            this.done_button.Visible = false;
            this.done_button.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1008, 444);
            this.Controls.Add(this.done_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bankId_textBox);
            this.Controls.Add(this.shippingAddress_textBox);
            this.Controls.Add(this.address_textBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.bankId_label);
            this.Controls.Add(this.shippingAddress_label);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.name_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label shippingAddress_label;
        private System.Windows.Forms.Label bankId_label;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.TextBox shippingAddress_textBox;
        private System.Windows.Forms.TextBox bankId_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button done_button;
    }
}