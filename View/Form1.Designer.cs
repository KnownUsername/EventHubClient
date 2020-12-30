
namespace View
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
            this.homeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.accountButton = new System.Windows.Forms.Button();
            this.eventButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.homeButton.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.SystemColors.Info;
            this.homeButton.Location = new System.Drawing.Point(0, 11);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(252, 108);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.home_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.aboutButton);
            this.groupBox1.Controls.Add(this.accountButton);
            this.groupBox1.Controls.Add(this.eventButton);
            this.groupBox1.Controls.Add(this.homeButton);
            this.groupBox1.Location = new System.Drawing.Point(-1, -12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // accountButton
            // 
            this.accountButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.accountButton.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.accountButton.FlatAppearance.BorderSize = 0;
            this.accountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountButton.ForeColor = System.Drawing.SystemColors.Info;
            this.accountButton.Location = new System.Drawing.Point(756, 11);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(252, 108);
            this.accountButton.TabIndex = 2;
            this.accountButton.Text = "Account";
            this.accountButton.UseVisualStyleBackColor = false;
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            // 
            // eventButton
            // 
            this.eventButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.eventButton.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.eventButton.FlatAppearance.BorderSize = 0;
            this.eventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventButton.ForeColor = System.Drawing.SystemColors.Info;
            this.eventButton.Location = new System.Drawing.Point(252, 11);
            this.eventButton.Name = "eventButton";
            this.eventButton.Size = new System.Drawing.Size(252, 108);
            this.eventButton.TabIndex = 1;
            this.eventButton.Text = "Events";
            this.eventButton.UseVisualStyleBackColor = false;
            this.eventButton.Click += new System.EventHandler(this.eventButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(-1, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 447);
            this.panel1.TabIndex = 3;
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.aboutButton.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.SystemColors.Info;
            this.aboutButton.Location = new System.Drawing.Point(504, 11);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(252, 108);
            this.aboutButton.TabIndex = 3;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button accountButton;
        private System.Windows.Forms.Button eventButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button aboutButton;
    }
}

