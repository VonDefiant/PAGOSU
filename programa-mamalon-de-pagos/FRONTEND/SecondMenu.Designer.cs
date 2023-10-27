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
            ButtonEliminar.BackColor = Color.Wheat;
            ButtonEliminar.BackgroundImage = Properties.Resources.boton_eliminar;
            ButtonEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonEliminar.ForeColor = SystemColors.ControlText;
            ButtonEliminar.Location = new Point(614, 124);
            ButtonEliminar.Margin = new Padding(3, 4, 3, 4);
            ButtonEliminar.Name = "ButtonEliminar";
            ButtonEliminar.Size = new Size(205, 289);
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
            ButtonAgregar.Location = new Point(63, 124);
            ButtonAgregar.Margin = new Padding(3, 4, 3, 4);
            ButtonAgregar.Name = "ButtonAgregar";
            ButtonAgregar.Size = new Size(205, 289);
            ButtonAgregar.TabIndex = 6;
            ButtonAgregar.UseVisualStyleBackColor = false;
            ButtonAgregar.Click += ButtonAgregar_Click;
            // 
            // ButtonModificar
            // 
            ButtonModificar.BackColor = Color.Wheat;
            ButtonModificar.BackgroundImage = Properties.Resources.modificado;
            ButtonModificar.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonModificar.FlatAppearance.BorderSize = 0;
            ButtonModificar.ForeColor = SystemColors.ControlText;
            ButtonModificar.Location = new Point(344, 124);
            ButtonModificar.Margin = new Padding(3, 4, 3, 4);
            ButtonModificar.Name = "ButtonModificar";
            ButtonModificar.Size = new Size(205, 289);
            ButtonModificar.TabIndex = 7;
            ButtonModificar.UseVisualStyleBackColor = false;
            ButtonModificar.Click += ButtonModificar_Click;
            // 
            // ButtonRegresar
            // 
            ButtonRegresar.BackColor = Color.White;
            ButtonRegresar.ForeColor = Color.Green;
            ButtonRegresar.Location = new Point(63, 477);
            ButtonRegresar.Margin = new Padding(3, 4, 3, 4);
            ButtonRegresar.Name = "ButtonRegresar";
            ButtonRegresar.Size = new Size(344, 68);
            ButtonRegresar.TabIndex = 9;
            ButtonRegresar.Text = "Regresar";
            ButtonRegresar.UseVisualStyleBackColor = false;
            ButtonRegresar.Click += ButtonRegresar_Click;
            // 
            // ButtonSalir
            // 
            ButtonSalir.BackColor = Color.White;
            ButtonSalir.ForeColor = Color.Red;
            ButtonSalir.Location = new Point(472, 477);
            ButtonSalir.Margin = new Padding(3, 4, 3, 4);
            ButtonSalir.Name = "ButtonSalir";
            ButtonSalir.Size = new Size(346, 68);
            ButtonSalir.TabIndex = 10;
            ButtonSalir.Text = "Salir";
            ButtonSalir.UseVisualStyleBackColor = false;
            ButtonSalir.Click += ButtonSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(94, 67);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(164, 50);
            label1.TabIndex = 11;
            label1.Text = "Agregar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(365, 67);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(192, 50);
            label2.TabIndex = 12;
            label2.Text = "Modificar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(645, 67);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(166, 50);
            label3.TabIndex = 13;
            label3.Text = "Eliminar";
            // 
            // SecondMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(914, 600);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ButtonSalir);
            Controls.Add(ButtonRegresar);
            Controls.Add(ButtonModificar);
            Controls.Add(ButtonAgregar);
            Controls.Add(ButtonEliminar);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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