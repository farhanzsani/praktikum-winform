namespace praktikum_winform
{
    partial class FormDashboard
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
            lb_SelamatDatang = new Label();
            dg_DataDashboard = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dg_DataDashboard).BeginInit();
            SuspendLayout();
            // 
            // lb_SelamatDatang
            // 
            lb_SelamatDatang.AutoSize = true;
            lb_SelamatDatang.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_SelamatDatang.Location = new Point(60, 70);
            lb_SelamatDatang.Name = "lb_SelamatDatang";
            lb_SelamatDatang.Size = new Size(327, 44);
            lb_SelamatDatang.TabIndex = 0;
            lb_SelamatDatang.Text = "Selamat Datang ";
            // 
            // dg_DataDashboard
            // 
            dg_DataDashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_DataDashboard.Location = new Point(60, 170);
            dg_DataDashboard.Name = "dg_DataDashboard";
            dg_DataDashboard.RowHeadersWidth = 62;
            dg_DataDashboard.Size = new Size(1008, 530);
            dg_DataDashboard.TabIndex = 1;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(dg_DataDashboard);
            Controls.Add(lb_SelamatDatang);
            Name = "FormDashboard";
            Text = "FormDashboard";
            ((System.ComponentModel.ISupportInitialize)dg_DataDashboard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_SelamatDatang;
        private DataGridView dg_DataDashboard;
    }
}