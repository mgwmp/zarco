﻿namespace nominazarco.Bonos
{
    partial class Alta_Adelanto
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
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_NombreEmpleado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_CantidadBono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.dtp_FechaBono = new System.Windows.Forms.DateTimePicker();
            this.txt_Puesto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(14, 40);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(99, 22);
            this.txt_ID.TabIndex = 135;
            this.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_NombreEmpleado
            // 
            this.txt_NombreEmpleado.Enabled = false;
            this.txt_NombreEmpleado.Location = new System.Drawing.Point(15, 128);
            this.txt_NombreEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NombreEmpleado.Name = "txt_NombreEmpleado";
            this.txt_NombreEmpleado.Size = new System.Drawing.Size(256, 22);
            this.txt_NombreEmpleado.TabIndex = 136;
            this.txt_NombreEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 21);
            this.label9.TabIndex = 138;
            this.label9.Text = "ID del empleado :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 99);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 21);
            this.label8.TabIndex = 137;
            this.label8.Text = "Nombre empleado :";
            // 
            // txt_CantidadBono
            // 
            this.txt_CantidadBono.Location = new System.Drawing.Point(349, 200);
            this.txt_CantidadBono.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CantidadBono.Name = "txt_CantidadBono";
            this.txt_CantidadBono.Size = new System.Drawing.Size(175, 22);
            this.txt_CantidadBono.TabIndex = 139;
            this.txt_CantidadBono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_CantidadBono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CantidadBono_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 21);
            this.label1.TabIndex = 140;
            this.label1.Text = "Cantidad del adelanto :";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Aceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_Aceptar.Location = new System.Drawing.Point(399, 251);
            this.btn_Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(113, 31);
            this.btn_Aceptar.TabIndex = 141;
            this.btn_Aceptar.Text = "Registrar";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(561, 251);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(113, 31);
            this.btn_Cancelar.TabIndex = 142;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // dtp_FechaBono
            // 
            this.dtp_FechaBono.Location = new System.Drawing.Point(349, 126);
            this.dtp_FechaBono.Name = "dtp_FechaBono";
            this.dtp_FechaBono.Size = new System.Drawing.Size(267, 22);
            this.dtp_FechaBono.TabIndex = 143;
            // 
            // txt_Puesto
            // 
            this.txt_Puesto.Enabled = false;
            this.txt_Puesto.Location = new System.Drawing.Point(17, 200);
            this.txt_Puesto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Puesto.Name = "txt_Puesto";
            this.txt_Puesto.Size = new System.Drawing.Size(256, 22);
            this.txt_Puesto.TabIndex = 144;
            this.txt_Puesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 145;
            this.label2.Text = "Puesto : ";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.Image = global::nominazarco.Properties.Resources.Buscar;
            this.btn_Buscar.Location = new System.Drawing.Point(179, 19);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(107, 43);
            this.btn_Buscar.TabIndex = 146;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 21);
            this.label3.TabIndex = 147;
            this.label3.Text = "Fecha del adelanto:";
            // 
            // Alta_Adelanto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::nominazarco.Properties.Resources.flores_zarco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 318);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_Puesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_FechaBono);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.txt_CantidadBono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.txt_NombreEmpleado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Alta_Adelanto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_NombreEmpleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_CantidadBono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DateTimePicker dtp_FechaBono;
        private System.Windows.Forms.TextBox txt_Puesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label3;
    }
}