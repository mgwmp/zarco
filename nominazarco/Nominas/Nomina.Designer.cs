namespace nominazarco
{
    partial class Nomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nomina));
            this.label9 = new System.Windows.Forms.Label();
            this.date_Fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_Sueldo = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Idnom = new System.Windows.Forms.TextBox();
            this.txt_Horas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Dias = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btn_Adelantos = new System.Windows.Forms.Button();
            this.btn_Bonos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_idempleado = new System.Windows.Forms.TextBox();
            this.txt_Bonos = new System.Windows.Forms.TextBox();
            this.txt_Adelantos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(271, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 56;
            this.label9.Text = "Fecha:";
            // 
            // date_Fecha
            // 
            this.date_Fecha.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_Fecha.Location = new System.Drawing.Point(325, 53);
            this.date_Fecha.Name = "date_Fecha";
            this.date_Fecha.Size = new System.Drawing.Size(212, 21);
            this.date_Fecha.TabIndex = 14;
            // 
            // txt_Sueldo
            // 
            this.txt_Sueldo.Location = new System.Drawing.Point(108, 291);
            this.txt_Sueldo.Name = "txt_Sueldo";
            this.txt_Sueldo.Size = new System.Drawing.Size(100, 20);
            this.txt_Sueldo.TabIndex = 13;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(20, 154);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(226, 20);
            this.txt_Nombre.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 50;
            this.label7.Text = "Sueldo neto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Nombre del empleado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Días trabajados:";
            // 
            // txt_Idnom
            // 
            this.txt_Idnom.Location = new System.Drawing.Point(325, 79);
            this.txt_Idnom.Name = "txt_Idnom";
            this.txt_Idnom.Size = new System.Drawing.Size(100, 20);
            this.txt_Idnom.TabIndex = 15;
            // 
            // txt_Horas
            // 
            this.txt_Horas.Location = new System.Drawing.Point(43, 245);
            this.txt_Horas.Name = "txt_Horas";
            this.txt_Horas.Size = new System.Drawing.Size(123, 20);
            this.txt_Horas.TabIndex = 4;
            this.txt_Horas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Horas_KeyPress);
            this.txt_Horas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.calculaSueldo_KeyUp);
            this.txt_Horas.Leave += new System.EventHandler(this.txt_Horas_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(252, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "ID nómina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Horas trabajadas:";
            // 
            // txt_Dias
            // 
            this.txt_Dias.Location = new System.Drawing.Point(43, 206);
            this.txt_Dias.Name = "txt_Dias";
            this.txt_Dias.Size = new System.Drawing.Size(123, 20);
            this.txt_Dias.TabIndex = 3;
            this.txt_Dias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Dias_KeyPress);
            this.txt_Dias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.calculaSueldo_KeyUp);
            this.txt_Dias.Leave += new System.EventHandler(this.txt_Dias_Leave);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(446, 291);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(82, 23);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Imprimir.Location = new System.Drawing.Point(365, 291);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(75, 23);
            this.btn_Imprimir.TabIndex = 10;
            this.btn_Imprimir.Text = "Guardar";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // btn_Adelantos
            // 
            this.btn_Adelantos.Enabled = false;
            this.btn_Adelantos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adelantos.Location = new System.Drawing.Point(265, 185);
            this.btn_Adelantos.Name = "btn_Adelantos";
            this.btn_Adelantos.Size = new System.Drawing.Size(75, 23);
            this.btn_Adelantos.TabIndex = 8;
            this.btn_Adelantos.Text = "Adelantos";
            this.btn_Adelantos.UseVisualStyleBackColor = true;
            // 
            // btn_Bonos
            // 
            this.btn_Bonos.Enabled = false;
            this.btn_Bonos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bonos.Location = new System.Drawing.Point(265, 151);
            this.btn_Bonos.Name = "btn_Bonos";
            this.btn_Bonos.Size = new System.Drawing.Size(75, 23);
            this.btn_Bonos.TabIndex = 6;
            this.btn_Bonos.Text = "Bonos";
            this.btn_Bonos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 88;
            this.label1.Text = "Generar Nómina";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Image = global::nominazarco.Properties.Resources.Buscar;
            this.btn_Buscar.Location = new System.Drawing.Point(149, 73);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(80, 42);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 20);
            this.label10.TabIndex = 91;
            this.label10.Text = "Ingrese el ID del empleado:";
            // 
            // txt_idempleado
            // 
            this.txt_idempleado.Location = new System.Drawing.Point(43, 74);
            this.txt_idempleado.Name = "txt_idempleado";
            this.txt_idempleado.Size = new System.Drawing.Size(100, 20);
            this.txt_idempleado.TabIndex = 1;
            this.txt_idempleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Bonos
            // 
            this.txt_Bonos.Location = new System.Drawing.Point(374, 154);
            this.txt_Bonos.Name = "txt_Bonos";
            this.txt_Bonos.Size = new System.Drawing.Size(100, 20);
            this.txt_Bonos.TabIndex = 7;
            this.txt_Bonos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.calculaSueldo_KeyUp);
            // 
            // txt_Adelantos
            // 
            this.txt_Adelantos.Location = new System.Drawing.Point(374, 187);
            this.txt_Adelantos.Name = "txt_Adelantos";
            this.txt_Adelantos.Size = new System.Drawing.Size(100, 20);
            this.txt_Adelantos.TabIndex = 9;
            this.txt_Adelantos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.calculaSueldo_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(25, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 112;
            this.label3.Text = "$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(343, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 18);
            this.label8.TabIndex = 113;
            this.label8.Text = "+$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(346, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 18);
            this.label11.TabIndex = 114;
            this.label11.Text = "-$";
            // 
            // Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(540, 330);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Adelantos);
            this.Controls.Add(this.txt_Bonos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_idempleado);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Adelantos);
            this.Controls.Add(this.btn_Bonos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.date_Fecha);
            this.Controls.Add(this.txt_Sueldo);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Idnom);
            this.Controls.Add(this.txt_Horas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Dias);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Imprimir);
            this.MaximizeBox = false;
            this.Name = "Nomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nomina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker date_Fecha;
        private System.Windows.Forms.TextBox txt_Sueldo;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Idnom;
        private System.Windows.Forms.TextBox txt_Horas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Dias;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.Button btn_Adelantos;
        private System.Windows.Forms.Button btn_Bonos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_idempleado;
        private System.Windows.Forms.TextBox txt_Bonos;
        private System.Windows.Forms.TextBox txt_Adelantos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
    }
}