namespace ProyectoFinal
{
    partial class FrmTours
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
            groupBox5 = new GroupBox();
            btn_CsvDestino = new Button();
            btn_PdfDestino = new Button();
            groupBox4 = new GroupBox();
            dgv_Tour = new DataGridView();
            panel1 = new Panel();
            label9 = new Label();
            label10 = new Label();
            groupBox3 = new GroupBox();
            label12 = new Label();
            txtActualizarDuracionH = new TextBox();
            label3 = new Label();
            cmbActualizarDestino = new ComboBox();
            label8 = new Label();
            txtActualizarDuracionD = new TextBox();
            label5 = new Label();
            txtActualizarDestinoId = new TextBox();
            btnActualizarDestino = new Button();
            label6 = new Label();
            txtNombreActualizarD = new TextBox();
            groupBox2 = new GroupBox();
            btnEliminarTour = new Button();
            label4 = new Label();
            txtTourEliminar = new TextBox();
            groupBox1 = new GroupBox();
            dtpHoraTour = new DateTimePicker();
            txtPrecioTour = new TextBox();
            label14 = new Label();
            btnAgregarDestino = new Button();
            label13 = new Label();
            dtpFechaTour = new DateTimePicker();
            cmbDestinoTour = new ComboBox();
            label7 = new Label();
            label11 = new Label();
            label2 = new Label();
            cmbPaisTour = new ComboBox();
            label1 = new Label();
            txtNombreTour = new TextBox();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Tour).BeginInit();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btn_CsvDestino);
            groupBox5.Controls.Add(btn_PdfDestino);
            groupBox5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(1141, 18);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(296, 85);
            groupBox5.TabIndex = 16;
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
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgv_Tour);
            groupBox4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.Black;
            groupBox4.Location = new Point(12, 458);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1450, 335);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Select";
            // 
            // dgv_Tour
            // 
            dgv_Tour.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Tour.Location = new Point(15, 23);
            dgv_Tour.Name = "dgv_Tour";
            dgv_Tour.RowHeadersWidth = 51;
            dgv_Tour.Size = new Size(1425, 304);
            dgv_Tour.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(label9);
            panel1.Location = new Point(532, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 43);
            panel1.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(23, 6);
            label9.Name = "label9";
            label9.Size = new Size(385, 28);
            label9.TabIndex = 4;
            label9.Text = "    <= Opciones para gestionar Tours=>";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(564, -2);
            label10.Name = "label10";
            label10.Size = new Size(444, 92);
            label10.TabIndex = 13;
            label10.Text = "Agencia de Tours";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txtActualizarDuracionH);
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
            groupBox3.Location = new Point(921, 149);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(589, 238);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Update";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(243, 184);
            label12.Name = "label12";
            label12.Size = new Size(138, 23);
            label12.TabIndex = 12;
            label12.Text = "Duracion Horas:";
            // 
            // txtActualizarDuracionH
            // 
            txtActualizarDuracionH.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtActualizarDuracionH.Location = new Point(384, 183);
            txtActualizarDuracionH.Name = "txtActualizarDuracionH";
            txtActualizarDuracionH.Size = new Size(88, 30);
            txtActualizarDuracionH.TabIndex = 11;
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
            txtActualizarDuracionD.Location = new Point(150, 182);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEliminarTour);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtTourEliminar);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(589, 176);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(277, 154);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Delete";
            // 
            // btnEliminarTour
            // 
            btnEliminarTour.BackColor = Color.DarkGreen;
            btnEliminarTour.ForeColor = Color.White;
            btnEliminarTour.Location = new Point(78, 85);
            btnEliminarTour.Name = "btnEliminarTour";
            btnEliminarTour.Size = new Size(144, 57);
            btnEliminarTour.TabIndex = 2;
            btnEliminarTour.Text = "Eliminar";
            btnEliminarTour.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 40);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 1;
            label4.Text = "Tour ID:";
            // 
            // txtTourEliminar
            // 
            txtTourEliminar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTourEliminar.Location = new Point(99, 37);
            txtTourEliminar.Name = "txtTourEliminar";
            txtTourEliminar.Size = new Size(116, 30);
            txtTourEliminar.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpHoraTour);
            groupBox1.Controls.Add(txtPrecioTour);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(btnAgregarDestino);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(dtpFechaTour);
            groupBox1.Controls.Add(cmbDestinoTour);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbPaisTour);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombreTour);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(27, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(453, 279);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insert";
            // 
            // dtpHoraTour
            // 
            dtpHoraTour.Format = DateTimePickerFormat.Time;
            dtpHoraTour.Location = new Point(79, 196);
            dtpHoraTour.Name = "dtpHoraTour";
            dtpHoraTour.ShowUpDown = true;
            dtpHoraTour.Size = new Size(115, 30);
            dtpHoraTour.TabIndex = 17;
            // 
            // txtPrecioTour
            // 
            txtPrecioTour.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrecioTour.Location = new Point(80, 234);
            txtPrecioTour.Name = "txtPrecioTour";
            txtPrecioTour.Size = new Size(114, 30);
            txtPrecioTour.TabIndex = 16;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(12, 237);
            label14.Name = "label14";
            label14.Size = new Size(64, 23);
            label14.TabIndex = 15;
            label14.Text = "Precio:";
            // 
            // btnAgregarDestino
            // 
            btnAgregarDestino.BackColor = Color.DarkGreen;
            btnAgregarDestino.ForeColor = Color.White;
            btnAgregarDestino.Location = new Point(273, 185);
            btnAgregarDestino.Name = "btnAgregarDestino";
            btnAgregarDestino.Size = new Size(144, 57);
            btnAgregarDestino.TabIndex = 2;
            btnAgregarDestino.Text = "Agregar";
            btnAgregarDestino.UseVisualStyleBackColor = false;
            btnAgregarDestino.Click += btnAgregarDestino_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(13, 197);
            label13.Name = "label13";
            label13.Size = new Size(54, 23);
            label13.TabIndex = 13;
            label13.Text = "Hora:";
            // 
            // dtpFechaTour
            // 
            dtpFechaTour.Format = DateTimePickerFormat.Short;
            dtpFechaTour.Location = new Point(79, 154);
            dtpFechaTour.Name = "dtpFechaTour";
            dtpFechaTour.Size = new Size(153, 30);
            dtpFechaTour.TabIndex = 12;
            // 
            // cmbDestinoTour
            // 
            cmbDestinoTour.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbDestinoTour.FormattingEnabled = true;
            cmbDestinoTour.Location = new Point(96, 113);
            cmbDestinoTour.Name = "cmbDestinoTour";
            cmbDestinoTour.Size = new Size(252, 31);
            cmbDestinoTour.TabIndex = 11;
            cmbDestinoTour.Text = "            -- Seleciona --";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 158);
            label7.Name = "label7";
            label7.Size = new Size(60, 23);
            label7.TabIndex = 10;
            label7.Text = "Fecha:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(12, 72);
            label11.Name = "label11";
            label11.Size = new Size(116, 23);
            label11.TabIndex = 8;
            label11.Text = "Elige un pais:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 115);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 4;
            label2.Text = "Destino:";
            // 
            // cmbPaisTour
            // 
            cmbPaisTour.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPaisTour.FormattingEnabled = true;
            cmbPaisTour.Location = new Point(133, 71);
            cmbPaisTour.Name = "cmbPaisTour";
            cmbPaisTour.Size = new Size(252, 31);
            cmbPaisTour.TabIndex = 7;
            cmbPaisTour.Text = "            -- Seleciona --";
            cmbPaisTour.SelectedIndexChanged += cmbPaisTour_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 30);
            label1.Name = "label1";
            label1.Size = new Size(158, 23);
            label1.TabIndex = 1;
            label1.Text = "Nombre del Tours:";
            // 
            // txtNombreTour
            // 
            txtNombreTour.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreTour.Location = new Point(171, 29);
            txtNombreTour.Name = "txtNombreTour";
            txtNombreTour.Size = new Size(268, 30);
            txtNombreTour.TabIndex = 0;
            // 
            // FrmTours
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1529, 893);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmTours";
            Text = "Tours";
            Load += FrmTours_Load;
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Tour).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox5;
        private Button btn_CsvDestino;
        private Button btn_PdfDestino;
        private GroupBox groupBox4;
        private DataGridView dgv_Tour;
        private Panel panel1;
        private Label label9;
        private Label label10;
        private GroupBox groupBox3;
        private Label label12;
        private TextBox txtActualizarDuracionH;
        private Label label3;
        private ComboBox cmbActualizarDestino;
        private Label label8;
        private TextBox txtActualizarDuracionD;
        private Label label5;
        private TextBox txtActualizarDestinoId;
        private Button btnActualizarDestino;
        private Label label6;
        private TextBox txtNombreActualizarD;
        private GroupBox groupBox2;
        private Button btnEliminarTour;
        private Label label4;
        private TextBox txtTourEliminar;
        private GroupBox groupBox1;
        private Label label7;
        private Label label11;
        private ComboBox cmbPaisTour;
        private Button btnAgregarDestino;
        private Label label2;
        private Label label1;
        private TextBox txtNombreTour;
        private DateTimePicker dtpFechaTour;
        private ComboBox cmbDestinoTour;
        private Label label13;
        private TextBox txtPrecioTour;
        private Label label14;
        private DateTimePicker dtpHoraTour;
    }
}