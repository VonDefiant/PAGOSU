namespace programa_mamalon_de_pagos.FRONTEND
{
    partial class crearcarrera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crearcarrera));
            dgfacultad = new DataGridView();
            label2 = new Label();
            savebutton = new Button();
            label1 = new Label();
            txnombre = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            CbFacultad = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgfacultad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgfacultad
            // 
            dgfacultad.BackgroundColor = SystemColors.Control;
            dgfacultad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgfacultad.Location = new Point(16, 279);
            dgfacultad.Name = "dgfacultad";
            dgfacultad.RowTemplate.Height = 25;
            dgfacultad.Size = new Size(416, 335);
            dgfacultad.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(191, 253);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 15;
            label2.Text = "GUARDAR";
            // 
            // savebutton
            // 
            savebutton.BackColor = Color.Wheat;
            savebutton.BackgroundImage = Properties.Resources.salvar;
            savebutton.BackgroundImageLayout = ImageLayout.Zoom;
            savebutton.Location = new Point(203, 210);
            savebutton.Margin = new Padding(3, 2, 3, 2);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(55, 41);
            savebutton.TabIndex = 14;
            savebutton.UseVisualStyleBackColor = false;
            savebutton.Click += savebutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(96, 89);
            label1.Name = "label1";
            label1.Size = new Size(279, 20);
            label1.TabIndex = 13;
            label1.Text = "INGRESE EL NOMBRE DE LA CARRERA";
            // 
            // txnombre
            // 
            txnombre.Location = new Point(54, 111);
            txnombre.Margin = new Padding(3, 2, 3, 2);
            txnombre.Name = "txnombre";
            txnombre.Size = new Size(358, 23);
            txnombre.TabIndex = 12;
            txnombre.TextChanged += txnombre_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.carrera_profesional;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(170, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 76);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(96, 149);
            label3.Name = "label3";
            label3.Size = new Size(285, 20);
            label3.TabIndex = 19;
            label3.Text = "INGRESE EL NOMBRE DE LA FACULTAD";
            // 
            // CbFacultad
            // 
            CbFacultad.FormattingEnabled = true;
            CbFacultad.Location = new Point(54, 172);
            CbFacultad.Name = "CbFacultad";
            CbFacultad.Size = new Size(358, 23);
            CbFacultad.TabIndex = 21;
            CbFacultad.SelectedIndexChanged += CbFacultad_SelectedIndexChanged;
            // 
            // crearcarrera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(444, 626);
            Controls.Add(CbFacultad);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(dgfacultad);
            Controls.Add(label2);
            Controls.Add(savebutton);
            Controls.Add(label1);
            Controls.Add(txnombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "crearcarrera";
            Text = "crearcarrera";
            Load += crear_carrera_Load;
            ((System.ComponentModel.ISupportInitialize)dgfacultad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgfacultad;
        private Label label2;
        private Button savebutton;
        private Label label1;
        private TextBox txnombre;
        private PictureBox pictureBox1;
        private Label label3;
        private ComboBox CbFacultad;
    }
}