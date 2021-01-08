﻿
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teamsButton = new System.Windows.Forms.Button();
            this.accountButton = new System.Windows.Forms.Button();
            this.eventButton = new System.Windows.Forms.Button();
            this.underPanel = new System.Windows.Forms.Panel();
            this.competitivesButton = new System.Windows.Forms.Button();
            this.friendliesButton = new System.Windows.Forms.Button();
            this.Events_dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.underPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Events_dataGridView)).BeginInit();
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
            this.groupBox1.Controls.Add(this.teamsButton);
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
            this.underPanel.Controls.Add(this.competitivesButton);
            this.underPanel.Controls.Add(this.friendliesButton);
            this.underPanel.Controls.Add(this.Events_dataGridView);
            this.underPanel.Location = new System.Drawing.Point(-1, 107);
            this.underPanel.Name = "underPanel";
            this.underPanel.Size = new System.Drawing.Size(1008, 447);
            this.underPanel.TabIndex = 3;
            // 
            // competitivesButton
            // 
            this.competitivesButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.competitivesButton.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.competitivesButton.FlatAppearance.BorderSize = 0;
            this.competitivesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.competitivesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.competitivesButton.ForeColor = System.Drawing.SystemColors.Info;
            this.competitivesButton.Location = new System.Drawing.Point(630, 114);
            this.competitivesButton.Name = "competitivesButton";
            this.competitivesButton.Size = new System.Drawing.Size(252, 108);
            this.competitivesButton.TabIndex = 3;
            this.competitivesButton.Text = "Competitives";
            this.competitivesButton.UseVisualStyleBackColor = false;
            this.competitivesButton.Visible = false;
            this.competitivesButton.Click += new System.EventHandler(this.competitivesButton_Click);
            // 
            // friendliesButton
            // 
            this.friendliesButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.friendliesButton.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.friendliesButton.FlatAppearance.BorderSize = 0;
            this.friendliesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.friendliesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendliesButton.ForeColor = System.Drawing.SystemColors.Info;
            this.friendliesButton.Location = new System.Drawing.Point(126, 114);
            this.friendliesButton.Name = "friendliesButton";
            this.friendliesButton.Size = new System.Drawing.Size(252, 108);
            this.friendliesButton.TabIndex = 2;
            this.friendliesButton.Text = "Friendlies";
            this.friendliesButton.UseVisualStyleBackColor = false;
            this.friendliesButton.Visible = false;
            this.friendliesButton.Click += new System.EventHandler(this.friendlies_Click);
            // 
            // Events_dataGridView
            // 
            this.Events_dataGridView.AllowUserToDeleteRows = false;
            this.Events_dataGridView.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.Events_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Events_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.Events_dataGridView.Name = "Events_dataGridView";
            this.Events_dataGridView.ReadOnly = true;
            this.Events_dataGridView.RowHeadersWidth = 51;
            this.Events_dataGridView.RowTemplate.Height = 24;
            this.Events_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Events_dataGridView.Size = new System.Drawing.Size(1008, 444);
            this.Events_dataGridView.TabIndex = 0;
            this.Events_dataGridView.Visible = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.underPanel);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "HomeForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.underPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Events_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button accountButton;
        private System.Windows.Forms.Button eventButton;
        private System.Windows.Forms.Panel underPanel;
        private System.Windows.Forms.Button teamsButton;
        private System.Windows.Forms.DataGridView Events_dataGridView;
        private System.Windows.Forms.Button friendliesButton;
        private System.Windows.Forms.Button competitivesButton;
    }
}
