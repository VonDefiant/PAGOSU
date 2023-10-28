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
            dgfacultad = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgfacultad).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(168, 240);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 9;
            label2.Text = "GUARDAR";
            // 
            // savebutton
            // 
            savebutton.BackColor = Color.Wheat;
            savebutton.BackgroundImage = Properties.Resources.salvar;
            savebutton.BackgroundImageLayout = ImageLayout.Zoom;
            savebutton.Location = new Point(168, 162);
            savebutton.Margin = new Padding(3, 2, 3, 2);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(82, 63);
            savebutton.TabIndex = 8;
            savebutton.UseVisualStyleBackColor = false;
            savebutton.Click += savebutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 101);
            label1.Name = "label1";
            label1.Size = new Size(285, 20);
            label1.TabIndex = 7;
            label1.Text = "INGRESE EL NOMBRE DE LA FACULTAD";
            // 
            // txnombre
            // 
            txnombre.Location = new Point(31, 129);
            txnombre.Margin = new Padding(3, 2, 3, 2);
            txnombre.Name = "txnombre";
            txnombre.Size = new Size(358, 23);
            txnombre.TabIndex = 6;
            txnombre.TextChanged += txnombre_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.facultad;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(153, 22);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 76);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // dgfacultad
            // 
            dgfacultad.BackgroundColor = SystemColors.Control;
            dgfacultad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgfacultad.Location = new Point(12, 274);
            dgfacultad.Name = "dgfacultad";
            dgfacultad.RowTemplate.Height = 25;
            dgfacultad.Size = new Size(396, 255);
            dgfacultad.TabIndex = 10;
            dgfacultad.CellContentClick += dgfacultad_CellContentClick;
            // 
            // crearfacultad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(420, 541);
            Controls.Add(dgfacultad);
            Controls.Add(label2);
            Controls.Add(savebutton);
            Controls.Add(label1);
            Controls.Add(txnombre);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "crearfacultad";
            Text = "crear_facultad";
            Load += crearfacultad_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgfacultad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button savebutton;
        private Label label1;
        private TextBox txnombre;
        private PictureBox pictureBox1;
        private DataGridView dgfacultad;
    }
}