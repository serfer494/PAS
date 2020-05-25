namespace Ingeneria_Software
{
    partial class BDRespaldo
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnDia = new System.Windows.Forms.RadioButton();
            this.rbtnSemana = new System.Windows.Forms.RadioButton();
            this.rbtnMes = new System.Windows.Forms.RadioButton();
            this.btnProgramar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 33);
            this.label2.TabIndex = 25;
            this.label2.Text = "Respaldar BD";
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.Teal;
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(12, 72);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(101, 30);
            this.btnBackup.TabIndex = 26;
            this.btnBackup.Text = "Respaldar";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.Color.Teal;
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.ForeColor = System.Drawing.Color.White;
            this.btnRestaurar.Location = new System.Drawing.Point(262, 72);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(101, 30);
            this.btnRestaurar.TabIndex = 27;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnMes);
            this.groupBox1.Controls.Add(this.rbtnSemana);
            this.groupBox1.Controls.Add(this.rbtnDia);
            this.groupBox1.Location = new System.Drawing.Point(13, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 82);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Respaldar base de datos cada:";
            // 
            // rbtnDia
            // 
            this.rbtnDia.AutoSize = true;
            this.rbtnDia.Location = new System.Drawing.Point(6, 34);
            this.rbtnDia.Name = "rbtnDia";
            this.rbtnDia.Size = new System.Drawing.Size(41, 17);
            this.rbtnDia.TabIndex = 0;
            this.rbtnDia.TabStop = true;
            this.rbtnDia.Text = "Dia";
            this.rbtnDia.UseVisualStyleBackColor = true;
            // 
            // rbtnSemana
            // 
            this.rbtnSemana.AutoSize = true;
            this.rbtnSemana.Location = new System.Drawing.Point(141, 34);
            this.rbtnSemana.Name = "rbtnSemana";
            this.rbtnSemana.Size = new System.Drawing.Size(64, 17);
            this.rbtnSemana.TabIndex = 1;
            this.rbtnSemana.TabStop = true;
            this.rbtnSemana.Text = "Semana";
            this.rbtnSemana.UseVisualStyleBackColor = true;
            // 
            // rbtnMes
            // 
            this.rbtnMes.AutoSize = true;
            this.rbtnMes.Location = new System.Drawing.Point(299, 34);
            this.rbtnMes.Name = "rbtnMes";
            this.rbtnMes.Size = new System.Drawing.Size(45, 17);
            this.rbtnMes.TabIndex = 2;
            this.rbtnMes.TabStop = true;
            this.rbtnMes.Text = "Mes";
            this.rbtnMes.UseVisualStyleBackColor = true;
            // 
            // btnProgramar
            // 
            this.btnProgramar.BackColor = System.Drawing.Color.Teal;
            this.btnProgramar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProgramar.FlatAppearance.BorderSize = 0;
            this.btnProgramar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnProgramar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgramar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgramar.ForeColor = System.Drawing.Color.White;
            this.btnProgramar.Location = new System.Drawing.Point(126, 211);
            this.btnProgramar.Name = "btnProgramar";
            this.btnProgramar.Size = new System.Drawing.Size(125, 55);
            this.btnProgramar.TabIndex = 29;
            this.btnProgramar.Text = "Programar respaldo";
            this.btnProgramar.UseVisualStyleBackColor = false;
            this.btnProgramar.Click += new System.EventHandler(this.btnProgramar_Click);
            // 
            // BDRespaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 339);
            this.Controls.Add(this.btnProgramar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.label2);
            this.Name = "BDRespaldo";
            this.Text = "Respaldo de Base de Datos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnMes;
        private System.Windows.Forms.RadioButton rbtnSemana;
        private System.Windows.Forms.RadioButton rbtnDia;
        private System.Windows.Forms.Button btnProgramar;
    }
}