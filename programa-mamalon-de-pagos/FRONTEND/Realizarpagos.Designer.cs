namespace programa_mamalon_de_pagos.FRONTEND
{
    partial class Realizarpagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Realizarpagos));
            btnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtMonto = new TextBox();
            PagosCB = new ComboBox();
            label3 = new Label();
            labelfecha = new Label();
            label4 = new Label();
            txtNumeroCuenta = new TextBox();
            labelNumeroCuenta = new Label();
            txtcarnet = new TextBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            cmperiodo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(43, 318);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(117, 106);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar Pago";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 60);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 1;
            label1.Text = "Método de pago:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 136);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 3;
            label2.Text = "Cantidad a pagar:";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(177, 134);
            txtMonto.Margin = new Padding(3, 2, 3, 2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(210, 23);
            txtMonto.TabIndex = 5;
            // 
            // PagosCB
            // 
            PagosCB.FormattingEnabled = true;
            PagosCB.Items.AddRange(new object[] { "Tarjeta de crédito", "Tarjeta de dédito", "Transferencia" });
            PagosCB.Location = new Point(177, 60);
            PagosCB.Margin = new Padding(3, 2, 3, 2);
            PagosCB.Name = "PagosCB";
            PagosCB.Size = new Size(210, 23);
            PagosCB.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 97);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 8;
            label3.Text = "Carnet de estudiante:";
            // 
            // labelfecha
            // 
            labelfecha.AutoSize = true;
            labelfecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelfecha.Location = new Point(177, 43);
            labelfecha.Name = "labelfecha";
            labelfecha.Size = new Size(178, 15);
            labelfecha.TabIndex = 11;
            labelfecha.Text = "Seleccione un metodo de pago";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 26);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 12;
            // 
            // txtNumeroCuenta
            // 
            txtNumeroCuenta.Location = new Point(43, 291);
            txtNumeroCuenta.Margin = new Padding(3, 2, 3, 2);
            txtNumeroCuenta.Name = "txtNumeroCuenta";
            txtNumeroCuenta.Size = new Size(117, 23);
            txtNumeroCuenta.TabIndex = 13;
            txtNumeroCuenta.Visible = false;
            // 
            // labelNumeroCuenta
            // 
            labelNumeroCuenta.AutoSize = true;
            labelNumeroCuenta.Location = new Point(41, 264);
            labelNumeroCuenta.Name = "labelNumeroCuenta";
            labelNumeroCuenta.Size = new Size(106, 15);
            labelNumeroCuenta.TabIndex = 14;
            labelNumeroCuenta.Text = "Número de Boleta:";
            labelNumeroCuenta.Visible = false;
            // 
            // txtcarnet
            // 
            txtcarnet.Location = new Point(177, 97);
            txtcarnet.Name = "txtcarnet";
            txtcarnet.Size = new Size(210, 23);
            txtcarnet.TabIndex = 15;
            txtcarnet.TextChanged += txtcarnet_TextChanged_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.pagos;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(244, 291);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 139);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 176);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 17;
            label5.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(177, 170);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(210, 23);
            dateTimePicker1.TabIndex = 18;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 221);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 19;
            label6.Text = "Perido a pagar";
            // 
            // cmperiodo
            // 
            cmperiodo.FormattingEnabled = true;
            cmperiodo.Location = new Point(177, 213);
            cmperiodo.Name = "cmperiodo";
            cmperiodo.Size = new Size(210, 23);
            cmperiodo.TabIndex = 20;
            cmperiodo.SelectedIndexChanged += cmperiodo_SelectedIndexChanged;
            // 
            // Realizarpagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(439, 456);
            Controls.Add(cmperiodo);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(txtcarnet);
            Controls.Add(labelNumeroCuenta);
            Controls.Add(txtNumeroCuenta);
            Controls.Add(label4);
            Controls.Add(labelfecha);
            Controls.Add(label3);
            Controls.Add(PagosCB);
            Controls.Add(txtMonto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Realizarpagos";
            Text = "Agregar Pago";
            Load += Realizarpagos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Label label1;
        private Label label2;
        private TextBox txtMonto;
        private ComboBox PagosCB;
        private Label label3;
        private Label labelfecha;
        private Label label4;
        private TextBox txtNumeroCuenta;
        private Label labelNumeroCuenta;
        private TextBox txtcarnet;
        private PictureBox pictureBox1;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private ComboBox cmperiodo;
    }
}