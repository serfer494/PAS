﻿namespace Ingeneria_Software
{
    partial class DatosxCita
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrasaPorc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGrasaVis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMusculoPorc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCirCad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCMB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBodyAge = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCirCin = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 45;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(74, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 47;
            this.label2.Text = "Peso:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(150, 81);
            this.txtPeso.MaxLength = 5;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(75, 20);
            this.txtPeso.TabIndex = 46;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(43, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 51;
            this.label3.Text = "% Grasa:";
            // 
            // txtGrasaPorc
            // 
            this.txtGrasaPorc.Location = new System.Drawing.Point(150, 155);
            this.txtGrasaPorc.MaxLength = 3;
            this.txtGrasaPorc.Name = "txtGrasaPorc";
            this.txtGrasaPorc.Size = new System.Drawing.Size(75, 20);
            this.txtGrasaPorc.TabIndex = 50;
            this.txtGrasaPorc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrasaPorc_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(83, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 49;
            this.label4.Text = "IMC:";
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(150, 115);
            this.txtIMC.MaxLength = 5;
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(75, 20);
            this.txtIMC.TabIndex = 48;
            this.txtIMC.TextChanged += new System.EventHandler(this.newIMC_TextChanged);
            this.txtIMC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIMC_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(25, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Grasa Visceral:";
            // 
            // txtGrasaVis
            // 
            this.txtGrasaVis.Location = new System.Drawing.Point(166, 240);
            this.txtGrasaVis.MaxLength = 5;
            this.txtGrasaVis.Name = "txtGrasaVis";
            this.txtGrasaVis.Size = new System.Drawing.Size(75, 20);
            this.txtGrasaVis.TabIndex = 54;
            this.txtGrasaVis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrasaVis_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(23, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 53;
            this.label6.Text = "% Músculo:";
            // 
            // txtMusculoPorc
            // 
            this.txtMusculoPorc.Location = new System.Drawing.Point(150, 201);
            this.txtMusculoPorc.MaxLength = 3;
            this.txtMusculoPorc.Name = "txtMusculoPorc";
            this.txtMusculoPorc.Size = new System.Drawing.Size(75, 20);
            this.txtMusculoPorc.TabIndex = 52;
            this.txtMusculoPorc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusculoPorc_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(23, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 22);
            this.label7.TabIndex = 59;
            this.label7.Text = "Cir. cadera";
            // 
            // txtCirCad
            // 
            this.txtCirCad.Location = new System.Drawing.Point(150, 318);
            this.txtCirCad.MaxLength = 5;
            this.txtCirCad.Name = "txtCirCad";
            this.txtCirCad.Size = new System.Drawing.Size(75, 20);
            this.txtCirCad.TabIndex = 58;
            this.txtCirCad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCirCad_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(64, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 22);
            this.label8.TabIndex = 57;
            this.label8.Text = "CMB:";
            // 
            // txtCMB
            // 
            this.txtCMB.Location = new System.Drawing.Point(150, 280);
            this.txtCMB.MaxLength = 5;
            this.txtCMB.Name = "txtCMB";
            this.txtCMB.Size = new System.Drawing.Size(75, 20);
            this.txtCMB.TabIndex = 56;
            this.txtCMB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMB_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(30, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 22);
            this.label9.TabIndex = 63;
            this.label9.Text = "Body Age:";
            // 
            // txtBodyAge
            // 
            this.txtBodyAge.Location = new System.Drawing.Point(150, 399);
            this.txtBodyAge.MaxLength = 3;
            this.txtBodyAge.Name = "txtBodyAge";
            this.txtBodyAge.Size = new System.Drawing.Size(75, 20);
            this.txtBodyAge.TabIndex = 62;
            this.txtBodyAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBodyAge_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(23, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 22);
            this.label10.TabIndex = 61;
            this.label10.Text = "Cir. cintura";
            // 
            // txtCirCin
            // 
            this.txtCirCin.Location = new System.Drawing.Point(150, 357);
            this.txtCirCin.MaxLength = 5;
            this.txtCirCin.Name = "txtCirCin";
            this.txtCirCin.Size = new System.Drawing.Size(75, 20);
            this.txtCirCin.TabIndex = 60;
            this.txtCirCin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCirCin_KeyPress);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(89, 46);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(211, 20);
            this.dtpFecha.TabIndex = 64;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Teal;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(65, 457);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(160, 40);
            this.btnCrear.TabIndex = 65;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Teal;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(338, 464);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 33);
            this.btnModificar.TabIndex = 89;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Teal;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(338, 357);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 33);
            this.btnEliminar.TabIndex = 90;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(338, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(524, 292);
            this.dataGridView1.TabIndex = 91;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.DarkRed;
            this.label23.Location = new System.Drawing.Point(51, 81);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(17, 24);
            this.label23.TabIndex = 97;
            this.label23.Text = "*";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.DarkRed;
            this.label24.Location = new System.Drawing.Point(12, 395);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(17, 24);
            this.label24.TabIndex = 98;
            this.label24.Text = "*";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.DarkRed;
            this.label25.Location = new System.Drawing.Point(9, 356);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(17, 24);
            this.label25.TabIndex = 99;
            this.label25.Text = "*";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.DarkRed;
            this.label26.Location = new System.Drawing.Point(9, 312);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(17, 24);
            this.label26.TabIndex = 100;
            this.label26.Text = "*";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.DarkRed;
            this.label27.Location = new System.Drawing.Point(43, 276);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(17, 24);
            this.label27.TabIndex = 101;
            this.label27.Text = "*";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.DarkRed;
            this.label28.Location = new System.Drawing.Point(2, 238);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(17, 24);
            this.label28.TabIndex = 102;
            this.label28.Text = "*";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.DarkRed;
            this.label29.Location = new System.Drawing.Point(9, 196);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(17, 24);
            this.label29.TabIndex = 103;
            this.label29.Text = "*";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.DarkRed;
            this.label30.Location = new System.Drawing.Point(20, 153);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(17, 24);
            this.label30.TabIndex = 104;
            this.label30.Text = "*";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.DarkRed;
            this.label31.Location = new System.Drawing.Point(51, 115);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(17, 24);
            this.label31.TabIndex = 105;
            this.label31.Text = "*";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.DarkRed;
            this.label35.Location = new System.Drawing.Point(2, 43);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(17, 24);
            this.label35.TabIndex = 109;
            this.label35.Text = "*";
            // 
            // DatosxCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 544);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBodyAge);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCirCin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCirCad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCMB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGrasaVis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMusculoPorc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGrasaPorc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatosxCita";
            this.Text = "Datos Antropometricos";
            this.Load += new System.EventHandler(this.DatosxCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGrasaPorc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGrasaVis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMusculoPorc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCirCad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCMB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBodyAge;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCirCin;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label35;
    }
}