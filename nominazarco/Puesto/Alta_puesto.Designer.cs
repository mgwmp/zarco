namespace nominazarco
{
    partial class Alta_puesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alta_puesto));
            this.txt_Idpuesto = new System.Windows.Forms.TextBox();
            this.txt_Nompuesto = new System.Windows.Forms.TextBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_horario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Idpuesto
            // 
            this.txt_Idpuesto.Location = new System.Drawing.Point(116, 54);
            this.txt_Idpuesto.Name = "txt_Idpuesto";
            this.txt_Idpuesto.Size = new System.Drawing.Size(75, 20);
            this.txt_Idpuesto.TabIndex = 0;
            this.txt_Idpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Idpuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Idpuesto_KeyPress);
            // 
            // txt_Nompuesto
            // 
            this.txt_Nompuesto.Location = new System.Drawing.Point(20, 110);
            this.txt_Nompuesto.Name = "txt_Nompuesto";
            this.txt_Nompuesto.Size = new System.Drawing.Size(171, 20);
            this.txt_Nompuesto.TabIndex = 1;
            this.txt_Nompuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Nompuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nompuesto_KeyPress);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Aceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_Aceptar.Location = new System.Drawing.Point(136, 228);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(85, 25);
            this.btn_Aceptar.TabIndex = 4;
            this.btn_Aceptar.Text = "Registrar";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 153;
            this.label9.Text = "ID del puesto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 152;
            this.label8.Text = "Nombre puesto:";
            // 
            // txt_salario
            // 
            this.txt_salario.Location = new System.Drawing.Point(22, 172);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(110, 20);
            this.txt_salario.TabIndex = 2;
            this.txt_salario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salario_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 150;
            this.label6.Text = "Salario";
            // 
            // txt_horario
            // 
            this.txt_horario.Location = new System.Drawing.Point(204, 172);
            this.txt_horario.Name = "txt_horario";
            this.txt_horario.Size = new System.Drawing.Size(111, 20);
            this.txt_horario.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(203, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 148;
            this.label11.Text = "Horario";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(232, 228);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(85, 25);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 28);
            this.label1.TabIndex = 146;
            this.label1.Text = "Registro de Puesto";
            // 
            // Alta_puesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::nominazarco.Properties.Resources.flores_zarco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(333, 281);
            this.Controls.Add(this.txt_Idpuesto);
            this.Controls.Add(this.txt_Nompuesto);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_salario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_horario);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Alta_puesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Idpuesto;
        private System.Windows.Forms.TextBox txt_Nompuesto;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_horario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label1;
    }
}