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
            btnAgregarPais = new Button();
            label1 = new Label();
            txt_Pais = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregarPais);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_Pais);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(405, 201);
            groupBox1.TabIndex = 1;
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
            // FrmDestinos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(1450, 707);
            Controls.Add(groupBox1);
            Name = "FrmDestinos";
            Text = "FrmDestinos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAgregarPais;
        private Label label1;
        private TextBox txt_Pais;
    }
}