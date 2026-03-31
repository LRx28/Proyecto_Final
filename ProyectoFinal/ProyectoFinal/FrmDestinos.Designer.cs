namespace ProyectoFinal
{
    partial class FrmDestinos
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
            groupBox1 = new GroupBox();
            label11 = new Label();
            cmbDestinosP = new ComboBox();
            btnAgregarDestino = new Button();
            label2 = new Label();
            txtDestinoDuracionD = new TextBox();
            label1 = new Label();
            txtDestinoNombre = new TextBox();
            groupBox2 = new GroupBox();
            btnDestinoE = new Button();
            label4 = new Label();
            txtDestinoE = new TextBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            cmbActualizarDestino = new ComboBox();
            label8 = new Label();
            txtActualizarDuracionD = new TextBox();
            label5 = new Label();
            txtActualizarDestinoId = new TextBox();
            btnActualizarDestino = new Button();
            label6 = new Label();
            txtNombreActualizarD = new TextBox();
            panel1 = new Panel();
            label9 = new Label();
            label10 = new Label();
            groupBox4 = new GroupBox();
            dgv_Destinos = new DataGridView();
            groupBox5 = new GroupBox();
            btn_CsvDestino = new Button();
            btn_PdfDestino = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Destinos).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(cmbDestinosP);
            groupBox1.Controls.Add(btnAgregarDestino);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDestinoDuracionD);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDestinoNombre);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(26, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 238);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insert";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(11, 29);
            label11.Name = "label11";
            label11.Size = new Size(116, 23);
            label11.TabIndex = 8;
            label11.Text = "Elige un pais:";
            // 
            // cmbDestinosP
            // 
            cmbDestinosP.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbDestinosP.FormattingEnabled = true;
            cmbDestinosP.Location = new Point(132, 28);
            cmbDestinosP.Name = "cmbDestinosP";
            cmbDestinosP.Size = new Size(252, 31);
            cmbDestinosP.TabIndex = 7;
            cmbDestinosP.Text = "            -- Seleciona --";
            // 
            // btnAgregarDestino
            // 
            btnAgregarDestino.BackColor = Color.DarkGreen;
            btnAgregarDestino.ForeColor = Color.White;
            btnAgregarDestino.Location = new Point(177, 167);
            btnAgregarDestino.Name = "btnAgregarDestino";
            btnAgregarDestino.Size = new Size(144, 57);
            btnAgregarDestino.TabIndex = 2;
            btnAgregarDestino.Text = "Agregar";
            btnAgregarDestino.UseVisualStyleBackColor = false;
            btnAgregarDestino.Click += btnAgregarDestino_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 118);
            label2.Name = "label2";
            label2.Size = new Size(126, 23);
            label2.TabIndex = 4;
            label2.Text = "Duracion Dias:";
            // 
            // txtDestinoDuracionD
            // 
            txtDestinoDuracionD.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDestinoDuracionD.Location = new Point(147, 118);
            txtDestinoDuracionD.Name = "txtDestinoDuracionD";
            txtDestinoDuracionD.Size = new Size(107, 30);
            txtDestinoDuracionD.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 72);
            label1.Name = "label1";
            label1.Size = new Size(147, 23);
            label1.TabIndex = 1;
            label1.Text = "Nombre Destino:";
            // 
            // txtDestinoNombre
            // 
            txtDestinoNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDestinoNombre.Location = new Point(166, 71);
            txtDestinoNombre.Name = "txtDestinoNombre";
            txtDestinoNombre.Size = new Size(268, 30);
            txtDestinoNombre.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDestinoE);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtDestinoE);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(523, 176);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(277, 173);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Delete";
            // 
            // btnDestinoE
            // 
            btnDestinoE.BackColor = Color.DarkGreen;
            btnDestinoE.ForeColor = Color.White;
            btnDestinoE.Location = new Point(92, 106);
            btnDestinoE.Name = "btnDestinoE";
            btnDestinoE.Size = new Size(144, 57);
            btnDestinoE.TabIndex = 2;
            btnDestinoE.Text = "Eliminar";
            btnDestinoE.UseVisualStyleBackColor = false;
            btnDestinoE.Click += btnDestinoE_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 42);
            label4.Name = "label4";
            label4.Size = new Size(99, 23);
            label4.TabIndex = 1;
            label4.Text = "ID Destino:";
            // 
            // txtDestinoE
            // 
            txtDestinoE.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDestinoE.Location = new Point(120, 39);
            txtDestinoE.Name = "txtDestinoE";
            txtDestinoE.Size = new Size(116, 30);
            txtDestinoE.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(cmbActualizarDestino);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtActualizarDuracionD);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtActualizarDestinoId);
            groupBox3.Controls.Add(btnActualizarDestino);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtNombreActualizarD);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(836, 151);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(589, 238);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Update";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(28, 84);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 10;
            label3.Text = "Elige un pais:";
            // 
            // cmbActualizarDestino
            // 
            cmbActualizarDestino.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbActualizarDestino.FormattingEnabled = true;
            cmbActualizarDestino.Location = new Point(150, 81);
            cmbActualizarDestino.Name = "cmbActualizarDestino";
            cmbActualizarDestino.Size = new Size(252, 31);
            cmbActualizarDestino.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(19, 184);
            label8.Name = "label8";
            label8.Size = new Size(126, 23);
            label8.TabIndex = 8;
            label8.Text = "Duracion Dias:";
            // 
            // txtActualizarDuracionD
            // 
            txtActualizarDuracionD.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtActualizarDuracionD.Location = new Point(150, 181);
            txtActualizarDuracionD.Name = "txtActualizarDuracionD";
            txtActualizarDuracionD.Size = new Size(83, 30);
            txtActualizarDuracionD.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(27, 35);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 4;
            label5.Text = "ID Destino:";
            // 
            // txtActualizarDestinoId
            // 
            txtActualizarDestinoId.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtActualizarDestinoId.Location = new Point(132, 34);
            txtActualizarDestinoId.Name = "txtActualizarDestinoId";
            txtActualizarDestinoId.Size = new Size(204, 30);
            txtActualizarDestinoId.TabIndex = 3;
            // 
            // btnActualizarDestino
            // 
            btnActualizarDestino.BackColor = Color.DarkGreen;
            btnActualizarDestino.ForeColor = Color.White;
            btnActualizarDestino.Location = new Point(434, 91);
            btnActualizarDestino.Name = "btnActualizarDestino";
            btnActualizarDestino.Size = new Size(144, 57);
            btnActualizarDestino.TabIndex = 2;
            btnActualizarDestino.Text = "Actualizar";
            btnActualizarDestino.UseVisualStyleBackColor = false;
            btnActualizarDestino.Click += btnActualizarDestino_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(19, 131);
            label6.Name = "label6";
            label6.Size = new Size(147, 23);
            label6.TabIndex = 1;
            label6.Text = "Nombre Destino:";
            // 
            // txtNombreActualizarD
            // 
            txtNombreActualizarD.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreActualizarD.Location = new Point(176, 129);
            txtNombreActualizarD.Name = "txtNombreActualizarD";
            txtNombreActualizarD.Size = new Size(233, 30);
            txtNombreActualizarD.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(label9);
            panel1.Location = new Point(447, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 43);
            panel1.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(23, 6);
            label9.Name = "label9";
            label9.Size = new Size(392, 28);
            label9.TabIndex = 4;
            label9.Text = "<= Opciones para gestionar Destinos=>";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(479, 0);
            label10.Name = "label10";
            label10.Size = new Size(444, 92);
            label10.TabIndex = 6;
            label10.Text = "Agencia de Tours";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgv_Destinos);
            groupBox4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.Black;
            groupBox4.Location = new Point(70, 395);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1275, 335);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Select";
            // 
            // dgv_Destinos
            // 
            dgv_Destinos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Destinos.Location = new Point(44, 29);
            dgv_Destinos.Name = "dgv_Destinos";
            dgv_Destinos.RowHeadersWidth = 51;
            dgv_Destinos.Size = new Size(1183, 298);
            dgv_Destinos.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btn_CsvDestino);
            groupBox5.Controls.Add(btn_PdfDestino);
            groupBox5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(1056, 20);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(296, 85);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Exportar";
            // 
            // btn_CsvDestino
            // 
            btn_CsvDestino.BackColor = Color.DarkGreen;
            btn_CsvDestino.ForeColor = Color.White;
            btn_CsvDestino.Location = new Point(35, 29);
            btn_CsvDestino.Name = "btn_CsvDestino";
            btn_CsvDestino.Size = new Size(105, 45);
            btn_CsvDestino.TabIndex = 3;
            btn_CsvDestino.Text = ".CSV";
            btn_CsvDestino.UseVisualStyleBackColor = false;
            btn_CsvDestino.Click += btn_CsvDestino_Click;
            // 
            // btn_PdfDestino
            // 
            btn_PdfDestino.BackColor = Color.DarkGreen;
            btn_PdfDestino.ForeColor = Color.White;
            btn_PdfDestino.Location = new Point(175, 29);
            btn_PdfDestino.Name = "btn_PdfDestino";
            btn_PdfDestino.Size = new Size(105, 45);
            btn_PdfDestino.TabIndex = 2;
            btn_PdfDestino.Text = "PDF";
            btn_PdfDestino.UseVisualStyleBackColor = false;
            btn_PdfDestino.Click += btn_PdfDestino_Click;
            // 
            // FrmDestinos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1450, 734);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmDestinos";
            Text = "Destinos";
            Load += FrmDestinos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Destinos).EndInit();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAgregarDestino;
        private Label label1;
        private TextBox txtDestinoNombre;
        private Label label2;
        private TextBox txtDestinoDuracionD;
        private GroupBox groupBox2;
        private Button btnDestinoE;
        private Label label4;
        private TextBox txtDestinoE;
        private GroupBox groupBox3;
        private Label label5;
        private TextBox txtActualizarDestinoId;
        private Button btnActualizarDestino;
        private Label label6;
        private TextBox txtNombreActualizarD;
        private Label label8;
        private TextBox txtActualizarDuracionD;
        private Panel panel1;
        private Label label9;
        private Label label10;
        private GroupBox groupBox4;
        private DataGridView dgv_Destinos;
        private GroupBox groupBox5;
        private Button btn_CsvDestino;
        private Button btn_PdfDestino;
        private Label label11;
        private ComboBox cmbDestinosP;
        private Label label3;
        private ComboBox cmbActualizarDestino;
    }
}