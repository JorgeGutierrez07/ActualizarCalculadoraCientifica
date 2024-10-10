namespace CalculadoraWindows
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelTitle = new Panel();
            Minimizar = new Button();
            buttonExit = new Button();
            panelHistorial = new Panel();
            RtBoxDisplayHistory = new RichTextBox();
            botonLimpiarHistorial = new Button();
            panel1 = new Panel();
            textDisplay2 = new TextBox();
            textDisplay1 = new TextBox();
            BtnClear = new Button();
            BtnCE = new Button();
            BtnExpo = new Button();
            Btn4 = new Button();
            Btn5 = new Button();
            Btn6 = new Button();
            BtnLess = new Button();
            Btn7 = new Button();
            Btn8 = new Button();
            Btn9 = new Button();
            BtnMulti = new Button();
            Btn1 = new Button();
            Btn2 = new Button();
            Btn3 = new Button();
            BtnPlus = new Button();
            BtnPM = new Button();
            Btn0 = new Button();
            BtnDecimal = new Button();
            BtnEqual = new Button();
            tangente = new Button();
            elevarAla3 = new Button();
            cos = new Button();
            ExponenteAlaY = new Button();
            Seno = new Button();
            diezAlax = new Button();
            pi = new Button();
            exp = new Button();
            raizCubica = new Button();
            log = new Button();
            button14 = new Button();
            BtnBorrar_Click = new Button();
            panelTitle.SuspendLayout();
            panelHistorial.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(Minimizar);
            panelTitle.Controls.Add(buttonExit);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(717, 39);
            panelTitle.TabIndex = 0;
            // 
            // Minimizar
            // 
            Minimizar.Cursor = Cursors.Hand;
            Minimizar.Dock = DockStyle.Right;
            Minimizar.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            Minimizar.FlatAppearance.MouseOverBackColor = Color.Gray;
            Minimizar.FlatStyle = FlatStyle.Flat;
            Minimizar.Location = new Point(609, 0);
            Minimizar.Margin = new Padding(0);
            Minimizar.Name = "Minimizar";
            Minimizar.Size = new Size(54, 39);
            Minimizar.TabIndex = 2;
            Minimizar.Text = "-";
            Minimizar.UseVisualStyleBackColor = true;
            Minimizar.Click += Minimizar_Click;
            // 
            // buttonExit
            // 
            buttonExit.Cursor = Cursors.Hand;
            buttonExit.Dock = DockStyle.Right;
            buttonExit.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            buttonExit.FlatAppearance.MouseOverBackColor = Color.Red;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Location = new Point(663, 0);
            buttonExit.Margin = new Padding(0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(54, 39);
            buttonExit.TabIndex = 0;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += button1_Click;
            // 
            // panelHistorial
            // 
            panelHistorial.Controls.Add(RtBoxDisplayHistory);
            panelHistorial.Controls.Add(botonLimpiarHistorial);
            panelHistorial.Dock = DockStyle.Bottom;
            panelHistorial.Location = new Point(0, 393);
            panelHistorial.Margin = new Padding(0);
            panelHistorial.Name = "panelHistorial";
            panelHistorial.Size = new Size(717, 5);
            panelHistorial.TabIndex = 1;
            // 
            // RtBoxDisplayHistory
            // 
            RtBoxDisplayHistory.BackColor = Color.FromArgb(32, 32, 32);
            RtBoxDisplayHistory.BorderStyle = BorderStyle.None;
            RtBoxDisplayHistory.Dock = DockStyle.Fill;
            RtBoxDisplayHistory.ForeColor = Color.Silver;
            RtBoxDisplayHistory.Location = new Point(0, 0);
            RtBoxDisplayHistory.Name = "RtBoxDisplayHistory";
            RtBoxDisplayHistory.ScrollBars = RichTextBoxScrollBars.Horizontal;
            RtBoxDisplayHistory.Size = new Size(717, 0);
            RtBoxDisplayHistory.TabIndex = 2;
            RtBoxDisplayHistory.Text = "";
            // 
            // botonLimpiarHistorial
            // 
            botonLimpiarHistorial.Cursor = Cursors.Hand;
            botonLimpiarHistorial.Dock = DockStyle.Bottom;
            botonLimpiarHistorial.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            botonLimpiarHistorial.FlatAppearance.MouseOverBackColor = Color.DimGray;
            botonLimpiarHistorial.FlatStyle = FlatStyle.Flat;
            botonLimpiarHistorial.Image = (Image)resources.GetObject("botonLimpiarHistorial.Image");
            botonLimpiarHistorial.Location = new Point(0, -34);
            botonLimpiarHistorial.Margin = new Padding(0);
            botonLimpiarHistorial.Name = "botonLimpiarHistorial";
            botonLimpiarHistorial.Size = new Size(717, 39);
            botonLimpiarHistorial.TabIndex = 1;
            botonLimpiarHistorial.UseVisualStyleBackColor = true;
            botonLimpiarHistorial.Click += botonLimpiarHistorial_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 10);
            panel1.TabIndex = 2;
            // 
            // textDisplay2
            // 
            textDisplay2.BackColor = Color.FromArgb(32, 32, 32);
            textDisplay2.BorderStyle = BorderStyle.None;
            textDisplay2.Dock = DockStyle.Top;
            textDisplay2.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textDisplay2.ForeColor = Color.DarkGray;
            textDisplay2.Location = new Point(0, 49);
            textDisplay2.Margin = new Padding(0);
            textDisplay2.Multiline = true;
            textDisplay2.Name = "textDisplay2";
            textDisplay2.Size = new Size(717, 25);
            textDisplay2.TabIndex = 3;
            textDisplay2.Text = "0";
            textDisplay2.TextAlign = HorizontalAlignment.Right;
            // 
            // textDisplay1
            // 
            textDisplay1.BackColor = Color.FromArgb(32, 32, 32);
            textDisplay1.BorderStyle = BorderStyle.None;
            textDisplay1.Dock = DockStyle.Top;
            textDisplay1.Font = new Font("Gadugi", 34.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textDisplay1.ForeColor = Color.DarkGray;
            textDisplay1.Location = new Point(0, 74);
            textDisplay1.Margin = new Padding(0);
            textDisplay1.Multiline = true;
            textDisplay1.Name = "textDisplay1";
            textDisplay1.Size = new Size(717, 61);
            textDisplay1.TabIndex = 4;
            textDisplay1.Text = "0";
            textDisplay1.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.FromArgb(32, 32, 32);
            BtnClear.FlatAppearance.BorderSize = 0;
            BtnClear.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnClear.FlatStyle = FlatStyle.Flat;
            BtnClear.ForeColor = Color.DarkGray;
            BtnClear.Location = new Point(622, 144);
            BtnClear.Margin = new Padding(0);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(86, 45);
            BtnClear.TabIndex = 15;
            BtnClear.Text = "C";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnCE
            // 
            BtnCE.BackColor = Color.FromArgb(32, 32, 32);
            BtnCE.FlatAppearance.BorderSize = 0;
            BtnCE.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnCE.FlatStyle = FlatStyle.Flat;
            BtnCE.ForeColor = Color.DarkGray;
            BtnCE.Location = new Point(529, 144);
            BtnCE.Margin = new Padding(0);
            BtnCE.Name = "BtnCE";
            BtnCE.Size = new Size(86, 49);
            BtnCE.TabIndex = 16;
            BtnCE.Text = "CE";
            BtnCE.UseVisualStyleBackColor = false;
            BtnCE.Click += BtnCE_Click;
            // 
            // BtnExpo
            // 
            BtnExpo.BackColor = Color.FromArgb(32, 32, 32);
            BtnExpo.FlatAppearance.BorderSize = 0;
            BtnExpo.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnExpo.FlatStyle = FlatStyle.Flat;
            BtnExpo.ForeColor = Color.White;
            BtnExpo.Location = new Point(97, 244);
            BtnExpo.Margin = new Padding(0);
            BtnExpo.Name = "BtnExpo";
            BtnExpo.Size = new Size(100, 49);
            BtnExpo.TabIndex = 20;
            BtnExpo.Text = "ˆ2";
            BtnExpo.UseVisualStyleBackColor = false;
            BtnExpo.Click += BtnOperacionesAvanzadas;
            // 
            // Btn4
            // 
            Btn4.BackColor = Color.Gray;
            Btn4.FlatAppearance.BorderSize = 0;
            Btn4.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn4.FlatStyle = FlatStyle.Flat;
            Btn4.ForeColor = Color.White;
            Btn4.Location = new Point(280, 244);
            Btn4.Margin = new Padding(0);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(86, 55);
            Btn4.TabIndex = 29;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = false;
            Btn4.Click += BtnNum_Click;
            // 
            // Btn5
            // 
            Btn5.BackColor = Color.Gray;
            Btn5.FlatAppearance.BorderSize = 0;
            Btn5.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn5.FlatStyle = FlatStyle.Flat;
            Btn5.ForeColor = Color.White;
            Btn5.Location = new Point(366, 244);
            Btn5.Margin = new Padding(0);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(86, 55);
            Btn5.TabIndex = 28;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = false;
            Btn5.Click += BtnNum_Click;
            // 
            // Btn6
            // 
            Btn6.BackColor = Color.Gray;
            Btn6.FlatAppearance.BorderSize = 0;
            Btn6.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn6.FlatStyle = FlatStyle.Flat;
            Btn6.ForeColor = Color.White;
            Btn6.Location = new Point(443, 244);
            Btn6.Margin = new Padding(0);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(86, 55);
            Btn6.TabIndex = 27;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = false;
            Btn6.Click += BtnNum_Click;
            // 
            // BtnLess
            // 
            BtnLess.BackColor = Color.FromArgb(32, 32, 32);
            BtnLess.FlatAppearance.BorderSize = 0;
            BtnLess.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnLess.FlatStyle = FlatStyle.Flat;
            BtnLess.ForeColor = Color.DarkGray;
            BtnLess.Location = new Point(529, 244);
            BtnLess.Margin = new Padding(0);
            BtnLess.Name = "BtnLess";
            BtnLess.Size = new Size(86, 55);
            BtnLess.TabIndex = 26;
            BtnLess.Text = "-";
            BtnLess.UseVisualStyleBackColor = false;
            BtnLess.Click += BtnOperaciones;
            // 
            // Btn7
            // 
            Btn7.BackColor = Color.Gray;
            Btn7.FlatAppearance.BorderSize = 0;
            Btn7.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn7.FlatStyle = FlatStyle.Flat;
            Btn7.ForeColor = Color.White;
            Btn7.Location = new Point(283, 190);
            Btn7.Margin = new Padding(0);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(83, 54);
            Btn7.TabIndex = 25;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = false;
            Btn7.Click += BtnNum_Click;
            // 
            // Btn8
            // 
            Btn8.BackColor = Color.Gray;
            Btn8.FlatAppearance.BorderSize = 0;
            Btn8.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn8.FlatStyle = FlatStyle.Flat;
            Btn8.ForeColor = Color.White;
            Btn8.Location = new Point(366, 190);
            Btn8.Margin = new Padding(0);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(86, 54);
            Btn8.TabIndex = 24;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = false;
            Btn8.Click += BtnNum_Click;
            // 
            // Btn9
            // 
            Btn9.BackColor = Color.Gray;
            Btn9.FlatAppearance.BorderSize = 0;
            Btn9.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn9.FlatStyle = FlatStyle.Flat;
            Btn9.ForeColor = Color.White;
            Btn9.Location = new Point(443, 190);
            Btn9.Margin = new Padding(0);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(86, 54);
            Btn9.TabIndex = 23;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = false;
            Btn9.Click += BtnNum_Click;
            // 
            // BtnMulti
            // 
            BtnMulti.BackColor = Color.FromArgb(32, 32, 32);
            BtnMulti.FlatAppearance.BorderSize = 0;
            BtnMulti.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnMulti.FlatStyle = FlatStyle.Flat;
            BtnMulti.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnMulti.ForeColor = Color.DarkGray;
            BtnMulti.Location = new Point(529, 189);
            BtnMulti.Margin = new Padding(0);
            BtnMulti.Name = "BtnMulti";
            BtnMulti.Size = new Size(86, 55);
            BtnMulti.TabIndex = 22;
            BtnMulti.Text = "×";
            BtnMulti.UseVisualStyleBackColor = false;
            BtnMulti.Click += BtnOperaciones;
            // 
            // Btn1
            // 
            Btn1.BackColor = Color.Gray;
            Btn1.FlatAppearance.BorderSize = 0;
            Btn1.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn1.FlatStyle = FlatStyle.Flat;
            Btn1.ForeColor = Color.White;
            Btn1.Location = new Point(280, 299);
            Btn1.Margin = new Padding(0);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(86, 49);
            Btn1.TabIndex = 33;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = false;
            Btn1.Click += BtnNum_Click;
            // 
            // Btn2
            // 
            Btn2.BackColor = Color.Gray;
            Btn2.FlatAppearance.BorderSize = 0;
            Btn2.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn2.FlatStyle = FlatStyle.Flat;
            Btn2.ForeColor = Color.White;
            Btn2.Location = new Point(366, 299);
            Btn2.Margin = new Padding(0);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(86, 49);
            Btn2.TabIndex = 32;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = false;
            Btn2.Click += BtnNum_Click;
            // 
            // Btn3
            // 
            Btn3.BackColor = Color.Gray;
            Btn3.FlatAppearance.BorderSize = 0;
            Btn3.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn3.FlatStyle = FlatStyle.Flat;
            Btn3.ForeColor = Color.White;
            Btn3.Location = new Point(443, 299);
            Btn3.Margin = new Padding(0);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(86, 49);
            Btn3.TabIndex = 31;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = false;
            Btn3.Click += BtnNum_Click;
            // 
            // BtnPlus
            // 
            BtnPlus.BackColor = Color.FromArgb(32, 32, 32);
            BtnPlus.FlatAppearance.BorderSize = 0;
            BtnPlus.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnPlus.FlatStyle = FlatStyle.Flat;
            BtnPlus.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPlus.ForeColor = Color.DarkGray;
            BtnPlus.Location = new Point(529, 299);
            BtnPlus.Margin = new Padding(0);
            BtnPlus.Name = "BtnPlus";
            BtnPlus.Size = new Size(86, 97);
            BtnPlus.TabIndex = 30;
            BtnPlus.Text = "+";
            BtnPlus.UseVisualStyleBackColor = false;
            BtnPlus.Click += BtnOperaciones;
            // 
            // BtnPM
            // 
            BtnPM.BackColor = Color.Gray;
            BtnPM.FlatAppearance.BorderSize = 0;
            BtnPM.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnPM.FlatStyle = FlatStyle.Flat;
            BtnPM.ForeColor = Color.White;
            BtnPM.Location = new Point(280, 345);
            BtnPM.Margin = new Padding(0);
            BtnPM.Name = "BtnPM";
            BtnPM.Size = new Size(86, 51);
            BtnPM.TabIndex = 37;
            BtnPM.Text = "±";
            BtnPM.UseVisualStyleBackColor = false;
            BtnPM.Click += BtnOperacionesAvanzadas;
            // 
            // Btn0
            // 
            Btn0.BackColor = Color.Gray;
            Btn0.FlatAppearance.BorderSize = 0;
            Btn0.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn0.FlatStyle = FlatStyle.Flat;
            Btn0.ForeColor = Color.White;
            Btn0.Location = new Point(366, 348);
            Btn0.Margin = new Padding(0);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(86, 48);
            Btn0.TabIndex = 36;
            Btn0.Text = "0";
            Btn0.UseVisualStyleBackColor = false;
            Btn0.Click += BtnNum_Click;
            // 
            // BtnDecimal
            // 
            BtnDecimal.BackColor = Color.Gray;
            BtnDecimal.FlatAppearance.BorderSize = 0;
            BtnDecimal.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnDecimal.FlatStyle = FlatStyle.Flat;
            BtnDecimal.ForeColor = Color.White;
            BtnDecimal.Location = new Point(443, 348);
            BtnDecimal.Margin = new Padding(0);
            BtnDecimal.Name = "BtnDecimal";
            BtnDecimal.Size = new Size(86, 52);
            BtnDecimal.TabIndex = 35;
            BtnDecimal.Text = ".";
            BtnDecimal.UseVisualStyleBackColor = false;
            BtnDecimal.Click += BtnNum_Click;
            // 
            // BtnEqual
            // 
            BtnEqual.BackColor = SystemColors.Highlight;
            BtnEqual.FlatAppearance.BorderSize = 0;
            BtnEqual.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            BtnEqual.FlatStyle = FlatStyle.Flat;
            BtnEqual.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEqual.ForeColor = Color.Transparent;
            BtnEqual.Location = new Point(622, 189);
            BtnEqual.Margin = new Padding(0);
            BtnEqual.Name = "BtnEqual";
            BtnEqual.Size = new Size(86, 211);
            BtnEqual.TabIndex = 34;
            BtnEqual.Text = "=";
            BtnEqual.UseVisualStyleBackColor = false;
            BtnEqual.Click += BtnEqual_Click;
            // 
            // tangente
            // 
            tangente.BackColor = Color.FromArgb(32, 32, 32);
            tangente.FlatAppearance.BorderSize = 0;
            tangente.FlatAppearance.MouseOverBackColor = Color.Gray;
            tangente.FlatStyle = FlatStyle.Flat;
            tangente.ForeColor = Color.White;
            tangente.Location = new Point(197, 189);
            tangente.Margin = new Padding(0);
            tangente.Name = "tangente";
            tangente.Size = new Size(86, 49);
            tangente.TabIndex = 38;
            tangente.Text = "tan";
            tangente.UseVisualStyleBackColor = false;
            tangente.Click += BtnOperacionesCientificas;
            // 
            // elevarAla3
            // 
            elevarAla3.BackColor = Color.FromArgb(32, 32, 32);
            elevarAla3.FlatAppearance.BorderSize = 0;
            elevarAla3.FlatAppearance.MouseOverBackColor = Color.Gray;
            elevarAla3.FlatStyle = FlatStyle.Flat;
            elevarAla3.ForeColor = Color.White;
            elevarAla3.Location = new Point(2, 244);
            elevarAla3.Margin = new Padding(0);
            elevarAla3.Name = "elevarAla3";
            elevarAla3.Size = new Size(86, 49);
            elevarAla3.TabIndex = 41;
            elevarAla3.Text = "xˆ3";
            elevarAla3.UseVisualStyleBackColor = false;
            elevarAla3.Click += BtnOperacionesAvanzadas;
            // 
            // cos
            // 
            cos.BackColor = Color.FromArgb(32, 32, 32);
            cos.FlatAppearance.BorderSize = 0;
            cos.FlatAppearance.MouseOverBackColor = Color.Gray;
            cos.FlatStyle = FlatStyle.Flat;
            cos.ForeColor = Color.White;
            cos.Location = new Point(97, 189);
            cos.Margin = new Padding(0);
            cos.Name = "cos";
            cos.Size = new Size(100, 49);
            cos.TabIndex = 40;
            cos.Text = "cos";
            cos.UseVisualStyleBackColor = false;
            cos.Click += BtnOperacionesCientificas;
            // 
            // ExponenteAlaY
            // 
            ExponenteAlaY.BackColor = Color.FromArgb(32, 32, 32);
            ExponenteAlaY.FlatAppearance.BorderSize = 0;
            ExponenteAlaY.FlatAppearance.MouseOverBackColor = Color.Gray;
            ExponenteAlaY.FlatStyle = FlatStyle.Flat;
            ExponenteAlaY.ForeColor = Color.White;
            ExponenteAlaY.Location = new Point(197, 244);
            ExponenteAlaY.Margin = new Padding(0);
            ExponenteAlaY.Name = "ExponenteAlaY";
            ExponenteAlaY.Size = new Size(86, 49);
            ExponenteAlaY.TabIndex = 43;
            ExponenteAlaY.Text = "x^y";
            ExponenteAlaY.UseVisualStyleBackColor = false;
            ExponenteAlaY.Click += BtnOperaciones;
            // 
            // Seno
            // 
            Seno.BackColor = Color.FromArgb(32, 32, 32);
            Seno.FlatAppearance.BorderSize = 0;
            Seno.FlatAppearance.MouseOverBackColor = Color.Gray;
            Seno.FlatStyle = FlatStyle.Flat;
            Seno.ForeColor = Color.White;
            Seno.Location = new Point(2, 188);
            Seno.Margin = new Padding(0);
            Seno.Name = "Seno";
            Seno.Size = new Size(86, 55);
            Seno.TabIndex = 42;
            Seno.Text = "sin";
            Seno.UseVisualStyleBackColor = false;
            Seno.Click += BtnOperacionesCientificas;
            // 
            // diezAlax
            // 
            diezAlax.BackColor = Color.FromArgb(32, 32, 32);
            diezAlax.FlatAppearance.BorderSize = 0;
            diezAlax.FlatAppearance.MouseOverBackColor = Color.Gray;
            diezAlax.FlatStyle = FlatStyle.Flat;
            diezAlax.ForeColor = Color.White;
            diezAlax.Location = new Point(2, 341);
            diezAlax.Margin = new Padding(0);
            diezAlax.Name = "diezAlax";
            diezAlax.Size = new Size(86, 55);
            diezAlax.TabIndex = 49;
            diezAlax.Text = "10ˆx";
            diezAlax.UseVisualStyleBackColor = false;
            diezAlax.Click += BtnOperacionesAvanzadas;
            // 
            // pi
            // 
            pi.BackColor = Color.FromArgb(32, 32, 32);
            pi.FlatAppearance.BorderSize = 0;
            pi.FlatAppearance.MouseOverBackColor = Color.Gray;
            pi.FlatStyle = FlatStyle.Flat;
            pi.ForeColor = Color.White;
            pi.Location = new Point(197, 293);
            pi.Margin = new Padding(0);
            pi.Name = "pi";
            pi.Size = new Size(86, 55);
            pi.TabIndex = 48;
            pi.Text = "π";
            pi.UseVisualStyleBackColor = false;
            pi.Click += BtnNum_Click;
            // 
            // exp
            // 
            exp.BackColor = Color.FromArgb(32, 32, 32);
            exp.FlatAppearance.BorderSize = 0;
            exp.FlatAppearance.MouseOverBackColor = Color.Gray;
            exp.FlatStyle = FlatStyle.Flat;
            exp.ForeColor = Color.White;
            exp.Location = new Point(97, 341);
            exp.Margin = new Padding(0);
            exp.Name = "exp";
            exp.Size = new Size(100, 55);
            exp.TabIndex = 47;
            exp.Text = "EXP";
            exp.UseVisualStyleBackColor = false;
            exp.Click += BtnOperacionesAvanzadas;
            // 
            // raizCubica
            // 
            raizCubica.BackColor = Color.FromArgb(32, 32, 32);
            raizCubica.FlatAppearance.BorderSize = 0;
            raizCubica.FlatAppearance.MouseOverBackColor = Color.Gray;
            raizCubica.FlatStyle = FlatStyle.Flat;
            raizCubica.ForeColor = Color.White;
            raizCubica.Location = new Point(2, 293);
            raizCubica.Margin = new Padding(0);
            raizCubica.Name = "raizCubica";
            raizCubica.Size = new Size(86, 55);
            raizCubica.TabIndex = 46;
            raizCubica.Text = "3√×";
            raizCubica.UseVisualStyleBackColor = false;
            raizCubica.Click += BtnOperacionesAvanzadas;
            // 
            // log
            // 
            log.BackColor = Color.FromArgb(32, 32, 32);
            log.FlatAppearance.BorderSize = 0;
            log.FlatAppearance.MouseOverBackColor = Color.Gray;
            log.FlatStyle = FlatStyle.Flat;
            log.ForeColor = Color.White;
            log.Location = new Point(197, 341);
            log.Margin = new Padding(0);
            log.Name = "log";
            log.Size = new Size(86, 55);
            log.TabIndex = 45;
            log.Text = "log";
            log.UseVisualStyleBackColor = false;
            log.Click += BtnOperacionesCientificas;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(32, 32, 32);
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatAppearance.MouseOverBackColor = Color.Gray;
            button14.FlatStyle = FlatStyle.Flat;
            button14.ForeColor = Color.White;
            button14.Location = new Point(97, 293);
            button14.Margin = new Padding(0);
            button14.Name = "button14";
            button14.Size = new Size(100, 55);
            button14.TabIndex = 44;
            button14.Text = "y√x";
            button14.UseVisualStyleBackColor = false;
            button14.Click += BtnOperaciones;
            // 
            // BtnBorrar_Click
            // 
            BtnBorrar_Click.BackColor = Color.FromArgb(32, 32, 32);
            BtnBorrar_Click.FlatAppearance.BorderSize = 0;
            BtnBorrar_Click.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnBorrar_Click.FlatStyle = FlatStyle.Flat;
            BtnBorrar_Click.ForeColor = Color.DarkGray;
            BtnBorrar_Click.Location = new Point(366, 144);
            BtnBorrar_Click.Margin = new Padding(0);
            BtnBorrar_Click.Name = "BtnBorrar_Click";
            BtnBorrar_Click.Size = new Size(142, 44);
            BtnBorrar_Click.TabIndex = 50;
            BtnBorrar_Click.Text = "DEL";
            BtnBorrar_Click.UseVisualStyleBackColor = false;
            BtnBorrar_Click.Click += BtnBorrar_Click_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(717, 398);
            Controls.Add(BtnBorrar_Click);
            Controls.Add(BtnCE);
            Controls.Add(BtnClear);
            Controls.Add(diezAlax);
            Controls.Add(pi);
            Controls.Add(exp);
            Controls.Add(raizCubica);
            Controls.Add(log);
            Controls.Add(button14);
            Controls.Add(ExponenteAlaY);
            Controls.Add(Seno);
            Controls.Add(elevarAla3);
            Controls.Add(cos);
            Controls.Add(tangente);
            Controls.Add(panelHistorial);
            Controls.Add(BtnPM);
            Controls.Add(Btn0);
            Controls.Add(BtnDecimal);
            Controls.Add(BtnEqual);
            Controls.Add(Btn1);
            Controls.Add(Btn2);
            Controls.Add(Btn3);
            Controls.Add(BtnPlus);
            Controls.Add(Btn4);
            Controls.Add(Btn5);
            Controls.Add(Btn6);
            Controls.Add(BtnLess);
            Controls.Add(Btn7);
            Controls.Add(Btn8);
            Controls.Add(Btn9);
            Controls.Add(BtnMulti);
            Controls.Add(BtnExpo);
            Controls.Add(textDisplay1);
            Controls.Add(textDisplay2);
            Controls.Add(panel1);
            Controls.Add(panelTitle);
            Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelTitle.ResumeLayout(false);
            panelHistorial.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTitle;
        private Panel panelHistorial;
        private Button buttonExit;
        private Button Minimizar;
        private Panel panel1;
        private TextBox textDisplay2;
        private TextBox textDisplay1;
        private Button botonLimpiarHistorial;
        private RichTextBox RtBoxDisplayHistory;
        private Button BtnClear;
        private Button BtnCE;
        private Button BtnExpo;
        private Button Btn4;
        private Button Btn5;
        private Button Btn6;
        private Button BtnLess;
        private Button Btn7;
        private Button Btn8;
        private Button Btn9;
        private Button BtnMulti;
        private Button Btn1;
        private Button Btn2;
        private Button Btn3;
        private Button BtnPlus;
        private Button BtnPM;
        private Button Btn0;
        private Button BtnDecimal;
        private Button BtnEqual;
        private Button tangente;
        private Button elevarAla3;
        private Button cos;
        private Button ExponenteAlaY;
        private Button Seno;
        private Button diezAlax;
        private Button pi;
        private Button exp;
        private Button raizCubica;
        private Button log;
        private Button button14;
        private Button BtnBorrar_Click;
    }
}
