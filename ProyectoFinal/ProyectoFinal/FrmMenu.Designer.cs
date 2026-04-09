namespace ProyectoFinal
{
    partial class FrmMenu
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
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            btnMenuPais = new Button();
            btnMenuDestino = new Button();
            btnMenuTours = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(231, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 43);
            panel1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(10, 5);
            label6.Name = "label6";
            label6.Size = new Size(474, 28);
            label6.TabIndex = 4;
            label6.Text = "<= Seleciona una de las opciones a gestionar =>";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(219, 21);
            label5.Name = "label5";
            label5.Size = new Size(518, 92);
            label5.TabIndex = 6;
            label5.Text = "Agencia de Tours";
            // 
            // btnMenuPais
            // 
            btnMenuPais.BackColor = Color.DarkGreen;
            btnMenuPais.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuPais.ForeColor = Color.White;
            btnMenuPais.Location = new Point(370, 195);
            btnMenuPais.Name = "btnMenuPais";
            btnMenuPais.Size = new Size(194, 57);
            btnMenuPais.TabIndex = 8;
            btnMenuPais.Text = "Paises";
            btnMenuPais.UseVisualStyleBackColor = false;
            btnMenuPais.Click += btnMenuPais_Click;
            // 
            // btnMenuDestino
            // 
            btnMenuDestino.BackColor = Color.DarkGreen;
            btnMenuDestino.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuDestino.ForeColor = Color.White;
            btnMenuDestino.Location = new Point(370, 274);
            btnMenuDestino.Name = "btnMenuDestino";
            btnMenuDestino.Size = new Size(194, 57);
            btnMenuDestino.TabIndex = 9;
            btnMenuDestino.Text = "Destinos";
            btnMenuDestino.UseVisualStyleBackColor = false;
            btnMenuDestino.Click += btnMenuDestino_Click;
            // 
            // btnMenuTours
            // 
            btnMenuTours.BackColor = Color.DarkGreen;
            btnMenuTours.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuTours.ForeColor = Color.White;
            btnMenuTours.Location = new Point(370, 359);
            btnMenuTours.Name = "btnMenuTours";
            btnMenuTours.Size = new Size(194, 57);
            btnMenuTours.TabIndex = 10;
            btnMenuTours.Text = "Tours";
            btnMenuTours.UseVisualStyleBackColor = false;
            btnMenuTours.Click += btnMenuTours_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(259, 205);
            label1.Name = "label1";
            label1.Size = new Size(22, 31);
            label1.TabIndex = 11;
            label1.Text = "[";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(259, 284);
            label2.Name = "label2";
            label2.Size = new Size(22, 31);
            label2.TabIndex = 12;
            label2.Text = "[";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(259, 369);
            label3.Name = "label3";
            label3.Size = new Size(22, 31);
            label3.TabIndex = 13;
            label3.Text = "[";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(629, 205);
            label4.Name = "label4";
            label4.Size = new Size(22, 31);
            label4.TabIndex = 14;
            label4.Text = "]";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(629, 284);
            label7.Name = "label7";
            label7.Size = new Size(22, 31);
            label7.TabIndex = 15;
            label7.Text = "]";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(629, 369);
            label8.Name = "label8";
            label8.Size = new Size(22, 31);
            label8.TabIndex = 16;
            label8.Text = "]";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1013, 542);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMenuTours);
            Controls.Add(btnMenuDestino);
            Controls.Add(btnMenuPais);
            Controls.Add(panel1);
            Controls.Add(label5);
            Name = "FrmMenu";
            Text = "Menu";
            Load += FrmMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private Button btnMenuPais;
        private Button btnMenuDestino;
        private Button btnMenuTours;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
    }
}