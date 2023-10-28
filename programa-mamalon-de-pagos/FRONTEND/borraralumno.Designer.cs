namespace programa_mamalon_de_pagos.FRONTEND
{
    partial class borraralumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borraralumno));
            deletebt = new Button();
            pictureBox1 = new PictureBox();
            txtcarnet = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // deletebt
            // 
            deletebt.BackColor = Color.Wheat;
            deletebt.BackgroundImage = Properties.Resources.borrar;
            deletebt.BackgroundImageLayout = ImageLayout.Zoom;
            deletebt.Location = new Point(139, 150);
            deletebt.Name = "deletebt";
            deletebt.Size = new Size(88, 86);
            deletebt.TabIndex = 7;
            deletebt.UseVisualStyleBackColor = false;
            deletebt.Click += deletebt_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.alumno;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(113, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 86);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // txtcarnet
            // 
            txtcarnet.Location = new Point(139, 121);
            txtcarnet.Name = "txtcarnet";
            txtcarnet.Size = new Size(198, 23);
            txtcarnet.TabIndex = 5;
            txtcarnet.TextChanged += txtcurso_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 124);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 4;
            label1.Text = "INGRESE EL CARNET:";
            // 
            // borraralumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(355, 252);
            Controls.Add(deletebt);
            Controls.Add(pictureBox1);
            Controls.Add(txtcarnet);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "borraralumno";
            Text = "borraralumno";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deletebt;
        private PictureBox pictureBox1;
        private TextBox txtcarnet;
        private Label label1;
    }
}