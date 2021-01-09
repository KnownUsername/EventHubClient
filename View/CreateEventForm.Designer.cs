
namespace View
{
    partial class CreateEventForm
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
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.description_textBox = new System.Windows.Forms.TextBox();
            this.initialDate_Picker = new System.Windows.Forms.DateTimePicker();
            this.endDate_Picker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.slots_textBox = new System.Windows.Forms.TextBox();
            this.local_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.confirm_button = new System.Windows.Forms.Button();
            this.sport_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.teamMax_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.entryFee_textBox = new System.Windows.Forms.TextBox();
            this.entryFee_label = new System.Windows.Forms.Label();
            this.eventStatus_Picker = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(131, 100);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(100, 22);
            this.name_textBox.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(69, 100);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 17);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Initial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // description_textBox
            // 
            this.description_textBox.Location = new System.Drawing.Point(131, 151);
            this.description_textBox.Multiline = true;
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.Size = new System.Drawing.Size(264, 83);
            this.description_textBox.TabIndex = 4;
            // 
            // initialDate_Picker
            // 
            this.initialDate_Picker.Location = new System.Drawing.Point(131, 275);
            this.initialDate_Picker.Name = "initialDate_Picker";
            this.initialDate_Picker.Size = new System.Drawing.Size(200, 22);
            this.initialDate_Picker.TabIndex = 6;
            // 
            // endDate_Picker
            // 
            this.endDate_Picker.Location = new System.Drawing.Point(131, 326);
            this.endDate_Picker.Name = "endDate_Picker";
            this.endDate_Picker.Size = new System.Drawing.Size(200, 22);
            this.endDate_Picker.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "End";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Slots";
            // 
            // slots_textBox
            // 
            this.slots_textBox.Location = new System.Drawing.Point(677, 109);
            this.slots_textBox.Name = "slots_textBox";
            this.slots_textBox.Size = new System.Drawing.Size(100, 22);
            this.slots_textBox.TabIndex = 10;
            // 
            // local_textBox
            // 
            this.local_textBox.Location = new System.Drawing.Point(677, 148);
            this.local_textBox.Name = "local_textBox";
            this.local_textBox.Size = new System.Drawing.Size(100, 22);
            this.local_textBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(619, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Local";
            // 
            // confirm_button
            // 
            this.confirm_button.Location = new System.Drawing.Point(850, 349);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(136, 67);
            this.confirm_button.TabIndex = 13;
            this.confirm_button.Text = "Confirm";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // sport_textBox
            // 
            this.sport_textBox.Location = new System.Drawing.Point(677, 188);
            this.sport_textBox.Name = "sport_textBox";
            this.sport_textBox.Size = new System.Drawing.Size(100, 22);
            this.sport_textBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(619, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sport";
            // 
            // teamMax_textBox
            // 
            this.teamMax_textBox.Location = new System.Drawing.Point(677, 232);
            this.teamMax_textBox.Name = "teamMax_textBox";
            this.teamMax_textBox.Size = new System.Drawing.Size(100, 22);
            this.teamMax_textBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(541, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Max team members";
            // 
            // entryFee_textBox
            // 
            this.entryFee_textBox.Location = new System.Drawing.Point(677, 314);
            this.entryFee_textBox.Name = "entryFee_textBox";
            this.entryFee_textBox.Size = new System.Drawing.Size(100, 22);
            this.entryFee_textBox.TabIndex = 19;
            this.entryFee_textBox.Visible = false;
            // 
            // entryFee_label
            // 
            this.entryFee_label.AutoSize = true;
            this.entryFee_label.Location = new System.Drawing.Point(592, 319);
            this.entryFee_label.Name = "entryFee_label";
            this.entryFee_label.Size = new System.Drawing.Size(69, 17);
            this.entryFee_label.TabIndex = 18;
            this.entryFee_label.Text = "Entry Fee";
            this.entryFee_label.Visible = false;
            // 
            // eventStatus_Picker
            // 
            this.eventStatus_Picker.FormattingEnabled = true;
            this.eventStatus_Picker.Location = new System.Drawing.Point(656, 272);
            this.eventStatus_Picker.Name = "eventStatus_Picker";
            this.eventStatus_Picker.Size = new System.Drawing.Size(121, 24);
            this.eventStatus_Picker.TabIndex = 20;
            this.eventStatus_Picker.SelectedIndexChanged += new System.EventHandler(this.eventStatusPicker_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(598, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Status";
            // 
            // CreateEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1008, 444);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.eventStatus_Picker);
            this.Controls.Add(this.entryFee_textBox);
            this.Controls.Add(this.entryFee_label);
            this.Controls.Add(this.teamMax_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sport_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.local_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.slots_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.endDate_Picker);
            this.Controls.Add(this.initialDate_Picker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.description_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.name_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 492);
            this.Name = "CreateEventForm";
            this.Text = "JoinEventForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox description_textBox;
        private System.Windows.Forms.DateTimePicker initialDate_Picker;
        private System.Windows.Forms.DateTimePicker endDate_Picker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox slots_textBox;
        private System.Windows.Forms.TextBox local_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.TextBox sport_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox teamMax_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox entryFee_textBox;
        private System.Windows.Forms.Label entryFee_label;
        private System.Windows.Forms.ComboBox eventStatus_Picker;
        private System.Windows.Forms.Label label9;
    }
}