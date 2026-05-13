namespace praktikum_winform
{
    partial class FormTambahorEdit
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            tb_NamaForm = new TextBox();
            tb_AsalForm = new TextBox();
            tb_UmurForm = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            bt_Simpan = new Button();
            bt_Batal = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tb_NamaForm
            // 
            tb_NamaForm.Location = new Point(48, 166);
            tb_NamaForm.Name = "tb_NamaForm";
            tb_NamaForm.Size = new Size(465, 31);
            tb_NamaForm.TabIndex = 0;
            // 
            // tb_AsalForm
            // 
            tb_AsalForm.Location = new Point(48, 243);
            tb_AsalForm.Name = "tb_AsalForm";
            tb_AsalForm.Size = new Size(465, 31);
            tb_AsalForm.TabIndex = 1;
            // 
            // tb_UmurForm
            // 
            tb_UmurForm.Location = new Point(48, 320);
            tb_UmurForm.Name = "tb_UmurForm";
            tb_UmurForm.Size = new Size(465, 31);
            tb_UmurForm.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 49);
            label1.Name = "label1";
            label1.Size = new Size(330, 44);
            label1.TabIndex = 3;
            label1.Text = "Data Mahasiswa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 215);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 4;
            label2.Text = "Asal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 138);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 5;
            label3.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 292);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 6;
            label4.Text = "Umur";
            // 
            // bt_Simpan
            // 
            bt_Simpan.Location = new Point(655, 390);
            bt_Simpan.Name = "bt_Simpan";
            bt_Simpan.Size = new Size(112, 34);
            bt_Simpan.TabIndex = 7;
            bt_Simpan.Text = "Simpan";
            bt_Simpan.UseVisualStyleBackColor = true;
            bt_Simpan.Click += bt_Simpan_Click;
            // 
            // bt_Batal
            // 
            bt_Batal.Location = new Point(525, 390);
            bt_Batal.Name = "bt_Batal";
            bt_Batal.Size = new Size(112, 34);
            bt_Batal.TabIndex = 8;
            bt_Batal.Text = "Batal";
            bt_Batal.UseVisualStyleBackColor = true;
            bt_Batal.Click += bt_Batal_Click;
            // 
            // FormTambahorEdit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_Batal);
            Controls.Add(bt_Simpan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_UmurForm);
            Controls.Add(tb_AsalForm);
            Controls.Add(tb_NamaForm);
            Name = "FormTambahorEdit";
            Text = "FormTambahorEdit";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private TextBox tb_NamaForm;
        private TextBox tb_AsalForm;
        private TextBox tb_UmurForm;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button bt_Simpan;
        private Button bt_Batal;
    }
}