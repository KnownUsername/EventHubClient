
namespace View
{
    partial class GeneralForm
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
            this.header_groupBox = new System.Windows.Forms.GroupBox();
            this.teamsButton = new System.Windows.Forms.Button();
            this.accountButton = new System.Windows.Forms.Button();
            this.eventButton = new System.Windows.Forms.Button();
            this.underPanel = new System.Windows.Forms.Panel();
            this.header_groupBox.SuspendLayout();
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
            // header_groupBox
            // 
            this.header_groupBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.header_groupBox.Controls.Add(this.teamsButton);
            this.header_groupBox.Controls.Add(this.accountButton);
            this.header_groupBox.Controls.Add(this.eventButton);
            this.header_groupBox.Controls.Add(this.homeButton);
            this.header_groupBox.Location = new System.Drawing.Point(-1, -12);
            this.header_groupBox.Name = "header_groupBox";
            this.header_groupBox.Size = new System.Drawing.Size(1008, 119);
            this.header_groupBox.TabIndex = 1;
            this.header_groupBox.TabStop = false;
            this.header_groupBox.Text = "groupBox1";
            // 
            // teamsButton
            // 
            this.teamsButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.teamsButton.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.teamsButton.FlatAppearance.BorderSize = 0;
            this.teamsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teamsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamsButton.ForeColor = System.Drawing.SystemColors.Info;
            this.teamsButton.Location = new System.Drawing.Point(504, 11);
            this.teamsButton.Name = "teamsButton";
            this.teamsButton.Size = new System.Drawing.Size(252, 108);
            this.teamsButton.TabIndex = 3;
            this.teamsButton.Text = "Teams";
            this.teamsButton.UseVisualStyleBackColor = false;
            this.teamsButton.Click += new System.EventHandler(this.teamsButton_Click);
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
            // underPanel
            // 
            this.underPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.underPanel.Location = new System.Drawing.Point(-1, 107);
            this.underPanel.Name = "underPanel";
            this.underPanel.Size = new System.Drawing.Size(1008, 447);
            this.underPanel.TabIndex = 3;
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.underPanel);
            this.Controls.Add(this.header_groupBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "GeneralForm";
            this.Text = "EventHub";
            this.header_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.GroupBox header_groupBox;
        private System.Windows.Forms.Button accountButton;
        private System.Windows.Forms.Button eventButton;
        private System.Windows.Forms.Panel underPanel;
        private System.Windows.Forms.Button teamsButton;
    }
}

