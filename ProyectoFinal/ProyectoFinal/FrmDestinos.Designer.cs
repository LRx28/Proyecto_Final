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
            btnAgregarDestino = new Button();
            label1 = new Label();
            txtDestinoNombre = new TextBox();
            label2 = new Label();
            txtDestinoDuracionD = new TextBox();
            label3 = new Label();
            txtDestinoDuracionH = new TextBox();
            groupBox2 = new GroupBox();
            btnDestinoE = new Button();
            label4 = new Label();
            txtDestinoE = new TextBox();
            groupBox3 = new GroupBox();
            txtActualizarDestinoId = new TextBox();
            btnActualizarDestino = new Button();
            label6 = new Label();
            txtNombreActualizarD = new TextBox();
            label5 = new Label();
            label7 = new Label();
            txtActualizarDuracionH = new TextBox();
            label8 = new Label();
            txtActualizarDuracionD = new TextBox();
            panel1 = new Panel();
            label9 = new Label();
            label10 = new Label();
            groupBox4 = new GroupBox();
            dgv_Pais = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Pais).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDestinoDuracionH);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDestinoDuracionD);
            groupBox1.Controls.Add(btnAgregarDestino);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDestinoNombre);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(47, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 230);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insert";
            // 
            // btnAgregarDestino
            // 
            btnAgregarDestino.BackColor = Color.DarkGreen;
            btnAgregarDestino.ForeColor = Color.White;
            btnAgregarDestino.Location = new Point(133, 162);
            btnAgregarDestino.Name = "btnAgregarDestino";
            btnAgregarDestino.Size = new Size(144, 57);
            btnAgregarDestino.TabIndex = 2;
            btnAgregarDestino.Text = "Agregar";
            btnAgregarDestino.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.TabIndex = 1;
            label1.Text = "Nombre Destino";
            // 
            // txtDestinoNombre
            // 
            txtDestinoNombre.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDestinoNombre.Location = new Point(154, 25);
            txtDestinoNombre.Name = "txtDestinoNombre";
            txtDestinoNombre.Size = new Size(231, 25);
            txtDestinoNombre.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 4;
            label2.Text = "Duracion Dias";
            // 
            // txtDestinoDuracionD
            // 
            txtDestinoDuracionD.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDestinoDuracionD.Location = new Point(154, 70);
            txtDestinoDuracionD.Name = "txtDestinoDuracionD";
            txtDestinoDuracionD.Size = new Size(113, 25);
            txtDestinoDuracionD.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 115);
            label3.Name = "label3";
            label3.Size = new Size(133, 23);
            label3.TabIndex = 6;
            label3.Text = "Duracion Horas";
            // 
            // txtDestinoDuracionH
            // 
            txtDestinoDuracionH.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDestinoDuracionH.Location = new Point(154, 114);
            txtDestinoDuracionH.Name = "txtDestinoDuracionH";
            txtDestinoDuracionH.Size = new Size(113, 25);
            txtDestinoDuracionH.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDestinoE);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtDestinoE);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(509, 176);
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
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtActualizarDuracionH);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtActualizarDuracionD);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtActualizarDestinoId);
            groupBox3.Controls.Add(btnActualizarDestino);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtNombreActualizarD);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(822, 151);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(530, 238);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Update";
            // 
            // txtActualizarDestinoId
            // 
            txtActualizarDestinoId.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtActualizarDestinoId.Location = new Point(190, 25);
            txtActualizarDestinoId.Name = "txtActualizarDestinoId";
            txtActualizarDestinoId.Size = new Size(204, 25);
            txtActualizarDestinoId.TabIndex = 3;
            // 
            // btnActualizarDestino
            // 
            btnActualizarDestino.BackColor = Color.DarkGreen;
            btnActualizarDestino.ForeColor = Color.White;
            btnActualizarDestino.Location = new Point(190, 174);
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
            label6.Location = new Point(84, 70);
            label6.Name = "label6";
            label6.Size = new Size(117, 23);
            label6.TabIndex = 1;
            label6.Text = "Nombre Pais:";
            // 
            // txtNombreActualizarD
            // 
            txtNombreActualizarD.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreActualizarD.Location = new Point(207, 67);
            txtNombreActualizarD.Name = "txtNombreActualizarD";
            txtNombreActualizarD.Size = new Size(236, 25);
            txtNombreActualizarD.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(85, 28);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 4;
            label5.Text = "ID Destino:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(280, 121);
            label7.Name = "label7";
            label7.Size = new Size(138, 23);
            label7.TabIndex = 10;
            label7.Text = "Duracion Horas:";
            // 
            // txtActualizarDuracionH
            // 
            txtActualizarDuracionH.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtActualizarDuracionH.Location = new Point(425, 120);
            txtActualizarDuracionH.Name = "txtActualizarDuracionH";
            txtActualizarDuracionH.Size = new Size(86, 25);
            txtActualizarDuracionH.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(27, 122);
            label8.Name = "label8";
            label8.Size = new Size(126, 23);
            label8.TabIndex = 8;
            label8.Text = "Duracion Dias:";
            // 
            // txtActualizarDuracionD
            // 
            txtActualizarDuracionD.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtActualizarDuracionD.Location = new Point(171, 120);
            txtActualizarDuracionD.Name = "txtActualizarDuracionD";
            txtActualizarDuracionD.Size = new Size(86, 25);
            txtActualizarDuracionD.TabIndex = 7;
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
            groupBox4.Controls.Add(dgv_Pais);
            groupBox4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.Black;
            groupBox4.Location = new Point(38, 405);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1277, 325);
            groupBox4.TabIndex = 8;
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
            // FrmDestinos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1450, 734);
            Controls.Add(groupBox4);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmDestinos";
            Text = "FrmDestinos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Pais).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAgregarDestino;
        private Label label1;
        private TextBox txtDestinoNombre;
        private Label label3;
        private TextBox txtDestinoDuracionH;
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
        private Label label7;
        private TextBox txtActualizarDuracionH;
        private Label label8;
        private TextBox txtActualizarDuracionD;
        private Panel panel1;
        private Label label9;
        private Label label10;
        private GroupBox groupBox4;
        private DataGridView dgv_Pais;
    }
}