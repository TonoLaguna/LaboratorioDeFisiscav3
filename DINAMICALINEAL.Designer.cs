namespace LaboratorioDeFisiscav3
{
    partial class DINAMICALINEAL
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
            BtnSiguiente = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnCalcular = new Button();
            BtnAtras = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            TxtFuerzaD = new TextBox();
            TxtMasa = new TextBox();
            TxtFuerzaI = new TextBox();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            TxtRpta = new TextBox();
            label28 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnSiguiente
            // 
            BtnSiguiente.BackColor = SystemColors.ActiveCaption;
            BtnSiguiente.Location = new Point(686, 710);
            BtnSiguiente.Name = "BtnSiguiente";
            BtnSiguiente.Size = new Size(89, 33);
            BtnSiguiente.TabIndex = 0;
            BtnSiguiente.Text = "SIGUIENTE";
            BtnSiguiente.UseVisualStyleBackColor = false;
            BtnSiguiente.Click += BtnSiguiente_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 353);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 1;
            label1.Text = "=";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.DINAMICALINEAL;
            pictureBox1.Location = new Point(248, 213);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 79);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 353);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 4;
            label2.Text = "FRE (N)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 137);
            label3.Name = "label3";
            label3.Size = new Size(315, 20);
            label3.TabIndex = 5;
            label3.Text = "DETERMINE LA ACELERACIÓN EN EL SISTEMA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(96, 3);
            label4.Name = "label4";
            label4.Size = new Size(573, 70);
            label4.TabIndex = 6;
            label4.Text = "DINÁMICA LINEAL";
            // 
            // BtnCalcular
            // 
            BtnCalcular.BackColor = SystemColors.ActiveCaption;
            BtnCalcular.Location = new Point(562, 710);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(98, 33);
            BtnCalcular.TabIndex = 7;
            BtnCalcular.Text = "CALCULAR";
            BtnCalcular.UseVisualStyleBackColor = false;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // BtnAtras
            // 
            BtnAtras.BackColor = SystemColors.ActiveCaption;
            BtnAtras.Location = new Point(444, 710);
            BtnAtras.Name = "BtnAtras";
            BtnAtras.Size = new Size(89, 33);
            BtnAtras.TabIndex = 8;
            BtnAtras.Text = "ATRAS";
            BtnAtras.UseVisualStyleBackColor = false;
            BtnAtras.Click += BtnAtras_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 402);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 10;
            label6.Text = "Fzas (→)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(346, 353);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 11;
            label7.Text = "a (m/s2)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(315, 353);
            label8.Name = "label8";
            label8.Size = new Size(15, 20);
            label8.TabIndex = 12;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(243, 353);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 13;
            label9.Text = "m (kg)";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(95, 402);
            label17.Name = "label17";
            label17.Size = new Size(19, 20);
            label17.TabIndex = 21;
            label17.Text = "+";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(120, 402);
            label18.Name = "label18";
            label18.Size = new Size(64, 20);
            label18.TabIndex = 22;
            label18.Text = "Fzas (←)";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(243, 402);
            label19.Name = "label19";
            label19.Size = new Size(52, 20);
            label19.TabIndex = 26;
            label19.Text = "m (kg)";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(315, 402);
            label20.Name = "label20";
            label20.Size = new Size(15, 20);
            label20.TabIndex = 25;
            label20.Text = "*";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(346, 402);
            label21.Name = "label21";
            label21.Size = new Size(64, 20);
            label21.TabIndex = 24;
            label21.Text = "a (m/s2)";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(198, 402);
            label22.Name = "label22";
            label22.Size = new Size(19, 20);
            label22.TabIndex = 23;
            label22.Text = "=";
            // 
            // TxtFuerzaD
            // 
            TxtFuerzaD.Location = new Point(25, 447);
            TxtFuerzaD.Name = "TxtFuerzaD";
            TxtFuerzaD.Size = new Size(64, 27);
            TxtFuerzaD.TabIndex = 27;
            // 
            // TxtMasa
            // 
            TxtMasa.Location = new Point(231, 447);
            TxtMasa.Name = "TxtMasa";
            TxtMasa.Size = new Size(64, 27);
            TxtMasa.TabIndex = 29;
            // 
            // TxtFuerzaI
            // 
            TxtFuerzaI.Location = new Point(120, 447);
            TxtFuerzaI.Name = "TxtFuerzaI";
            TxtFuerzaI.Size = new Size(64, 27);
            TxtFuerzaI.TabIndex = 31;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(95, 450);
            label23.Name = "label23";
            label23.Size = new Size(15, 20);
            label23.TabIndex = 32;
            label23.Text = "-";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(198, 508);
            label24.Name = "label24";
            label24.Size = new Size(19, 20);
            label24.TabIndex = 33;
            label24.Text = "=";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(315, 454);
            label25.Name = "label25";
            label25.Size = new Size(15, 20);
            label25.TabIndex = 34;
            label25.Text = "*";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(346, 454);
            label26.Name = "label26";
            label26.Size = new Size(64, 20);
            label26.TabIndex = 35;
            label26.Text = "a (m/s2)";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(231, 511);
            label27.Name = "label27";
            label27.Size = new Size(64, 20);
            label27.TabIndex = 36;
            label27.Text = "a (m/s2)";
            // 
            // TxtRpta
            // 
            TxtRpta.Location = new Point(120, 508);
            TxtRpta.Name = "TxtRpta";
            TxtRpta.Size = new Size(64, 27);
            TxtRpta.TabIndex = 37;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(198, 454);
            label28.Name = "label28";
            label28.Size = new Size(19, 20);
            label28.TabIndex = 38;
            label28.Text = "=";
            // 
            // DINAMICALINEAL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 792);
            Controls.Add(label28);
            Controls.Add(TxtRpta);
            Controls.Add(label27);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(TxtFuerzaI);
            Controls.Add(TxtMasa);
            Controls.Add(TxtFuerzaD);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(BtnAtras);
            Controls.Add(BtnCalcular);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(BtnSiguiente);
            Name = "DINAMICALINEAL";
            Text = "LABORATORIO DE FISICA - DINAMICALINEAL";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSiguiente;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnCalcular;
        private Button BtnAtras;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private TextBox TxtFuerzaD;
        private TextBox TxtMasa;
        private TextBox TxtFuerzaI;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private TextBox TxtRpta;
        private Label label28;
    }
}