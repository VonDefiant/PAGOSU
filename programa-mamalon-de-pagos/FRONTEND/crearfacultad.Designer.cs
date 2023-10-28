namespace programa_mamalon_de_pagos.FRONTEND
{
    partial class crearfacultad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crearfacultad));
            label2 = new Label();
            savebutton = new Button();
            label1 = new Label();
            txnombre = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(192, 320);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 9;
            label2.Text = "GUARDAR";
            // 
            // savebutton
            // 
            savebutton.BackColor = Color.Wheat;
            savebutton.BackgroundImage = Properties.Resources.salvar;
            savebutton.BackgroundImageLayout = ImageLayout.Zoom;
            savebutton.Location = new Point(192, 216);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(94, 84);
            savebutton.TabIndex = 8;
            savebutton.UseVisualStyleBackColor = false;
            savebutton.Click += savebutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(60, 135);
            label1.Name = "label1";
            label1.Size = new Size(357, 25);
            label1.TabIndex = 7;
            label1.Text = "INGRESE EL NOMBRE DE LA FACULTAD";
            // 
            // txnombre
            // 
            txnombre.Location = new Point(35, 172);
            txnombre.Name = "txnombre";
            txnombre.Size = new Size(409, 27);
            txnombre.TabIndex = 6;
            txnombre.TextChanged += txnombre_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.facultad;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(175, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 102);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // crearfacultad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(480, 373);
            Controls.Add(label2);
            Controls.Add(savebutton);
            Controls.Add(label1);
            Controls.Add(txnombre);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "crearfacultad";
            Text = "crear_facultad";
            Load += crearfacultad_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button savebutton;
        private Label label1;
        private TextBox txnombre;
        private PictureBox pictureBox1;
    }
}