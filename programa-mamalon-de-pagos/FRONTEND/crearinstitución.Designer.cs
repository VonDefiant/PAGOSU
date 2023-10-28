namespace programa_mamalon_de_pagos.FRONTEND
{
    partial class crearinstitución
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crearinstitución));
            pictureBox1 = new PictureBox();
            txnombre = new TextBox();
            label1 = new Label();
            savebutton = new Button();
            label2 = new Label();
            dbginstitucion = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbginstitucion).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.institucion;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(172, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 102);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txnombre
            // 
            txnombre.Location = new Point(32, 154);
            txnombre.Name = "txnombre";
            txnombre.Size = new Size(409, 27);
            txnombre.TabIndex = 1;
            txnombre.TextChanged += txnombre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 117);
            label1.Name = "label1";
            label1.Size = new Size(384, 25);
            label1.TabIndex = 2;
            label1.Text = "INGRESE EL NOMBRE DE LA INSTITUCION";
            // 
            // savebutton
            // 
            savebutton.BackColor = Color.Wheat;
            savebutton.BackgroundImage = Properties.Resources.salvar;
            savebutton.BackgroundImageLayout = ImageLayout.Zoom;
            savebutton.Location = new Point(207, 187);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(73, 57);
            savebutton.TabIndex = 3;
            savebutton.UseVisualStyleBackColor = false;
            savebutton.Click += savebutton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(190, 247);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 4;
            label2.Text = "GUARDAR";
            // 
            // dbginstitucion
            // 
            dbginstitucion.BackgroundColor = SystemColors.Control;
            dbginstitucion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbginstitucion.GridColor = SystemColors.ButtonHighlight;
            dbginstitucion.Location = new Point(12, 289);
            dbginstitucion.Name = "dbginstitucion";
            dbginstitucion.RowHeadersWidth = 51;
            dbginstitucion.RowTemplate.Height = 29;
            dbginstitucion.Size = new Size(445, 312);
            dbginstitucion.TabIndex = 5;
            dbginstitucion.CellContentClick += dbginstitucion_CellContentClick;
            // 
            // crearinstitución
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(469, 616);
            Controls.Add(dbginstitucion);
            Controls.Add(label2);
            Controls.Add(savebutton);
            Controls.Add(label1);
            Controls.Add(txnombre);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "crearinstitución";
            Text = "Creación de instituciones";
            Load += crearinstitución_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbginstitucion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txnombre;
        private Label label1;
        private Button savebutton;
        private Label label2;
        private DataGridView dbginstitucion;
    }
}