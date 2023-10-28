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
            ButtonRegresar = new Button();
            ButtonSalir = new Button();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // ButtonEliminar
            // 
            ButtonEliminar.BackColor = Color.Wheat;
            ButtonEliminar.BackgroundImage = Properties.Resources.boton_eliminar;
            ButtonEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonEliminar.ForeColor = SystemColors.ControlText;
            ButtonEliminar.Location = new Point(331, 86);
            ButtonEliminar.Name = "ButtonEliminar";
            ButtonEliminar.Size = new Size(179, 217);
            ButtonEliminar.TabIndex = 5;
            ButtonEliminar.UseVisualStyleBackColor = false;
            ButtonEliminar.Click += ButtonEliminar_Click;
            // 
            // ButtonAgregar
            // 
            ButtonAgregar.BackColor = Color.Wheat;
            ButtonAgregar.BackgroundImage = Properties.Resources.agregar_archivo;
            ButtonAgregar.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonAgregar.ForeColor = SystemColors.ControlText;
            ButtonAgregar.Location = new Point(49, 86);
            ButtonAgregar.Name = "ButtonAgregar";
            ButtonAgregar.Size = new Size(179, 217);
            ButtonAgregar.TabIndex = 6;
            ButtonAgregar.UseVisualStyleBackColor = false;
            ButtonAgregar.Click += ButtonAgregar_Click;
            // 
            // ButtonRegresar
            // 
            ButtonRegresar.BackColor = Color.White;
            ButtonRegresar.ForeColor = Color.Green;
            ButtonRegresar.Location = new Point(49, 335);
            ButtonRegresar.Name = "ButtonRegresar";
            ButtonRegresar.Size = new Size(185, 44);
            ButtonRegresar.TabIndex = 9;
            ButtonRegresar.Text = "Regresar";
            ButtonRegresar.UseVisualStyleBackColor = false;
            ButtonRegresar.Click += ButtonRegresar_Click;
            // 
            // ButtonSalir
            // 
            ButtonSalir.BackColor = Color.White;
            ButtonSalir.ForeColor = Color.Red;
            ButtonSalir.Location = new Point(331, 330);
            ButtonSalir.Name = "ButtonSalir";
            ButtonSalir.Size = new Size(190, 54);
            ButtonSalir.TabIndex = 10;
            ButtonSalir.Text = "Salir";
            ButtonSalir.UseVisualStyleBackColor = false;
            ButtonSalir.Click += ButtonSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(76, 43);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(129, 40);
            label1.TabIndex = 11;
            label1.Text = "Agregar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(349, 43);
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
            ClientSize = new Size(563, 433);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(ButtonSalir);
            Controls.Add(ButtonRegresar);
            Controls.Add(ButtonAgregar);
            Controls.Add(ButtonEliminar);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SecondMenu";
            Text = "SecondMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ButtonEliminar;
        private Button ButtonAgregar;
        private Button ButtonRegresar;
        private Button ButtonSalir;
        private Label label1;
        private Label label3;
    }
}