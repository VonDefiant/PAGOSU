namespace programa_mamalon_de_pagos.FRONTEND
{
    partial class borrardocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borrardocente));
            label3 = new Label();
            label2 = new Label();
            deletebt = new Button();
            pictureBox1 = new PictureBox();
            TXTBOX = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(85, 9);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 23;
            label3.Text = "INGRESE LA ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(85, 24);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 27;
            label2.Text = "DEL PROFESOR";
            // 
            // deletebt
            // 
            deletebt.BackColor = Color.Wheat;
            deletebt.BackgroundImage = Properties.Resources.borrar;
            deletebt.BackgroundImageLayout = ImageLayout.Zoom;
            deletebt.Location = new Point(99, 166);
            deletebt.Name = "deletebt";
            deletebt.Size = new Size(88, 86);
            deletebt.TabIndex = 26;
            deletebt.UseVisualStyleBackColor = false;
            deletebt.Click += deletebt_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.profesor;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(60, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 89);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // TXTBOX
            // 
            TXTBOX.Location = new Point(21, 137);
            TXTBOX.Name = "TXTBOX";
            TXTBOX.Size = new Size(224, 23);
            TXTBOX.TabIndex = 28;
            TXTBOX.TextChanged += TXTBOX_TextChanged;
            // 
            // borrardocente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(268, 262);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(deletebt);
            Controls.Add(pictureBox1);
            Controls.Add(TXTBOX);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "borrardocente";
            Text = "borrardocente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Button deletebt;
        private PictureBox pictureBox1;
        private TextBox TXTBOX;
    }
}