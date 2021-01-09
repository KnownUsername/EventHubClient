
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
            this.Events_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Events_dataGridView)).BeginInit();
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
            // Events_dataGridView
            // 
            this.Events_dataGridView.AllowUserToDeleteRows = false;
            this.Events_dataGridView.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.Events_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Events_dataGridView.Location = new System.Drawing.Point(0, 172);
            this.Events_dataGridView.Name = "Events_dataGridView";
            this.Events_dataGridView.ReadOnly = true;
            this.Events_dataGridView.RowHeadersWidth = 51;
            this.Events_dataGridView.RowTemplate.Height = 24;
            this.Events_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Events_dataGridView.Size = new System.Drawing.Size(1008, 272);
            this.Events_dataGridView.TabIndex = 5;
            this.Events_dataGridView.Visible = false;
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1008, 444);
            this.Controls.Add(this.Events_dataGridView);
            this.Controls.Add(this.competitivesButton);
            this.Controls.Add(this.friendliesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventsForm";
            this.Text = "EventsForm";
            ((System.ComponentModel.ISupportInitialize)(this.Events_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button friendliesButton;
        private System.Windows.Forms.Button competitivesButton;
        private System.Windows.Forms.DataGridView Events_dataGridView;
    }
}