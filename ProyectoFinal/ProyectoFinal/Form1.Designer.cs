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
            txt_Pais = new TextBox();
            label1 = new Label();
            btnAgregarPais = new Button();
            groupBox2 = new GroupBox();
            btnEliminarPais = new Button();
            label2 = new Label();
            txtEliminarPais = new TextBox();
            groupBox3 = new GroupBox();
            btnActualizarP = new Button();
            label3 = new Label();
            txtNombreActualizarP = new TextBox();
            label4 = new Label();
            txtActualizarIDP = new TextBox();
            groupBox4 = new GroupBox();
            dgvPais = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPais).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregarPais);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_Pais);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 201);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insert";
            // 
            // txt_Pais
            // 
            txt_Pais.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Pais.Location = new Point(148, 41);
            txt_Pais.Name = "txt_Pais";
            txt_Pais.Size = new Size(204, 30);
            txt_Pais.TabIndex = 0;
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
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEliminarPais);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtEliminarPais);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(464, 12);
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
            groupBox3.Location = new Point(866, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(387, 236);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Update";
            // 
            // btnActualizarP
            // 
            btnActualizarP.BackColor = Color.DarkGreen;
            btnActualizarP.ForeColor = Color.White;
            btnActualizarP.Location = new Point(135, 166);
            btnActualizarP.Name = "btnActualizarP";
            btnActualizarP.Size = new Size(144, 57);
            btnActualizarP.TabIndex = 2;
            btnActualizarP.Text = "Actualizar";
            btnActualizarP.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 101);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 1;
            label3.Text = "Nombre Pais:";
            // 
            // txtNombreActualizarP
            // 
            txtNombreActualizarP.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreActualizarP.Location = new Point(152, 98);
            txtNombreActualizarP.Name = "txtNombreActualizarP";
            txtNombreActualizarP.Size = new Size(204, 30);
            txtNombreActualizarP.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 42);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 4;
            label4.Text = "ID Pais:";
            // 
            // txtActualizarIDP
            // 
            txtActualizarIDP.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtActualizarIDP.Location = new Point(104, 42);
            txtActualizarIDP.Name = "txtActualizarIDP";
            txtActualizarIDP.Size = new Size(204, 30);
            txtActualizarIDP.TabIndex = 3;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvPais);
            groupBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(12, 319);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1277, 420);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Select";
            // 
            // dgvPais
            // 
            dgvPais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPais.Location = new Point(104, 29);
            dgvPais.Name = "dgvPais";
            dgvPais.RowHeadersWidth = 51;
            dgvPais.Size = new Size(1058, 358);
            dgvPais.TabIndex = 0;
            // 
            // FrmPais
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1292, 743);
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
            ((System.ComponentModel.ISupportInitialize)dgvPais).EndInit();
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
        private DataGridView dgvPais;
    }
}
