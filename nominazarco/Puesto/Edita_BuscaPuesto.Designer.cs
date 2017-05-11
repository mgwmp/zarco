namespace nominazarco
{
    partial class Edita_BuscaPuesto
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
            this.txt_Nompuesto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.r_Editar = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.txt_horario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.btn_con = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Nompuesto
            // 
            this.txt_Nompuesto.Location = new System.Drawing.Point(13, 163);
            this.txt_Nompuesto.Name = "txt_Nompuesto";
            this.txt_Nompuesto.Size = new System.Drawing.Size(186, 20);
            this.txt_Nompuesto.TabIndex = 3;
            this.txt_Nompuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Nompuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nompuesto_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 158;
            this.label8.Text = "Nombre puesto:";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.Image = global::nominazarco.Properties.Resources.Buscar;
            this.btn_Buscar.Location = new System.Drawing.Point(119, 80);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(80, 35);
            this.btn_Buscar.TabIndex = 1;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // r_Editar
            // 
            this.r_Editar.AutoSize = true;
            this.r_Editar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_Editar.Location = new System.Drawing.Point(16, 103);
            this.r_Editar.Name = "r_Editar";
            this.r_Editar.Size = new System.Drawing.Size(63, 21);
            this.r_Editar.TabIndex = 2;
            this.r_Editar.TabStop = true;
            this.r_Editar.Text = "Editar";
            this.r_Editar.UseVisualStyleBackColor = true;
            this.r_Editar.CheckedChanged += new System.EventHandler(this.r_Editar_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(154, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 153;
            this.label7.Text = "Horario:";
            // 
            // txt_salario
            // 
            this.txt_salario.Location = new System.Drawing.Point(13, 224);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(97, 20);
            this.txt_salario.TabIndex = 4;
            this.txt_salario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salario_KeyPress);
            // 
            // txt_horario
            // 
            this.txt_horario.Location = new System.Drawing.Point(157, 224);
            this.txt_horario.Name = "txt_horario";
            this.txt_horario.Size = new System.Drawing.Size(111, 20);
            this.txt_horario.TabIndex = 5;
            this.txt_horario.TextChanged += new System.EventHandler(this.txt_Telefono_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 152;
            this.label11.Text = "Salario:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(280, 276);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(85, 25);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Aceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_Aceptar.Location = new System.Drawing.Point(181, 276);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(85, 25);
            this.btn_Aceptar.TabIndex = 6;
            this.btn_Aceptar.Text = "Actualizar";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 24);
            this.label1.TabIndex = 150;
            this.label1.Text = "Actualizar / Consultar Datos de Puestos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 149;
            this.label2.Text = "Ingrese el ID del puesto:";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(13, 80);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 0;
            this.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ID_KeyPress);
            // 
            // btn_con
            // 
            this.btn_con.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_con.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_con.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_con.ForeColor = System.Drawing.Color.White;
            this.btn_con.Location = new System.Drawing.Point(280, 80);
            this.btn_con.Name = "btn_con";
            this.btn_con.Size = new System.Drawing.Size(85, 62);
            this.btn_con.TabIndex = 159;
            this.btn_con.Text = "Consultar todos los puestos";
            this.btn_con.UseVisualStyleBackColor = false;
            this.btn_con.Click += new System.EventHandler(this.btn_con_Click);
            // 
            // Edita_BuscaPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::nominazarco.Properties.Resources.flores_zarco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(390, 331);
            this.Controls.Add(this.btn_con);
            this.Controls.Add(this.txt_Nompuesto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.r_Editar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_salario);
            this.Controls.Add(this.txt_horario);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ID);
            this.DoubleBuffered = true;
            this.Name = "Edita_BuscaPuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar / Consultar Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Nompuesto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.RadioButton r_Editar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.TextBox txt_horario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button btn_con;
    }
}