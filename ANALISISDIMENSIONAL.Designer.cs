namespace LaboratorioDeFisiscav3
{
    partial class ANALISISDIMENSIONAL
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TxtRpta = new TextBox();
            BtnAtras = new Button();
            BtnCalcular = new Button();
            BtnSiguiente = new Button();
            label8 = new Label();
            groupBox1 = new GroupBox();
            RdnVelocidad = new RadioButton();
            RdnFuerza = new RadioButton();
            RdnDensidad = new RadioButton();
            RdnRadio = new RadioButton();
            RdnPresion = new RadioButton();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 135);
            label1.Name = "label1";
            label1.Size = new Size(240, 20);
            label1.TabIndex = 1;
            label1.Text = "HALLAR LA EXPRESIÓN CORRECTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 2);
            label2.Name = "label2";
            label2.Size = new Size(777, 70);
            label2.TabIndex = 2;
            label2.Text = "ANÁLISIS DIMENSIONAL ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 75);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 3;
            label3.Text = "PRESION : P ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 75);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 4;
            label4.Text = "RADIO : R";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(309, 75);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 5;
            label5.Text = "DENSIDAD : Q";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(475, 75);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 6;
            label6.Text = "FUERZA : B";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(623, 75);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 7;
            label7.Text = "VELOCIDAD : Z";
            // 
            // TxtRpta
            // 
            TxtRpta.Location = new Point(604, 669);
            TxtRpta.Name = "TxtRpta";
            TxtRpta.Size = new Size(93, 27);
            TxtRpta.TabIndex = 10;
            // 
            // BtnAtras
            // 
            BtnAtras.BackColor = SystemColors.ActiveCaption;
            BtnAtras.Location = new Point(300, 573);
            BtnAtras.Name = "BtnAtras";
            BtnAtras.Size = new Size(121, 35);
            BtnAtras.TabIndex = 15;
            BtnAtras.Text = "ATRAS";
            BtnAtras.UseVisualStyleBackColor = false;
            BtnAtras.Click += BtnAtras_Click;
            // 
            // BtnCalcular
            // 
            BtnCalcular.BackColor = SystemColors.ActiveCaption;
            BtnCalcular.Location = new Point(445, 573);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(121, 35);
            BtnCalcular.TabIndex = 16;
            BtnCalcular.Text = "CALCULAR";
            BtnCalcular.UseVisualStyleBackColor = false;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // BtnSiguiente
            // 
            BtnSiguiente.BackColor = SystemColors.ActiveCaption;
            BtnSiguiente.Location = new Point(591, 573);
            BtnSiguiente.Name = "BtnSiguiente";
            BtnSiguiente.Size = new Size(121, 35);
            BtnSiguiente.TabIndex = 17;
            BtnSiguiente.Text = "SIGUIENTE";
            BtnSiguiente.UseVisualStyleBackColor = false;
            BtnSiguiente.Click += BtnSiguiente_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(548, 676);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 18;
            label8.Text = "RPTA :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(RdnVelocidad);
            groupBox1.Controls.Add(RdnFuerza);
            groupBox1.Controls.Add(RdnDensidad);
            groupBox1.Controls.Add(RdnRadio);
            groupBox1.Controls.Add(RdnPresion);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(17, 189);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(768, 262);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "FORMULAS DIMENSIONALES";
            // 
            // RdnVelocidad
            // 
            RdnVelocidad.AutoSize = true;
            RdnVelocidad.Location = new Point(629, 136);
            RdnVelocidad.Name = "RdnVelocidad";
            RdnVelocidad.Size = new Size(57, 24);
            RdnVelocidad.TabIndex = 12;
            RdnVelocidad.TabStop = true;
            RdnVelocidad.Text = "MLT";
            RdnVelocidad.UseVisualStyleBackColor = true;
            // 
            // RdnFuerza
            // 
            RdnFuerza.AutoSize = true;
            RdnFuerza.Location = new Point(484, 136);
            RdnFuerza.Name = "RdnFuerza";
            RdnFuerza.Size = new Size(57, 24);
            RdnFuerza.TabIndex = 11;
            RdnFuerza.TabStop = true;
            RdnFuerza.Text = "MLT";
            RdnFuerza.UseVisualStyleBackColor = true;
            // 
            // RdnDensidad
            // 
            RdnDensidad.AutoSize = true;
            RdnDensidad.Location = new Point(324, 136);
            RdnDensidad.Name = "RdnDensidad";
            RdnDensidad.Size = new Size(50, 24);
            RdnDensidad.TabIndex = 10;
            RdnDensidad.TabStop = true;
            RdnDensidad.Text = "ML";
            RdnDensidad.UseVisualStyleBackColor = true;
            // 
            // RdnRadio
            // 
            RdnRadio.AutoSize = true;
            RdnRadio.Location = new Point(168, 136);
            RdnRadio.Name = "RdnRadio";
            RdnRadio.Size = new Size(58, 24);
            RdnRadio.TabIndex = 9;
            RdnRadio.TabStop = true;
            RdnRadio.Text = "LMT";
            RdnRadio.UseVisualStyleBackColor = true;
            // 
            // RdnPresion
            // 
            RdnPresion.AutoSize = true;
            RdnPresion.Location = new Point(28, 136);
            RdnPresion.Name = "RdnPresion";
            RdnPresion.Size = new Size(66, 24);
            RdnPresion.TabIndex = 8;
            RdnPresion.TabStop = true;
            RdnPresion.Text = "M L T";
            RdnPresion.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(534, 126);
            label9.Name = "label9";
            label9.Size = new Size(23, 20);
            label9.TabIndex = 13;
            label9.Text = "-2";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(681, 126);
            label10.Name = "label10";
            label10.Size = new Size(23, 20);
            label10.TabIndex = 14;
            label10.Text = "-2";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(221, 126);
            label11.Name = "label11";
            label11.Size = new Size(23, 20);
            label11.TabIndex = 15;
            label11.Text = "-3";
            // 
            // ANALISISDIMENSIONAL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 720);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(BtnSiguiente);
            Controls.Add(BtnCalcular);
            Controls.Add(BtnAtras);
            Controls.Add(TxtRpta);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ANALISISDIMENSIONAL";
            Text = "LABORATORIO DE FISICA - ANALISIS DIMENSIONAL";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TxtRpta;
        private Button BtnAtras;
        private Button BtnCalcular;
        private Button BtnSiguiente;
        private Label label8;
        private GroupBox groupBox1;
        private RadioButton RdnVelocidad;
        private RadioButton RdnFuerza;
        private RadioButton RdnDensidad;
        private RadioButton RdnRadio;
        private RadioButton RdnPresion;
        private Label label9;
        private Label label11;
        private Label label10;
    }
}
