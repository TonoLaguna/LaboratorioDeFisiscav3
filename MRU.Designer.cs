namespace LaboratorioDeFisiscav3
{
    partial class MRU
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            TxtKm = new TextBox();
            TxtM = new TextBox();
            label7 = new Label();
            TxtConvertir = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            TxtTiempo = new TextBox();
            BtnAtras = new Button();
            BtnCalcular = new Button();
            BtnSiguiente = new Button();
            TxtRpta = new TextBox();
            label8 = new Label();
            label9 = new Label();
            TxtVelocidad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, 2);
            label1.Name = "label1";
            label1.Size = new Size(832, 140);
            label1.TabIndex = 0;
            label1.Text = "MOVIMIENTO RECTILÍNEO \r\n              UNIFORME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 161);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 1;
            label2.Text = "EN LA FIGURA HALLAR \"d\"";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 418);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "d (m)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(182, 418);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 3;
            label4.Text = "v (m/s)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(374, 418);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 4;
            label5.Text = "t (s)";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MRU;
            pictureBox1.Location = new Point(253, 213);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 141);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(582, 243);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 6;
            label6.Text = " km/h =";
            // 
            // TxtKm
            // 
            TxtKm.Location = new Point(645, 236);
            TxtKm.Name = "TxtKm";
            TxtKm.Size = new Size(137, 27);
            TxtKm.TabIndex = 7;
            // 
            // TxtM
            // 
            TxtM.Location = new Point(643, 311);
            TxtM.Name = "TxtM";
            TxtM.Size = new Size(137, 27);
            TxtM.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(607, 316);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 8;
            label7.Text = "m =";
            // 
            // TxtConvertir
            // 
            TxtConvertir.BackColor = SystemColors.ActiveCaption;
            TxtConvertir.Location = new Point(607, 273);
            TxtConvertir.Name = "TxtConvertir";
            TxtConvertir.Size = new Size(179, 33);
            TxtConvertir.TabIndex = 10;
            TxtConvertir.Text = "CONVERTIR km/h a m/s";
            TxtConvertir.UseVisualStyleBackColor = false;
            TxtConvertir.Click += TxtConvertir_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(50, 460);
            label10.Name = "label10";
            label10.Size = new Size(18, 20);
            label10.TabIndex = 11;
            label10.Text = "d";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(113, 456);
            label11.Name = "label11";
            label11.Size = new Size(19, 20);
            label11.TabIndex = 14;
            label11.Text = "=";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(113, 418);
            label12.Name = "label12";
            label12.Size = new Size(19, 20);
            label12.TabIndex = 15;
            label12.Text = "=";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(289, 418);
            label13.Name = "label13";
            label13.Size = new Size(15, 20);
            label13.TabIndex = 16;
            label13.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(289, 456);
            label14.Name = "label14";
            label14.Size = new Size(15, 20);
            label14.TabIndex = 17;
            label14.Text = "*";
            // 
            // TxtTiempo
            // 
            TxtTiempo.Location = new Point(360, 453);
            TxtTiempo.Name = "TxtTiempo";
            TxtTiempo.Size = new Size(62, 27);
            TxtTiempo.TabIndex = 19;
            // 
            // BtnAtras
            // 
            BtnAtras.BackColor = SystemColors.ActiveCaption;
            BtnAtras.Location = new Point(398, 514);
            BtnAtras.Name = "BtnAtras";
            BtnAtras.Size = new Size(109, 32);
            BtnAtras.TabIndex = 20;
            BtnAtras.Text = "ATRAS";
            BtnAtras.UseVisualStyleBackColor = false;
            BtnAtras.Click += BtnAtras_Click;
            // 
            // BtnCalcular
            // 
            BtnCalcular.BackColor = SystemColors.ActiveCaption;
            BtnCalcular.Location = new Point(546, 514);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(109, 32);
            BtnCalcular.TabIndex = 21;
            BtnCalcular.Text = "CALCULAR";
            BtnCalcular.UseVisualStyleBackColor = false;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // BtnSiguiente
            // 
            BtnSiguiente.BackColor = SystemColors.ActiveCaption;
            BtnSiguiente.Location = new Point(696, 514);
            BtnSiguiente.Name = "BtnSiguiente";
            BtnSiguiente.Size = new Size(109, 32);
            BtnSiguiente.TabIndex = 22;
            BtnSiguiente.Text = "SIGUIENTE";
            BtnSiguiente.UseVisualStyleBackColor = false;
            // 
            // TxtRpta
            // 
            TxtRpta.Location = new Point(182, 511);
            TxtRpta.Name = "TxtRpta";
            TxtRpta.Size = new Size(62, 27);
            TxtRpta.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(113, 514);
            label8.Name = "label8";
            label8.Size = new Size(19, 20);
            label8.TabIndex = 24;
            label8.Text = "=";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(50, 518);
            label9.Name = "label9";
            label9.Size = new Size(18, 20);
            label9.TabIndex = 23;
            label9.Text = "d";
            // 
            // TxtVelocidad
            // 
            TxtVelocidad.Location = new Point(182, 453);
            TxtVelocidad.Name = "TxtVelocidad";
            TxtVelocidad.Size = new Size(62, 27);
            TxtVelocidad.TabIndex = 26;
            // 
            // MRU
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 679);
            Controls.Add(TxtVelocidad);
            Controls.Add(TxtRpta);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(BtnSiguiente);
            Controls.Add(BtnCalcular);
            Controls.Add(BtnAtras);
            Controls.Add(TxtTiempo);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(TxtConvertir);
            Controls.Add(TxtM);
            Controls.Add(label7);
            Controls.Add(TxtKm);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MRU";
            Text = "LABORATORIO DE FISICA - MRU";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private TextBox TxtKm;
        private TextBox TxtM;
        private Label label7;
        private Button TxtConvertir;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBox3;
        private TextBox TxtTiempo;
        private Button BtnAtras;
        private Button BtnCalcular;
        private Button BtnSiguiente;
        private TextBox TxtRpta;
        private Label label8;
        private Label label9;
        private TextBox TxtVelocidad;
    }
}