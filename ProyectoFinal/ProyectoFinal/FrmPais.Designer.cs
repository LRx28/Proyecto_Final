namespace ProyectoFinal
{
    partial class FrmPais
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnAgregarPais = new Button();
            label1 = new Label();
            txt_Pais = new TextBox();
            groupBox2 = new GroupBox();
            btnEliminarPais = new Button();
            label2 = new Label();
            txtEliminarPais = new TextBox();
            groupBox3 = new GroupBox();
            label4 = new Label();
            txtActualizarIDP = new TextBox();
            btnActualizarP = new Button();
            label3 = new Label();
            txtNombreActualizarP = new TextBox();
            groupBox4 = new GroupBox();
            dgv_Pais = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            groupBox5 = new GroupBox();
            btn_Csv = new Button();
            btn_Pdf = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Pais).BeginInit();
            panel1.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregarPais);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_Pais);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 177);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(405, 201);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insert";
            // 
            // btnAgregarPais
            // 
            btnAgregarPais.BackColor = Color.DarkGreen;
            btnAgregarPais.ForeColor = Color.White;
            btnAgregarPais.Location = new Point(109, 111);
            btnAgregarPais.Name = "btnAgregarPais";
            btnAgregarPais.Size = new Size(144, 57);
            btnAgregarPais.TabIndex = 2;
            btnAgregarPais.Text = "Agregar";
            btnAgregarPais.UseVisualStyleBackColor = false;
            btnAgregarPais.Click += btnAgregarPais_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 42);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 1;
            label1.Text = "Nombre Pais:";
            // 
            // txt_Pais
            // 
            txt_Pais.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Pais.Location = new Point(148, 41);
            txt_Pais.Name = "txt_Pais";
            txt_Pais.Size = new Size(231, 30);
            txt_Pais.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEliminarPais);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtEliminarPais);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(478, 177);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 201);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Delete";
            // 
            // btnEliminarPais
            // 
            btnEliminarPais.BackColor = Color.DarkGreen;
            btnEliminarPais.ForeColor = Color.White;
            btnEliminarPais.Location = new Point(90, 111);
            btnEliminarPais.Name = "btnEliminarPais";
            btnEliminarPais.Size = new Size(144, 57);
            btnEliminarPais.TabIndex = 2;
            btnEliminarPais.Text = "Eliminar";
            btnEliminarPais.UseVisualStyleBackColor = false;
            btnEliminarPais.Click += btnEliminarPais_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 42);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 1;
            label2.Text = "ID Pais:";
            // 
            // txtEliminarPais
            // 
            txtEliminarPais.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEliminarPais.Location = new Point(90, 42);
            txtEliminarPais.Name = "txtEliminarPais";
            txtEliminarPais.Size = new Size(204, 30);
            txtEliminarPais.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtActualizarIDP);
            groupBox3.Controls.Add(btnActualizarP);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtNombreActualizarP);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(866, 177);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(414, 201);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Update";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 34);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 4;
            label4.Text = "ID Pais:";
            // 
            // txtActualizarIDP
            // 
            txtActualizarIDP.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtActualizarIDP.Location = new Point(104, 34);
            txtActualizarIDP.Name = "txtActualizarIDP";
            txtActualizarIDP.Size = new Size(204, 30);
            txtActualizarIDP.TabIndex = 3;
            // 
            // btnActualizarP
            // 
            btnActualizarP.BackColor = Color.DarkGreen;
            btnActualizarP.ForeColor = Color.White;
            btnActualizarP.Location = new Point(134, 138);
            btnActualizarP.Name = "btnActualizarP";
            btnActualizarP.Size = new Size(144, 57);
            btnActualizarP.TabIndex = 2;
            btnActualizarP.Text = "Actualizar";
            btnActualizarP.UseVisualStyleBackColor = false;
            btnActualizarP.Click += btnActualizarP_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 93);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 1;
            label3.Text = "Nombre Pais:";
            // 
            // txtNombreActualizarP
            // 
            txtNombreActualizarP.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreActualizarP.Location = new Point(152, 90);
            txtNombreActualizarP.Name = "txtNombreActualizarP";
            txtNombreActualizarP.Size = new Size(236, 30);
            txtNombreActualizarP.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgv_Pais);
            groupBox4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.Black;
            groupBox4.Location = new Point(12, 414);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1277, 325);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Select";
            // 
            // dgv_Pais
            // 
            dgv_Pais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Pais.Location = new Point(106, 19);
            dgv_Pais.Name = "dgv_Pais";
            dgv_Pais.RowHeadersWidth = 51;
            dgv_Pais.Size = new Size(1058, 298);
            dgv_Pais.TabIndex = 0;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(464, 9);
            label5.Name = "label5";
            label5.Size = new Size(444, 92);
            label5.TabIndex = 0;
            label5.Text = "Agencia de Tours";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(27, 5);
            label6.Name = "label6";
            label6.Size = new Size(384, 28);
            label6.TabIndex = 4;
            label6.Text = "<= Opciones para gestionar un pais =>";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(432, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 43);
            panel1.TabIndex = 5;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btn_Csv);
            groupBox5.Controls.Add(btn_Pdf);
            groupBox5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(927, 9);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(296, 109);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Exportar";
            // 
            // btn_Csv
            // 
            btn_Csv.BackColor = Color.DarkGreen;
            btn_Csv.ForeColor = Color.White;
            btn_Csv.Location = new Point(35, 29);
            btn_Csv.Name = "btn_Csv";
            btn_Csv.Size = new Size(105, 45);
            btn_Csv.TabIndex = 3;
            btn_Csv.Text = ".CSV";
            btn_Csv.UseVisualStyleBackColor = false;
            btn_Csv.Click += btn_Csv_Click;
            // 
            // btn_Pdf
            // 
            btn_Pdf.BackColor = Color.DarkGreen;
            btn_Pdf.ForeColor = Color.White;
            btn_Pdf.Location = new Point(175, 29);
            btn_Pdf.Name = "btn_Pdf";
            btn_Pdf.Size = new Size(105, 45);
            btn_Pdf.TabIndex = 2;
            btn_Pdf.Text = "PDF";
            btn_Pdf.UseVisualStyleBackColor = false;
            btn_Pdf.Click += btn_Pdf_Click;
            // 
            // FrmPais
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1292, 743);
            Controls.Add(groupBox5);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmPais";
            Text = "Pais";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Pais).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txt_Pais;
        private Button btnAgregarPais;
        private GroupBox groupBox2;
        private Button btnEliminarPais;
        private Label label2;
        private TextBox txtEliminarPais;
        private GroupBox groupBox3;
        private Button btnActualizarP;
        private Label label3;
        private TextBox txtNombreActualizarP;
        private Label label4;
        private TextBox txtActualizarIDP;
        private GroupBox groupBox4;
        private DataGridView dgv_Pais;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private GroupBox groupBox5;
        private Button btn_Csv;
        private Button btn_Pdf;
    }
}
