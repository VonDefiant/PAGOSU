namespace programa_mamalon_de_pagos
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            CONTRASEÑABOX = new TextBox();
            BONTONINGRESO = new Button();
            label1 = new Label();
            label2 = new Label();
            USERBOX = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            Fredyfasber_studios = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CONTRASEÑABOX
            // 
            CONTRASEÑABOX.Location = new Point(263, 223);
            CONTRASEÑABOX.Margin = new Padding(3, 2, 3, 2);
            CONTRASEÑABOX.Name = "CONTRASEÑABOX";
            CONTRASEÑABOX.Size = new Size(196, 23);
            CONTRASEÑABOX.TabIndex = 0;
            CONTRASEÑABOX.TextChanged += textBox1_TextChanged;
            // 
            // BONTONINGRESO
            // 
            BONTONINGRESO.BackColor = SystemColors.Highlight;
            BONTONINGRESO.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BONTONINGRESO.ForeColor = SystemColors.ButtonFace;
            BONTONINGRESO.Location = new Point(302, 268);
            BONTONINGRESO.Margin = new Padding(3, 2, 3, 2);
            BONTONINGRESO.Name = "BONTONINGRESO";
            BONTONINGRESO.Size = new Size(117, 35);
            BONTONINGRESO.TabIndex = 1;
            BONTONINGRESO.Text = "INGRESAR";
            BONTONINGRESO.UseVisualStyleBackColor = false;
            BONTONINGRESO.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(270, 192);
            label1.Name = "label1";
            label1.Size = new Size(159, 30);
            label1.TabIndex = 2;
            label1.Text = "CONTRASEÑA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(303, 139);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 3;
            label2.Text = "USUARIO";
            label2.Click += label2_Click;
            // 
            // USERBOX
            // 
            USERBOX.Location = new Point(263, 170);
            USERBOX.Margin = new Padding(3, 2, 3, 2);
            USERBOX.Name = "USERBOX";
            USERBOX.Size = new Size(196, 23);
            USERBOX.TabIndex = 4;
            USERBOX.TextChanged += USERBOX_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.imagenlogin;
            pictureBox1.Location = new Point(292, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(Fredyfasber_studios);
            panel1.Controls.Add(BONTONINGRESO);
            panel1.Location = new Point(1, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 337);
            panel1.TabIndex = 6;
            // 
            // Fredyfasber_studios
            // 
            Fredyfasber_studios.AutoSize = true;
            Fredyfasber_studios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Fredyfasber_studios.ForeColor = SystemColors.Control;
            Fredyfasber_studios.Location = new Point(0, 322);
            Fredyfasber_studios.Name = "Fredyfasber_studios";
            Fredyfasber_studios.Size = new Size(117, 15);
            Fredyfasber_studios.TabIndex = 2;
            Fredyfasber_studios.Text = "Fredyfasber_studios";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(700, 338);
            Controls.Add(pictureBox1);
            Controls.Add(USERBOX);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CONTRASEÑABOX);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "LOGIN";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CONTRASEÑABOX;
        private Button BONTONINGRESO;
        private Label label1;
        private Label label2;
        private TextBox USERBOX;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label Fredyfasber_studios;
    }
}