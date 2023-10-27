namespace programa_mamalon_de_pagos.FRONTEND
{
    partial class SecondMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondMenu));
            ButtonEliminar = new Button();
            ButtonAgregar = new Button();
            ButtonModificar = new Button();
            ButtonRegresar = new Button();
            ButtonSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // ButtonEliminar
            // 
            ButtonEliminar.BackColor = Color.White;
            ButtonEliminar.BackgroundImage = (Image)resources.GetObject("ButtonEliminar.BackgroundImage");
            ButtonEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonEliminar.ForeColor = SystemColors.ControlText;
            ButtonEliminar.Location = new Point(537, 93);
            ButtonEliminar.Name = "ButtonEliminar";
            ButtonEliminar.Size = new Size(179, 217);
            ButtonEliminar.TabIndex = 5;
            ButtonEliminar.UseVisualStyleBackColor = false;
            ButtonEliminar.Click += ButtonEliminar_Click;
            // 
            // ButtonAgregar
            // 
            ButtonAgregar.BackColor = Color.White;
            ButtonAgregar.BackgroundImage = (Image)resources.GetObject("ButtonAgregar.BackgroundImage");
            ButtonAgregar.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonAgregar.ForeColor = SystemColors.ControlText;
            ButtonAgregar.Location = new Point(55, 93);
            ButtonAgregar.Name = "ButtonAgregar";
            ButtonAgregar.Size = new Size(179, 217);
            ButtonAgregar.TabIndex = 6;
            ButtonAgregar.UseVisualStyleBackColor = false;
            ButtonAgregar.Click += ButtonAgregar_Click;
            // 
            // ButtonModificar
            // 
            ButtonModificar.BackColor = Color.White;
            ButtonModificar.BackgroundImage = (Image)resources.GetObject("ButtonModificar.BackgroundImage");
            ButtonModificar.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonModificar.ForeColor = SystemColors.ControlText;
            ButtonModificar.Location = new Point(301, 93);
            ButtonModificar.Name = "ButtonModificar";
            ButtonModificar.Size = new Size(179, 217);
            ButtonModificar.TabIndex = 7;
            ButtonModificar.UseVisualStyleBackColor = false;
            ButtonModificar.Click += ButtonModificar_Click;
            // 
            // ButtonRegresar
            // 
            ButtonRegresar.BackColor = Color.White;
            ButtonRegresar.ForeColor = Color.Green;
            ButtonRegresar.Location = new Point(55, 358);
            ButtonRegresar.Name = "ButtonRegresar";
            ButtonRegresar.Size = new Size(301, 51);
            ButtonRegresar.TabIndex = 9;
            ButtonRegresar.Text = "Regresar";
            ButtonRegresar.UseVisualStyleBackColor = false;
            ButtonRegresar.Click += ButtonRegresar_Click;
            // 
            // ButtonSalir
            // 
            ButtonSalir.BackColor = Color.White;
            ButtonSalir.ForeColor = Color.Red;
            ButtonSalir.Location = new Point(413, 358);
            ButtonSalir.Name = "ButtonSalir";
            ButtonSalir.Size = new Size(303, 51);
            ButtonSalir.TabIndex = 10;
            ButtonSalir.Text = "Salir";
            ButtonSalir.UseVisualStyleBackColor = false;
            ButtonSalir.Click += ButtonSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(82, 50);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(129, 40);
            label1.TabIndex = 11;
            label1.Text = "Agregar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(319, 50);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(150, 40);
            label2.TabIndex = 12;
            label2.Text = "Modificar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(564, 50);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(129, 40);
            label3.TabIndex = 13;
            label3.Text = "Eliminar";
            // 
            // SecondMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ButtonSalir);
            Controls.Add(ButtonRegresar);
            Controls.Add(ButtonModificar);
            Controls.Add(ButtonAgregar);
            Controls.Add(ButtonEliminar);
            ForeColor = SystemColors.ControlText;
            Name = "SecondMenu";
            Text = "SecondMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ButtonEliminar;
        private Button ButtonAgregar;
        private Button ButtonModificar;
        private Button ButtonRegresar;
        private Button ButtonSalir;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}