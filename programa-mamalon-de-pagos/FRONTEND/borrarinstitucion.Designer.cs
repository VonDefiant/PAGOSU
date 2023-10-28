namespace programa_mamalon_de_pagos.FRONTEND
{
    partial class borrarinstitucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borrarinstitucion));
            label2 = new Label();
            deletebt = new Button();
            pictureBox1 = new PictureBox();
            TXTBOX = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(124, 24);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 22;
            label2.Text = "DE LA INSTITUCION";
            // 
            // deletebt
            // 
            deletebt.BackColor = Color.Wheat;
            deletebt.BackgroundImage = Properties.Resources.borrar;
            deletebt.BackgroundImageLayout = ImageLayout.Zoom;
            deletebt.Location = new Point(138, 166);
            deletebt.Name = "deletebt";
            deletebt.Size = new Size(88, 86);
            deletebt.TabIndex = 21;
            deletebt.UseVisualStyleBackColor = false;
            deletebt.Click += deletebt_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.institucion;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(114, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 89);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // TXTBOX
            // 
            TXTBOX.Location = new Point(89, 137);
            TXTBOX.Name = "TXTBOX";
            TXTBOX.Size = new Size(198, 23);
            TXTBOX.TabIndex = 19;
            TXTBOX.TextChanged += TXTBOX_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(138, 9);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 18;
            label3.Text = "INGRESE LA ID";
            // 
            // borrarinstitucion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(345, 264);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(deletebt);
            Controls.Add(pictureBox1);
            Controls.Add(TXTBOX);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "borrarinstitucion";
            Text = "borrarinstitucion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button deletebt;
        private PictureBox pictureBox1;
        private TextBox TXTBOX;
        private Label label3;
    }
}