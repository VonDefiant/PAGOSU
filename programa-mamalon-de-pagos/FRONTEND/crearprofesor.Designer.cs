namespace programa_mamalon_de_pagos.FRONTEND
{
    partial class crearprofesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crearprofesor));
            savebutton = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label10 = new Label();
            label11 = new Label();
            DIRECPROF = new TextBox();
            EMAILPROF = new TextBox();
            TELEFONOPROF = new TextBox();
            NOMBREPROF = new TextBox();
            CLBCURSOS = new CheckedListBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // savebutton
            // 
            savebutton.BackColor = Color.Wheat;
            savebutton.BackgroundImage = Properties.Resources.salvar;
            savebutton.BackgroundImageLayout = ImageLayout.Zoom;
            savebutton.Location = new Point(650, 59);
            savebutton.Margin = new Padding(3, 2, 3, 2);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(110, 72);
            savebutton.TabIndex = 24;
            savebutton.UseVisualStyleBackColor = false;
            savebutton.Click += savebutton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(662, 137);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 25;
            label2.Text = "GUARDAR";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.profesor;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 164);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(140, 113);
            label5.Name = "label5";
            label5.Size = new Size(160, 19);
            label5.TabIndex = 43;
            label5.Text = "DIRECCION COMPLETA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(662, 11);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 42;
            label4.Text = "TELEFONO";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(140, 57);
            label10.Name = "label10";
            label10.Size = new Size(265, 19);
            label10.TabIndex = 40;
            label10.Text = "CORREO ELECTRONICO DEL PROFESOR";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(140, 11);
            label11.Name = "label11";
            label11.Size = new Size(250, 19);
            label11.TabIndex = 39;
            label11.Text = "NOMBRE COMPLETO DEL PROFESOR";
            // 
            // DIRECPROF
            // 
            DIRECPROF.ForeColor = SystemColors.InfoText;
            DIRECPROF.Location = new Point(140, 134);
            DIRECPROF.Margin = new Padding(3, 2, 3, 2);
            DIRECPROF.Name = "DIRECPROF";
            DIRECPROF.Size = new Size(504, 23);
            DIRECPROF.TabIndex = 33;
            DIRECPROF.TextAlign = HorizontalAlignment.Center;
            DIRECPROF.TextChanged += DIRECPROF_TextChanged;
            // 
            // EMAILPROF
            // 
            EMAILPROF.CharacterCasing = CharacterCasing.Upper;
            EMAILPROF.ForeColor = SystemColors.InfoText;
            EMAILPROF.Location = new Point(140, 78);
            EMAILPROF.Margin = new Padding(3, 2, 3, 2);
            EMAILPROF.Name = "EMAILPROF";
            EMAILPROF.Size = new Size(504, 23);
            EMAILPROF.TabIndex = 32;
            EMAILPROF.TextAlign = HorizontalAlignment.Center;
            EMAILPROF.TextChanged += EMAILPROF_TextChanged;
            // 
            // TELEFONOPROF
            // 
            TELEFONOPROF.ForeColor = SystemColors.InfoText;
            TELEFONOPROF.Location = new Point(650, 32);
            TELEFONOPROF.Margin = new Padding(3, 2, 3, 2);
            TELEFONOPROF.Name = "TELEFONOPROF";
            TELEFONOPROF.Size = new Size(110, 23);
            TELEFONOPROF.TabIndex = 31;
            TELEFONOPROF.TextAlign = HorizontalAlignment.Center;
            TELEFONOPROF.TextChanged += TELEFONOPROF_TextChanged;
            // 
            // NOMBREPROF
            // 
            NOMBREPROF.ForeColor = SystemColors.InfoText;
            NOMBREPROF.Location = new Point(140, 32);
            NOMBREPROF.Margin = new Padding(3, 2, 3, 2);
            NOMBREPROF.Name = "NOMBREPROF";
            NOMBREPROF.Size = new Size(504, 23);
            NOMBREPROF.TabIndex = 30;
            NOMBREPROF.TextAlign = HorizontalAlignment.Center;
            NOMBREPROF.TextChanged += NOMBREPROF_TextChanged;
            // 
            // CLBCURSOS
            // 
            CLBCURSOS.FormattingEnabled = true;
            CLBCURSOS.Location = new Point(12, 184);
            CLBCURSOS.Name = "CLBCURSOS";
            CLBCURSOS.Size = new Size(776, 148);
            CLBCURSOS.TabIndex = 48;
            CLBCURSOS.SelectedIndexChanged += CLBCURSOS_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(150, 162);
            label1.Name = "label1";
            label1.Size = new Size(244, 19);
            label1.TabIndex = 49;
            label1.Text = "MARQUE LOS CURSOS ASIGANDOS";
            // 
            // crearprofesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 344);
            Controls.Add(label1);
            Controls.Add(CLBCURSOS);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(DIRECPROF);
            Controls.Add(EMAILPROF);
            Controls.Add(TELEFONOPROF);
            Controls.Add(NOMBREPROF);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(savebutton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "crearprofesor";
            Text = "crearprofesor";
            Load += crearprofesor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button savebutton;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label10;
        private Label label11;
        private TextBox DIRECPROF;
        private TextBox EMAILPROF;
        private TextBox TELEFONOPROF;
        private TextBox NOMBREPROF;
        private CheckedListBox CLBCURSOS;
        private Label label1;
    }
}