
namespace View
{
    partial class LocationForm
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
            this.maps_webBrowser = new System.Windows.Forms.WebBrowser();
            this.return_button = new System.Windows.Forms.Button();
            this.eventName_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maps_webBrowser
            // 
            this.maps_webBrowser.Dock = System.Windows.Forms.DockStyle.Right;
            this.maps_webBrowser.Location = new System.Drawing.Point(154, 0);
            this.maps_webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.maps_webBrowser.Name = "maps_webBrowser";
            this.maps_webBrowser.Size = new System.Drawing.Size(854, 444);
            this.maps_webBrowser.TabIndex = 0;
            // 
            // return_button
            // 
            this.return_button.Location = new System.Drawing.Point(34, 350);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(75, 23);
            this.return_button.TabIndex = 1;
            this.return_button.Text = "Back";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // eventName_label
            // 
            this.eventName_label.AutoSize = true;
            this.eventName_label.Location = new System.Drawing.Point(25, 40);
            this.eventName_label.Name = "eventName_label";
            this.eventName_label.Size = new System.Drawing.Size(0, 17);
            this.eventName_label.TabIndex = 2;
            // 
            // LocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1008, 444);
            this.Controls.Add(this.eventName_label);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.maps_webBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LocationForm";
            this.Text = "LocationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser maps_webBrowser;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Label eventName_label;
    }
}