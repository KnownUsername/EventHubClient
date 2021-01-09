
namespace View
{
    partial class EventsForm
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
            this.friendliesButton = new System.Windows.Forms.Button();
            this.competitivesButton = new System.Windows.Forms.Button();
            this.events_dataGridView = new System.Windows.Forms.DataGridView();
            this.addEvent_Button = new System.Windows.Forms.Button();
            this.addEvent_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.events_dataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.friendliesButton.TabIndex = 3;
            this.friendliesButton.Text = "Friendlies";
            this.friendliesButton.UseVisualStyleBackColor = false;
            this.friendliesButton.Click += new System.EventHandler(this.friendliesButton_Click);
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
            this.competitivesButton.TabIndex = 4;
            this.competitivesButton.Text = "Competitives";
            this.competitivesButton.UseVisualStyleBackColor = false;
            this.competitivesButton.Click += new System.EventHandler(this.competitivesButton_Click);
            // 
            // events_dataGridView
            // 
            this.events_dataGridView.AllowUserToDeleteRows = false;
            this.events_dataGridView.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.events_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.events_dataGridView.Location = new System.Drawing.Point(0, 172);
            this.events_dataGridView.Name = "events_dataGridView";
            this.events_dataGridView.ReadOnly = true;
            this.events_dataGridView.RowHeadersWidth = 51;
            this.events_dataGridView.RowTemplate.Height = 24;
            this.events_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.events_dataGridView.Size = new System.Drawing.Size(1008, 272);
            this.events_dataGridView.TabIndex = 5;
            this.events_dataGridView.Visible = false;
            // 
            // addEvent_Button
            // 
            this.addEvent_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvent_Button.ForeColor = System.Drawing.Color.ForestGreen;
            this.addEvent_Button.Location = new System.Drawing.Point(102, 58);
            this.addEvent_Button.Name = "addEvent_Button";
            this.addEvent_Button.Size = new System.Drawing.Size(181, 76);
            this.addEvent_Button.TabIndex = 6;
            this.addEvent_Button.Text = "+";
            this.addEvent_Button.UseVisualStyleBackColor = true;
            this.addEvent_Button.Visible = false;
            this.addEvent_Button.Click += new System.EventHandler(this.addEvent_Button_Click);
            // 
            // addEvent_Label
            // 
            this.addEvent_Label.AutoSize = true;
            this.addEvent_Label.Location = new System.Drawing.Point(109, 137);
            this.addEvent_Label.Name = "addEvent_Label";
            this.addEvent_Label.Size = new System.Drawing.Size(127, 17);
            this.addEvent_Label.TabIndex = 7;
            this.addEvent_Label.Text = "Add Friendly Event";
            this.addEvent_Label.Visible = false;
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1008, 444);
            this.Controls.Add(this.addEvent_Label);
            this.Controls.Add(this.addEvent_Button);
            this.Controls.Add(this.events_dataGridView);
            this.Controls.Add(this.competitivesButton);
            this.Controls.Add(this.friendliesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventsForm";
            this.Text = "EventsForm";
            ((System.ComponentModel.ISupportInitialize)(this.events_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button friendliesButton;
        private System.Windows.Forms.Button competitivesButton;
        private System.Windows.Forms.DataGridView events_dataGridView;
        private System.Windows.Forms.Button addEvent_Button;
        private System.Windows.Forms.Label addEvent_Label;
    }
}