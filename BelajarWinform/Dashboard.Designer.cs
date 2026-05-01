namespace BelajarWinform
{
    partial class Dashboard
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
            LabelDashboard = new Label();
            DgUser = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgUser).BeginInit();
            SuspendLayout();
            // 
            // LabelDashboard
            // 
            LabelDashboard.AutoSize = true;
            LabelDashboard.BackColor = Color.Transparent;
            LabelDashboard.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LabelDashboard.ForeColor = Color.White;
            LabelDashboard.Location = new Point(51, 62);
            LabelDashboard.Name = "LabelDashboard";
            LabelDashboard.Size = new Size(287, 48);
            LabelDashboard.TabIndex = 0;
            LabelDashboard.Text = "Selamat Datang";
            // 
            // DgUser
            // 
            DgUser.BackgroundColor = Color.White;
            DgUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgUser.Location = new Point(68, 129);
            DgUser.Name = "DgUser";
            DgUser.RowHeadersWidth = 62;
            DgUser.Size = new Size(929, 403);
            DgUser.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1054, 616);
            Controls.Add(DgUser);
            Controls.Add(LabelDashboard);
            Name = "Dashboard";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)DgUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelDashboard;
        private DataGridView DgUser;
    }
}