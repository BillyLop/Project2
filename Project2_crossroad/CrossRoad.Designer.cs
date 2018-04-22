namespace Project2_crossroad
{
    partial class CrossRoad
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrossRoad));
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.timerCarro1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.punteo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mensaje = new System.Windows.Forms.Label();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.btnNpartida = new System.Windows.Forms.Button();
            this.btnInstruciones = new System.Windows.Forms.Button();
            this.pnlModo = new System.Windows.Forms.Panel();
            this.lbModo = new System.Windows.Forms.Label();
            this.btnModo3 = new System.Windows.Forms.Button();
            this.btnModo2 = new System.Windows.Forms.Button();
            this.btnModo1 = new System.Windows.Forms.Button();
            this.pnlNivel1 = new System.Windows.Forms.Panel();
            this.btnNiv31 = new System.Windows.Forms.Button();
            this.btnNiv21 = new System.Windows.Forms.Button();
            this.btnNiv11 = new System.Windows.Forms.Button();
            this.btnN11 = new System.Windows.Forms.Button();
            this.btnN21 = new System.Windows.Forms.Button();
            this.btnN31 = new System.Windows.Forms.Button();
            this.pnlInstrucciones = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lbI8 = new System.Windows.Forms.Label();
            this.lbI7 = new System.Windows.Forms.Label();
            this.lbI6 = new System.Windows.Forms.Label();
            this.lbI5 = new System.Windows.Forms.Label();
            this.lbI4 = new System.Windows.Forms.Label();
            this.lbI3 = new System.Windows.Forms.Label();
            this.lbI2 = new System.Windows.Forms.Label();
            this.lbI1 = new System.Windows.Forms.Label();
            this.lbInstruccion = new System.Windows.Forms.Label();
            this.pnlMnu1 = new System.Windows.Forms.Panel();
            this.btnRegresarMenu = new System.Windows.Forms.Button();
            this.btnTomarAcompanante = new System.Windows.Forms.Button();
            this.btnSoltarAcompanante = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAcompanante = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timerTiempo = new System.Windows.Forms.Timer(this.components);
            this.pnlModo.SuspendLayout();
            this.pnlNivel1.SuspendLayout();
            this.pnlInstrucciones.SuspendLayout();
            this.pnlMnu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Black;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.ForeColor = System.Drawing.Color.Coral;
            this.btnUp.Location = new System.Drawing.Point(795, 323);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 0;
            this.btnUp.TabStop = false;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Black;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnLeft.Location = new System.Drawing.Point(714, 343);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.TabStop = false;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.Black;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.ForeColor = System.Drawing.Color.Yellow;
            this.btnDown.Location = new System.Drawing.Point(795, 364);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 2;
            this.btnDown.TabStop = false;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Black;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRight.Location = new System.Drawing.Point(876, 343);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 3;
            this.btnRight.TabStop = false;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // timerCarro1
            // 
            this.timerCarro1.Interval = 1000;
            this.timerCarro1.Tick += new System.EventHandler(this.timerCarro1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(731, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Punteo:";
            // 
            // punteo
            // 
            this.punteo.AutoSize = true;
            this.punteo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punteo.Location = new System.Drawing.Point(858, 62);
            this.punteo.Name = "punteo";
            this.punteo.Size = new System.Drawing.Size(51, 16);
            this.punteo.TabIndex = 5;
            this.punteo.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(731, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mensaje:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mensaje
            // 
            this.mensaje.AutoSize = true;
            this.mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensaje.Location = new System.Drawing.Point(858, 235);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(0, 16);
            this.mensaje.TabIndex = 7;
            // 
            // btnComenzar
            // 
            this.btnComenzar.BackColor = System.Drawing.Color.Orange;
            this.btnComenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComenzar.Location = new System.Drawing.Point(694, 440);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(138, 23);
            this.btnComenzar.TabIndex = 8;
            this.btnComenzar.TabStop = false;
            this.btnComenzar.Text = "Volver a comenzar";
            this.btnComenzar.UseVisualStyleBackColor = false;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // btnNpartida
            // 
            this.btnNpartida.BackColor = System.Drawing.Color.Black;
            this.btnNpartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNpartida.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnNpartida.Location = new System.Drawing.Point(17, 62);
            this.btnNpartida.Name = "btnNpartida";
            this.btnNpartida.Size = new System.Drawing.Size(201, 44);
            this.btnNpartida.TabIndex = 0;
            this.btnNpartida.Text = "Nueva Partida";
            this.btnNpartida.UseVisualStyleBackColor = false;
            this.btnNpartida.Click += new System.EventHandler(this.btnNpartida_Click);
            // 
            // btnInstruciones
            // 
            this.btnInstruciones.BackColor = System.Drawing.Color.Black;
            this.btnInstruciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstruciones.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnInstruciones.Location = new System.Drawing.Point(17, 3);
            this.btnInstruciones.Name = "btnInstruciones";
            this.btnInstruciones.Size = new System.Drawing.Size(201, 44);
            this.btnInstruciones.TabIndex = 2;
            this.btnInstruciones.Text = "Instrucciones";
            this.btnInstruciones.UseVisualStyleBackColor = false;
            this.btnInstruciones.Click += new System.EventHandler(this.btnInstruciones_Click);
            // 
            // pnlModo
            // 
            this.pnlModo.BackColor = System.Drawing.Color.Black;
            this.pnlModo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlModo.BackgroundImage")));
            this.pnlModo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlModo.Controls.Add(this.lbModo);
            this.pnlModo.Controls.Add(this.btnModo3);
            this.pnlModo.Controls.Add(this.btnModo2);
            this.pnlModo.Controls.Add(this.btnModo1);
            this.pnlModo.Location = new System.Drawing.Point(291, 12);
            this.pnlModo.Name = "pnlModo";
            this.pnlModo.Size = new System.Drawing.Size(434, 393);
            this.pnlModo.TabIndex = 10;
            this.pnlModo.Visible = false;
            // 
            // lbModo
            // 
            this.lbModo.AutoSize = true;
            this.lbModo.Font = new System.Drawing.Font("Modern No. 20", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModo.ForeColor = System.Drawing.Color.Silver;
            this.lbModo.Location = new System.Drawing.Point(14, 16);
            this.lbModo.Name = "lbModo";
            this.lbModo.Size = new System.Drawing.Size(201, 31);
            this.lbModo.TabIndex = 3;
            this.lbModo.Text = "Modo de Juego";
            // 
            // btnModo3
            // 
            this.btnModo3.BackColor = System.Drawing.Color.Black;
            this.btnModo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModo3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnModo3.Location = new System.Drawing.Point(17, 207);
            this.btnModo3.Name = "btnModo3";
            this.btnModo3.Size = new System.Drawing.Size(201, 44);
            this.btnModo3.TabIndex = 2;
            this.btnModo3.Text = "Ayuda a mascota";
            this.btnModo3.UseVisualStyleBackColor = false;
            this.btnModo3.Click += new System.EventHandler(this.btnModo3_Click);
            // 
            // btnModo2
            // 
            this.btnModo2.BackColor = System.Drawing.Color.Black;
            this.btnModo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModo2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnModo2.Location = new System.Drawing.Point(17, 157);
            this.btnModo2.Name = "btnModo2";
            this.btnModo2.Size = new System.Drawing.Size(201, 44);
            this.btnModo2.TabIndex = 1;
            this.btnModo2.Text = "Ayuda a personas";
            this.btnModo2.UseVisualStyleBackColor = false;
            this.btnModo2.Click += new System.EventHandler(this.btnModo2_Click);
            // 
            // btnModo1
            // 
            this.btnModo1.BackColor = System.Drawing.Color.Black;
            this.btnModo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModo1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnModo1.Location = new System.Drawing.Point(17, 107);
            this.btnModo1.Name = "btnModo1";
            this.btnModo1.Size = new System.Drawing.Size(201, 44);
            this.btnModo1.TabIndex = 0;
            this.btnModo1.Text = "Cruzar la calle";
            this.btnModo1.UseVisualStyleBackColor = false;
            this.btnModo1.Click += new System.EventHandler(this.btnModo1_Click);
            // 
            // pnlNivel1
            // 
            this.pnlNivel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlNivel1.BackgroundImage")));
            this.pnlNivel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNivel1.Controls.Add(this.btnNiv31);
            this.pnlNivel1.Controls.Add(this.btnNiv21);
            this.pnlNivel1.Controls.Add(this.btnNiv11);
            this.pnlNivel1.Location = new System.Drawing.Point(12, 143);
            this.pnlNivel1.Name = "pnlNivel1";
            this.pnlNivel1.Size = new System.Drawing.Size(265, 223);
            this.pnlNivel1.TabIndex = 4;
            this.pnlNivel1.Visible = false;
            // 
            // btnNiv31
            // 
            this.btnNiv31.BackColor = System.Drawing.Color.Black;
            this.btnNiv31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNiv31.ForeColor = System.Drawing.Color.Lime;
            this.btnNiv31.Location = new System.Drawing.Point(17, 114);
            this.btnNiv31.Name = "btnNiv31";
            this.btnNiv31.Size = new System.Drawing.Size(201, 44);
            this.btnNiv31.TabIndex = 2;
            this.btnNiv31.Text = "Nivel 3";
            this.btnNiv31.UseVisualStyleBackColor = false;
            this.btnNiv31.Click += new System.EventHandler(this.btnNiv31_Click);
            // 
            // btnNiv21
            // 
            this.btnNiv21.BackColor = System.Drawing.Color.Black;
            this.btnNiv21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNiv21.ForeColor = System.Drawing.Color.Lime;
            this.btnNiv21.Location = new System.Drawing.Point(17, 64);
            this.btnNiv21.Name = "btnNiv21";
            this.btnNiv21.Size = new System.Drawing.Size(201, 44);
            this.btnNiv21.TabIndex = 1;
            this.btnNiv21.Text = "Nivel 2";
            this.btnNiv21.UseVisualStyleBackColor = false;
            this.btnNiv21.Click += new System.EventHandler(this.btnNiv21_Click);
            // 
            // btnNiv11
            // 
            this.btnNiv11.BackColor = System.Drawing.Color.Black;
            this.btnNiv11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNiv11.ForeColor = System.Drawing.Color.Lime;
            this.btnNiv11.Location = new System.Drawing.Point(17, 12);
            this.btnNiv11.Name = "btnNiv11";
            this.btnNiv11.Size = new System.Drawing.Size(201, 44);
            this.btnNiv11.TabIndex = 0;
            this.btnNiv11.Text = "Nivel 1";
            this.btnNiv11.UseVisualStyleBackColor = false;
            this.btnNiv11.Click += new System.EventHandler(this.btnNiv11_Click);
            // 
            // btnN11
            // 
            this.btnN11.Location = new System.Drawing.Point(0, 0);
            this.btnN11.Name = "btnN11";
            this.btnN11.Size = new System.Drawing.Size(75, 23);
            this.btnN11.TabIndex = 0;
            // 
            // btnN21
            // 
            this.btnN21.Location = new System.Drawing.Point(0, 0);
            this.btnN21.Name = "btnN21";
            this.btnN21.Size = new System.Drawing.Size(75, 23);
            this.btnN21.TabIndex = 0;
            // 
            // btnN31
            // 
            this.btnN31.Location = new System.Drawing.Point(0, 0);
            this.btnN31.Name = "btnN31";
            this.btnN31.Size = new System.Drawing.Size(75, 23);
            this.btnN31.TabIndex = 0;
            // 
            // pnlInstrucciones
            // 
            this.pnlInstrucciones.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlInstrucciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlInstrucciones.BackgroundImage")));
            this.pnlInstrucciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlInstrucciones.Controls.Add(this.btnReturn);
            this.pnlInstrucciones.Controls.Add(this.lbI8);
            this.pnlInstrucciones.Controls.Add(this.lbI7);
            this.pnlInstrucciones.Controls.Add(this.lbI6);
            this.pnlInstrucciones.Controls.Add(this.lbI5);
            this.pnlInstrucciones.Controls.Add(this.lbI4);
            this.pnlInstrucciones.Controls.Add(this.lbI3);
            this.pnlInstrucciones.Controls.Add(this.lbI2);
            this.pnlInstrucciones.Controls.Add(this.lbI1);
            this.pnlInstrucciones.Controls.Add(this.lbInstruccion);
            this.pnlInstrucciones.Location = new System.Drawing.Point(12, 372);
            this.pnlInstrucciones.Name = "pnlInstrucciones";
            this.pnlInstrucciones.Size = new System.Drawing.Size(196, 246);
            this.pnlInstrucciones.TabIndex = 10;
            this.pnlInstrucciones.Visible = false;
            this.pnlInstrucciones.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInstrucciones_Paint);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Yellow;
            this.btnReturn.Location = new System.Drawing.Point(350, 6);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(201, 44);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Menú Principal";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lbI8
            // 
            this.lbI8.AutoSize = true;
            this.lbI8.BackColor = System.Drawing.Color.Transparent;
            this.lbI8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbI8.ForeColor = System.Drawing.Color.Yellow;
            this.lbI8.Location = new System.Drawing.Point(14, 254);
            this.lbI8.Name = "lbI8";
            this.lbI8.Size = new System.Drawing.Size(0, 15);
            this.lbI8.TabIndex = 8;
            // 
            // lbI7
            // 
            this.lbI7.AutoSize = true;
            this.lbI7.BackColor = System.Drawing.Color.Transparent;
            this.lbI7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbI7.ForeColor = System.Drawing.Color.Yellow;
            this.lbI7.Location = new System.Drawing.Point(17, 199);
            this.lbI7.Name = "lbI7";
            this.lbI7.Size = new System.Drawing.Size(0, 15);
            this.lbI7.TabIndex = 7;
            // 
            // lbI6
            // 
            this.lbI6.AutoSize = true;
            this.lbI6.BackColor = System.Drawing.Color.Transparent;
            this.lbI6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbI6.ForeColor = System.Drawing.Color.Yellow;
            this.lbI6.Location = new System.Drawing.Point(17, 281);
            this.lbI6.Name = "lbI6";
            this.lbI6.Size = new System.Drawing.Size(0, 15);
            this.lbI6.TabIndex = 6;
            // 
            // lbI5
            // 
            this.lbI5.AutoSize = true;
            this.lbI5.BackColor = System.Drawing.Color.Transparent;
            this.lbI5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbI5.ForeColor = System.Drawing.Color.Yellow;
            this.lbI5.Location = new System.Drawing.Point(17, 228);
            this.lbI5.Name = "lbI5";
            this.lbI5.Size = new System.Drawing.Size(0, 15);
            this.lbI5.TabIndex = 5;
            // 
            // lbI4
            // 
            this.lbI4.AutoSize = true;
            this.lbI4.BackColor = System.Drawing.Color.Transparent;
            this.lbI4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbI4.ForeColor = System.Drawing.Color.Yellow;
            this.lbI4.Location = new System.Drawing.Point(17, 173);
            this.lbI4.Name = "lbI4";
            this.lbI4.Size = new System.Drawing.Size(0, 15);
            this.lbI4.TabIndex = 4;
            // 
            // lbI3
            // 
            this.lbI3.AutoSize = true;
            this.lbI3.BackColor = System.Drawing.Color.Transparent;
            this.lbI3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbI3.ForeColor = System.Drawing.Color.Yellow;
            this.lbI3.Location = new System.Drawing.Point(17, 145);
            this.lbI3.Name = "lbI3";
            this.lbI3.Size = new System.Drawing.Size(0, 15);
            this.lbI3.TabIndex = 3;
            // 
            // lbI2
            // 
            this.lbI2.AutoSize = true;
            this.lbI2.BackColor = System.Drawing.Color.Transparent;
            this.lbI2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbI2.ForeColor = System.Drawing.Color.Yellow;
            this.lbI2.Location = new System.Drawing.Point(17, 116);
            this.lbI2.Name = "lbI2";
            this.lbI2.Size = new System.Drawing.Size(0, 15);
            this.lbI2.TabIndex = 2;
            // 
            // lbI1
            // 
            this.lbI1.AutoSize = true;
            this.lbI1.BackColor = System.Drawing.Color.Transparent;
            this.lbI1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbI1.ForeColor = System.Drawing.Color.Yellow;
            this.lbI1.Location = new System.Drawing.Point(17, 87);
            this.lbI1.Name = "lbI1";
            this.lbI1.Size = new System.Drawing.Size(0, 15);
            this.lbI1.TabIndex = 1;
            // 
            // lbInstruccion
            // 
            this.lbInstruccion.AutoSize = true;
            this.lbInstruccion.BackColor = System.Drawing.Color.Transparent;
            this.lbInstruccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstruccion.ForeColor = System.Drawing.Color.Yellow;
            this.lbInstruccion.Location = new System.Drawing.Point(17, 52);
            this.lbInstruccion.Name = "lbInstruccion";
            this.lbInstruccion.Size = new System.Drawing.Size(0, 15);
            this.lbInstruccion.TabIndex = 0;
            // 
            // pnlMnu1
            // 
            this.pnlMnu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMnu1.BackgroundImage")));
            this.pnlMnu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMnu1.Controls.Add(this.btnNpartida);
            this.pnlMnu1.Controls.Add(this.btnInstruciones);
            this.pnlMnu1.Location = new System.Drawing.Point(12, 12);
            this.pnlMnu1.Name = "pnlMnu1";
            this.pnlMnu1.Size = new System.Drawing.Size(265, 117);
            this.pnlMnu1.TabIndex = 11;
            // 
            // btnRegresarMenu
            // 
            this.btnRegresarMenu.BackColor = System.Drawing.Color.Orange;
            this.btnRegresarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarMenu.Location = new System.Drawing.Point(839, 440);
            this.btnRegresarMenu.Name = "btnRegresarMenu";
            this.btnRegresarMenu.Size = new System.Drawing.Size(133, 23);
            this.btnRegresarMenu.TabIndex = 12;
            this.btnRegresarMenu.Text = "Regresar al menu";
            this.btnRegresarMenu.UseVisualStyleBackColor = false;
            this.btnRegresarMenu.Click += new System.EventHandler(this.btnRegresarMenu_Click);
            // 
            // btnTomarAcompanante
            // 
            this.btnTomarAcompanante.BackColor = System.Drawing.Color.SpringGreen;
            this.btnTomarAcompanante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTomarAcompanante.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTomarAcompanante.Location = new System.Drawing.Point(698, 396);
            this.btnTomarAcompanante.Name = "btnTomarAcompanante";
            this.btnTomarAcompanante.Size = new System.Drawing.Size(134, 23);
            this.btnTomarAcompanante.TabIndex = 13;
            this.btnTomarAcompanante.Text = "Tomar Acompanante";
            this.btnTomarAcompanante.UseVisualStyleBackColor = false;
            this.btnTomarAcompanante.Click += new System.EventHandler(this.btnTomarAcompanante_Click);
            // 
            // btnSoltarAcompanante
            // 
            this.btnSoltarAcompanante.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSoltarAcompanante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoltarAcompanante.ForeColor = System.Drawing.Color.Crimson;
            this.btnSoltarAcompanante.Location = new System.Drawing.Point(838, 396);
            this.btnSoltarAcompanante.Name = "btnSoltarAcompanante";
            this.btnSoltarAcompanante.Size = new System.Drawing.Size(134, 23);
            this.btnSoltarAcompanante.TabIndex = 14;
            this.btnSoltarAcompanante.Text = "Soltar Acompanante";
            this.btnSoltarAcompanante.UseVisualStyleBackColor = false;
            this.btnSoltarAcompanante.Click += new System.EventHandler(this.btnSoltarAcompanante_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(731, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Acompanante:";
            // 
            // lblAcompanante
            // 
            this.lblAcompanante.AutoSize = true;
            this.lblAcompanante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcompanante.Location = new System.Drawing.Point(859, 94);
            this.lblAcompanante.Name = "lblAcompanante";
            this.lblAcompanante.Size = new System.Drawing.Size(65, 16);
            this.lblAcompanante.TabIndex = 16;
            this.lblAcompanante.Text = "Ninguno";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTiempo.Location = new System.Drawing.Point(918, 13);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(19, 20);
            this.lblTiempo.TabIndex = 17;
            this.lblTiempo.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(820, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tiempo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // timerTiempo
            // 
            this.timerTiempo.Interval = 1000;
            this.timerTiempo.Tick += new System.EventHandler(this.timerTiempo_Tick);
            // 
            // CrossRoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1102, 556);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblAcompanante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSoltarAcompanante);
            this.Controls.Add(this.btnTomarAcompanante);
            this.Controls.Add(this.btnRegresarMenu);
            this.Controls.Add(this.pnlMnu1);
            this.Controls.Add(this.pnlModo);
            this.Controls.Add(this.pnlNivel1);
            this.Controls.Add(this.pnlInstrucciones);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.mensaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.punteo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.KeyPreview = true;
            this.Name = "CrossRoad";
            this.Text = "CrossRoad";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CrossRoad_KeyUp);
            this.pnlModo.ResumeLayout(false);
            this.pnlModo.PerformLayout();
            this.pnlNivel1.ResumeLayout(false);
            this.pnlInstrucciones.ResumeLayout(false);
            this.pnlInstrucciones.PerformLayout();
            this.pnlMnu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Timer timerCarro1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label punteo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mensaje;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Button btnNpartida;
        private System.Windows.Forms.Button btnInstruciones;
        private System.Windows.Forms.Panel pnlModo;
        private System.Windows.Forms.Label lbModo;
        private System.Windows.Forms.Button btnModo3;
        private System.Windows.Forms.Button btnModo2;
        private System.Windows.Forms.Button btnModo1;
        private System.Windows.Forms.Button btnN31;
        private System.Windows.Forms.Button btnN21;
        private System.Windows.Forms.Button btnN11;
        private System.Windows.Forms.Panel pnlNivel1;
        private System.Windows.Forms.Button btnNiv11;
        private System.Windows.Forms.Button btnNiv31;
        private System.Windows.Forms.Button btnNiv21;
        private System.Windows.Forms.Panel pnlInstrucciones;
        private System.Windows.Forms.Label lbInstruccion;
        private System.Windows.Forms.Label lbI1;
        private System.Windows.Forms.Label lbI2;
        private System.Windows.Forms.Label lbI3;
        private System.Windows.Forms.Label lbI4;
        private System.Windows.Forms.Label lbI5;
        private System.Windows.Forms.Label lbI6;
        private System.Windows.Forms.Label lbI7;
        private System.Windows.Forms.Label lbI8;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlMnu1;
        private System.Windows.Forms.Button btnRegresarMenu;
        private System.Windows.Forms.Button btnTomarAcompanante;
        private System.Windows.Forms.Button btnSoltarAcompanante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAcompanante;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerTiempo;



    }
}

