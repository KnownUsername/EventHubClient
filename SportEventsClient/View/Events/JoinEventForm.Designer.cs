
namespace View
{
    partial class JoinEventForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.addMember_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addMember_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(628, 154);
            this.label2.TabIndex = 0;
            this.label2.Text = "Join Event";
            // 
            // addMember_textBox
            // 
            this.addMember_textBox.Location = new System.Drawing.Point(162, 174);
            this.addMember_textBox.Name = "addMember_textBox";
            this.addMember_textBox.Size = new System.Drawing.Size(311, 22);
            this.addMember_textBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Add member";
            // 
            // addMember_button
            // 
            this.addMember_button.Location = new System.Drawing.Point(398, 234);
            this.addMember_button.Name = "addMember_button";
            this.addMember_button.Size = new System.Drawing.Size(75, 23);
            this.addMember_button.TabIndex = 4;
            this.addMember_button.Text = "Add";
            this.addMember_button.UseVisualStyleBackColor = true;
            this.addMember_button.Click += new System.EventHandler(this.addMember_button_Click);
            // 
            // JoinEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1008, 444);
            this.Controls.Add(this.addMember_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addMember_textBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JoinEventForm";
            this.Text = "JoinEventForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addMember_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addMember_button;
    }
}