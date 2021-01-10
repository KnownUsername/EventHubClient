
namespace View
{
    partial class TeamsForm
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
            this.userTeams_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userTeams_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userTeams_dataGridView
            // 
            this.userTeams_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTeams_dataGridView.Location = new System.Drawing.Point(0, 221);
            this.userTeams_dataGridView.Name = "userTeams_dataGridView";
            this.userTeams_dataGridView.RowHeadersWidth = 51;
            this.userTeams_dataGridView.RowTemplate.Height = 24;
            this.userTeams_dataGridView.Size = new System.Drawing.Size(1008, 224);
            this.userTeams_dataGridView.TabIndex = 0;
            // 
            // TeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1008, 444);
            this.Controls.Add(this.userTeams_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeamsForm";
            this.Text = "TeamsForms";
            ((System.ComponentModel.ISupportInitialize)(this.userTeams_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userTeams_dataGridView;
    }
}