namespace Ingeneria_Software
{
    partial class MenuPpal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPpal));
            this.Barra = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bases = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.alimentos = new System.Windows.Forms.Button();
            this.Comidas = new System.Windows.Forms.Button();
            this.agenda = new System.Windows.Forms.Button();
            this.cont = new System.Windows.Forms.Panel();
            this.Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Bases.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Barra
            // 
            this.Barra.BackColor = System.Drawing.Color.SteelBlue;
            this.Barra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Barra.Controls.Add(this.pictureBox2);
            this.Barra.Controls.Add(this.pictureBox1);
            this.Barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra.Location = new System.Drawing.Point(0, 0);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(1100, 40);
            this.Barra.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1019, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 34);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1063, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Bases
            // 
            this.Bases.BackColor = System.Drawing.Color.Teal;
            this.Bases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bases.Controls.Add(this.btnEliminar);
            this.Bases.Controls.Add(this.btnSeleccionar);
            this.Bases.Controls.Add(this.cbxCliente);
            this.Bases.Controls.Add(this.button2);
            this.Bases.Controls.Add(this.label1);
            this.Bases.Controls.Add(this.panel1);
            this.Bases.Controls.Add(this.alimentos);
            this.Bases.Controls.Add(this.Comidas);
            this.Bases.Controls.Add(this.agenda);
            this.Bases.Dock = System.Windows.Forms.DockStyle.Left;
            this.Bases.Location = new System.Drawing.Point(0, 40);
            this.Bases.Name = "Bases";
            this.Bases.Size = new System.Drawing.Size(200, 560);
            this.Bases.TabIndex = 1;
            this.Bases.Paint += new System.Windows.Forms.PaintEventHandler(this.Bases_Paint);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(118, 195);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(72, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(11, 195);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(72, 23);
            this.btnSeleccionar.TabIndex = 8;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.selec_Click);
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(38, 155);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(121, 21);
            this.cbxCliente.TabIndex = 7;
            this.cbxCliente.SelectedIndexChanged += new System.EventHandler(this.cbxCliente_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(38, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "Plan alimenticio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cliente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Cliente);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(11, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 255);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 6;
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.ForeColor = System.Drawing.Color.White;
            this.Cliente.Location = new System.Drawing.Point(56, 11);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(64, 18);
            this.Cliente.TabIndex = 5;
            this.Cliente.Text = "Cliente";
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(1, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 59);
            this.button4.TabIndex = 4;
            this.button4.Text = "Datos Antropometricos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(-1, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 59);
            this.button3.TabIndex = 3;
            this.button3.Text = "Datos Generales";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // alimentos
            // 
            this.alimentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.alimentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alimentos.FlatAppearance.BorderSize = 0;
            this.alimentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.alimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alimentos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alimentos.ForeColor = System.Drawing.Color.Transparent;
            this.alimentos.Location = new System.Drawing.Point(38, 41);
            this.alimentos.Name = "alimentos";
            this.alimentos.Size = new System.Drawing.Size(134, 41);
            this.alimentos.TabIndex = 4;
            this.alimentos.Text = "Alimentos";
            this.alimentos.UseVisualStyleBackColor = true;
            this.alimentos.Click += new System.EventHandler(this.alimentos_Click);
            // 
            // Comidas
            // 
            this.Comidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Comidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Comidas.FlatAppearance.BorderSize = 0;
            this.Comidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.Comidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Comidas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comidas.ForeColor = System.Drawing.Color.Transparent;
            this.Comidas.Location = new System.Drawing.Point(38, 88);
            this.Comidas.Name = "Comidas";
            this.Comidas.Size = new System.Drawing.Size(121, 41);
            this.Comidas.TabIndex = 3;
            this.Comidas.Text = "Comidas";
            this.Comidas.UseVisualStyleBackColor = true;
            this.Comidas.Click += new System.EventHandler(this.Comidas_Click);
            // 
            // agenda
            // 
            this.agenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.agenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agenda.FlatAppearance.BorderSize = 0;
            this.agenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.agenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agenda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agenda.ForeColor = System.Drawing.Color.Transparent;
            this.agenda.Location = new System.Drawing.Point(38, 5);
            this.agenda.Name = "agenda";
            this.agenda.Size = new System.Drawing.Size(121, 30);
            this.agenda.TabIndex = 0;
            this.agenda.Text = "Agenda";
            this.agenda.UseVisualStyleBackColor = true;
            this.agenda.Click += new System.EventHandler(this.agenda_Click);
            // 
            // cont
            // 
            this.cont.Location = new System.Drawing.Point(204, 44);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(884, 544);
            this.cont.TabIndex = 2;
            this.cont.Paint += new System.Windows.Forms.PaintEventHandler(this.cont_Paint);
            // 
            // MenuPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.cont);
            this.Controls.Add(this.Bases);
            this.Controls.Add(this.Barra);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPpal";
            this.Text = "MenuPpal";
            this.Activated += new System.EventHandler(this.MenuPpal_Activated);
            this.Load += new System.EventHandler(this.MenuPpal_Load);
            this.Barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Bases.ResumeLayout(false);
            this.Bases.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Barra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Bases;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button agenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button alimentos;
        private System.Windows.Forms.Button Comidas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel cont;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Cliente;
        public System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
    }
}