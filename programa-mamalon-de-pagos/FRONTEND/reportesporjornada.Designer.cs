namespace programa_mamalon_de_pagos.FRONTEND
{
    partial class reportesporjornada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportesporjornada));
            CMBJORNADA = new ComboBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CMBJORNADA
            // 
            CMBJORNADA.FormattingEnabled = true;
            CMBJORNADA.Location = new Point(32, 37);
            CMBJORNADA.Name = "CMBJORNADA";
            CMBJORNADA.Size = new Size(260, 23);
            CMBJORNADA.TabIndex = 0;
            CMBJORNADA.SelectedIndexChanged += CMBJORNADA_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(739, 324);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 75);
            label1.Name = "label1";
            label1.Size = new Size(197, 15);
            label1.TabIndex = 2;
            label1.Text = "PAGOS REALIZADOS POR JORNADA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 9);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 3;
            label2.Text = "SELECCIONE LA JORNADA";
            // 
            // reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(CMBJORNADA);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "reportes";
            Text = "reportes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CMBJORNADA;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
    }
}