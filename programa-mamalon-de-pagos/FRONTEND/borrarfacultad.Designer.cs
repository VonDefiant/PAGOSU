namespace programa_mamalon_de_pagos.FRONTEND
{
    partial class borrarfacultad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borrarfacultad));
            label1 = new Label();
            label2 = new Label();
            deletebt = new Button();
            pictureBox1 = new PictureBox();
            TXTBOX = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 119);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 13;
            label1.Text = "INGRESE LA ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 134);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 17;
            label2.Text = "DE LA FACULTAD";
            // 
            // deletebt
            // 
            deletebt.BackColor = Color.Wheat;
            deletebt.BackgroundImage = Properties.Resources.borrar;
            deletebt.BackgroundImageLayout = ImageLayout.Zoom;
            deletebt.Location = new Point(160, 148);
            deletebt.Name = "deletebt";
            deletebt.Size = new Size(88, 86);
            deletebt.TabIndex = 16;
            deletebt.UseVisualStyleBackColor = false;
            deletebt.Click += deletebt_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.facultad;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(134, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 86);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // TXTBOX
            // 
            TXTBOX.Location = new Point(115, 119);
            TXTBOX.Name = "TXTBOX";
            TXTBOX.Size = new Size(198, 23);
            TXTBOX.TabIndex = 14;
            TXTBOX.TextChanged += TXTBOX_TextChanged;
            // 
            // borrarfacultad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(356, 274);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(deletebt);
            Controls.Add(pictureBox1);
            Controls.Add(TXTBOX);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "borrarfacultad";
            Text = "borrarfacultad";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button deletebt;
        private PictureBox pictureBox1;
        private TextBox TXTBOX;
    }
}