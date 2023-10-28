namespace programa_mamalon_de_pagos.FRONTEND
{
    partial class reportesporalumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportesporalumno));
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            TXTCARNE = new TextBox();
            BTNVerificarCarnet = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(206, 15);
            label1.TabIndex = 0;
            label1.Text = "INGRESE EL CARNET DEL ESTUDIANTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 85);
            label2.Name = "label2";
            label2.Size = new Size(206, 15);
            label2.TabIndex = 1;
            label2.Text = "INGRESE EL CARNET DEL ESTUDIANTE";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(763, 317);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TXTCARNE
            // 
            TXTCARNE.Location = new Point(25, 48);
            TXTCARNE.Name = "TXTCARNE";
            TXTCARNE.Size = new Size(206, 23);
            TXTCARNE.TabIndex = 3;
            TXTCARNE.TextChanged += TXTCARNE_TextChanged;
            // 
            // BTNVerificarCarnet
            // 
            BTNVerificarCarnet.BackColor = Color.Wheat;
            BTNVerificarCarnet.BackgroundImage = Properties.Resources.informacion1;
            BTNVerificarCarnet.BackgroundImageLayout = ImageLayout.Zoom;
            BTNVerificarCarnet.Location = new Point(658, 16);
            BTNVerificarCarnet.Name = "BTNVerificarCarnet";
            BTNVerificarCarnet.Size = new Size(83, 81);
            BTNVerificarCarnet.TabIndex = 4;
            BTNVerificarCarnet.UseVisualStyleBackColor = false;
            BTNVerificarCarnet.Click += BTNVerificarCarnet_Click_1;
            // 
            // reportesporalumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNVerificarCarnet);
            Controls.Add(TXTCARNE);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "reportesporalumno";
            Text = "reportesporalumno";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox TXTCARNE;
        private Button BTNVerificarCarnet;
    }
}