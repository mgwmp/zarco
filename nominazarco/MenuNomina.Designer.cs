namespace nominazarco
{
    partial class MenuNomina
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuNomina));
            this.btn_Entrada = new System.Windows.Forms.Button();
            this.btn_Salida = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.Reloj = new System.Windows.Forms.Timer(this.components);
            this.label_reloj = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.Altas = new System.Windows.Forms.ToolStripMenuItem();
            this.Bajas = new System.Windows.Forms.ToolStripMenuItem();
            this.Actualizacion = new System.Windows.Forms.ToolStripMenuItem();
            this.inicio = new System.Windows.Forms.ToolStripMenuItem();
            this.puestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarConsultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nóminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNominaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarYBajasDeNominasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adelantosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAdelantoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pagarAdelantoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bonoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarBonoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.exportarAPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Entrada
            // 
            this.btn_Entrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Entrada.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrada.Location = new System.Drawing.Point(359, 279);
            this.btn_Entrada.Name = "btn_Entrada";
            this.btn_Entrada.Size = new System.Drawing.Size(79, 34);
            this.btn_Entrada.TabIndex = 3;
            this.btn_Entrada.Text = "Entrada";
            this.btn_Entrada.UseVisualStyleBackColor = true;
            this.btn_Entrada.Click += new System.EventHandler(this.btn_Entrada_Click);
            // 
            // btn_Salida
            // 
            this.btn_Salida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salida.Location = new System.Drawing.Point(444, 279);
            this.btn_Salida.Name = "btn_Salida";
            this.btn_Salida.Size = new System.Drawing.Size(79, 34);
            this.btn_Salida.TabIndex = 4;
            this.btn_Salida.Text = "Salida";
            this.btn_Salida.UseVisualStyleBackColor = true;
            this.btn_Salida.Click += new System.EventHandler(this.btn_Salida_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(347, 182);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 1;
            this.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrchid;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese su ID de empleado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrchid;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 22);
            this.label1.TabIndex = 75;
            this.label1.Text = "Registro de Entrada y Salida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkOrchid;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha y hora actual:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(309, 240);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(260, 20);
            this.txt_Nombre.TabIndex = 5;
            this.txt_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkOrchid;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 82;
            this.label4.Text = "Nombre del empleado:";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Location = new System.Drawing.Point(455, 180);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 25);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // Reloj
            // 
            this.Reloj.Tick += new System.EventHandler(this.Reloj_Tick);
            // 
            // label_reloj
            // 
            this.label_reloj.AutoSize = true;
            this.label_reloj.BackColor = System.Drawing.Color.DarkOrchid;
            this.label_reloj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reloj.Location = new System.Drawing.Point(362, 118);
            this.label_reloj.Name = "label_reloj";
            this.label_reloj.Size = new System.Drawing.Size(39, 17);
            this.label_reloj.TabIndex = 83;
            this.label_reloj.Text = "Reloj";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightBlue;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label5.Location = new System.Drawing.Point(67, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 31);
            this.label5.TabIndex = 85;
            this.label5.Text = "Florería Zarco";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkOrchid;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Admin,
            this.inicio,
            this.puestoToolStripMenuItem,
            this.asistenciasToolStripMenuItem,
            this.nóminaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 28);
            this.menuStrip1.TabIndex = 87;
            this.menuStrip1.Text = "menu_nomina";
            // 
            // Admin
            // 
            this.Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Altas,
            this.Bajas,
            this.Actualizacion});
            this.Admin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.Image = global::nominazarco.Properties.Resources.Usuario;
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(105, 24);
            this.Admin.Text = "Empleados";
            // 
            // Altas
            // 
            this.Altas.Image = global::nominazarco.Properties.Resources.Altas;
            this.Altas.Name = "Altas";
            this.Altas.Size = new System.Drawing.Size(203, 22);
            this.Altas.Text = "Registrar empleado";
            this.Altas.Click += new System.EventHandler(this.Altas_Click);
            // 
            // Bajas
            // 
            this.Bajas.Image = global::nominazarco.Properties.Resources.Bajas;
            this.Bajas.Name = "Bajas";
            this.Bajas.Size = new System.Drawing.Size(203, 22);
            this.Bajas.Text = "Eliminar empleado";
            this.Bajas.Click += new System.EventHandler(this.Bajas_Click);
            // 
            // Actualizacion
            // 
            this.Actualizacion.Image = global::nominazarco.Properties.Resources.actualizacion;
            this.Actualizacion.Name = "Actualizacion";
            this.Actualizacion.Size = new System.Drawing.Size(203, 22);
            this.Actualizacion.Text = "Actualizar / Consultar";
            this.Actualizacion.Click += new System.EventHandler(this.Actualizacion_Click);
            // 
            // inicio
            // 
            this.inicio.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.inicio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicio.ForeColor = System.Drawing.Color.White;
            this.inicio.Image = global::nominazarco.Properties.Resources.Cerrarses;
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(65, 24);
            this.inicio.Text = "Salir";
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // puestoToolStripMenuItem
            // 
            this.puestoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPuestoToolStripMenuItem,
            this.eliminarPuestoToolStripMenuItem,
            this.actualizarConsultarToolStripMenuItem});
            this.puestoToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puestoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.puestoToolStripMenuItem.Image = global::nominazarco.Properties.Resources.Adminaso;
            this.puestoToolStripMenuItem.Name = "puestoToolStripMenuItem";
            this.puestoToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.puestoToolStripMenuItem.Text = "Puesto";
            // 
            // agregarPuestoToolStripMenuItem
            // 
            this.agregarPuestoToolStripMenuItem.Image = global::nominazarco.Properties.Resources.Altas;
            this.agregarPuestoToolStripMenuItem.Name = "agregarPuestoToolStripMenuItem";
            this.agregarPuestoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.agregarPuestoToolStripMenuItem.Text = "Agregar puesto";
            this.agregarPuestoToolStripMenuItem.Click += new System.EventHandler(this.agregarPuestoToolStripMenuItem_Click);
            // 
            // eliminarPuestoToolStripMenuItem
            // 
            this.eliminarPuestoToolStripMenuItem.Image = global::nominazarco.Properties.Resources.Bajas;
            this.eliminarPuestoToolStripMenuItem.Name = "eliminarPuestoToolStripMenuItem";
            this.eliminarPuestoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.eliminarPuestoToolStripMenuItem.Text = "Eliminar puesto";
            this.eliminarPuestoToolStripMenuItem.Click += new System.EventHandler(this.eliminarPuestoToolStripMenuItem_Click);
            // 
            // actualizarConsultarToolStripMenuItem
            // 
            this.actualizarConsultarToolStripMenuItem.Image = global::nominazarco.Properties.Resources.actualizacion;
            this.actualizarConsultarToolStripMenuItem.Name = "actualizarConsultarToolStripMenuItem";
            this.actualizarConsultarToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.actualizarConsultarToolStripMenuItem.Text = "Actualizar / Consultar";
            this.actualizarConsultarToolStripMenuItem.Click += new System.EventHandler(this.actualizarConsultarToolStripMenuItem_Click);
            // 
            // asistenciasToolStripMenuItem
            // 
            this.asistenciasToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asistenciasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.asistenciasToolStripMenuItem.Image = global::nominazarco.Properties.Resources.Regentrada;
            this.asistenciasToolStripMenuItem.Name = "asistenciasToolStripMenuItem";
            this.asistenciasToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.asistenciasToolStripMenuItem.Text = "Asistencias";
            this.asistenciasToolStripMenuItem.Click += new System.EventHandler(this.asistenciasToolStripMenuItem_Click);
            // 
            // nóminaToolStripMenuItem
            // 
            this.nóminaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNominaToolStripMenuItem,
            this.consultarYBajasDeNominasToolStripMenuItem,
            this.adelantosToolStripMenuItem1,
            this.bonoToolStripMenuItem1,
            this.exportarAPDFToolStripMenuItem});
            this.nóminaToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nóminaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.nóminaToolStripMenuItem.Image = global::nominazarco.Properties.Resources.Pago;
            this.nóminaToolStripMenuItem.Name = "nóminaToolStripMenuItem";
            this.nóminaToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.nóminaToolStripMenuItem.Text = "Nómina";
            this.nóminaToolStripMenuItem.Click += new System.EventHandler(this.nóminaToolStripMenuItem_Click);
            // 
            // registrarNominaToolStripMenuItem
            // 
            this.registrarNominaToolStripMenuItem.Image = global::nominazarco.Properties.Resources.Altas;
            this.registrarNominaToolStripMenuItem.Name = "registrarNominaToolStripMenuItem";
            this.registrarNominaToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.registrarNominaToolStripMenuItem.Text = "Registrar Nomina";
            this.registrarNominaToolStripMenuItem.Click += new System.EventHandler(this.registrarNominaToolStripMenuItem_Click);
            // 
            // consultarYBajasDeNominasToolStripMenuItem
            // 
            this.consultarYBajasDeNominasToolStripMenuItem.Image = global::nominazarco.Properties.Resources.Bajas;
            this.consultarYBajasDeNominasToolStripMenuItem.Name = "consultarYBajasDeNominasToolStripMenuItem";
            this.consultarYBajasDeNominasToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.consultarYBajasDeNominasToolStripMenuItem.Text = "Consultar y Bajas de nominas";
            this.consultarYBajasDeNominasToolStripMenuItem.Click += new System.EventHandler(this.consultarYBajasDeNominasToolStripMenuItem_Click);
            // 
            // adelantosToolStripMenuItem1
            // 
            this.adelantosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAdelantoToolStripMenuItem1,
            this.pagarAdelantoToolStripMenuItem1});
            this.adelantosToolStripMenuItem1.Name = "adelantosToolStripMenuItem1";
            this.adelantosToolStripMenuItem1.Size = new System.Drawing.Size(250, 26);
            this.adelantosToolStripMenuItem1.Text = "Adelantos";
            // 
            // registrarAdelantoToolStripMenuItem1
            // 
            this.registrarAdelantoToolStripMenuItem1.Image = global::nominazarco.Properties.Resources.Altas;
            this.registrarAdelantoToolStripMenuItem1.Name = "registrarAdelantoToolStripMenuItem1";
            this.registrarAdelantoToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.registrarAdelantoToolStripMenuItem1.Text = "Registrar Adelanto";
            this.registrarAdelantoToolStripMenuItem1.Click += new System.EventHandler(this.registrarAdelantoToolStripMenuItem1_Click);
            // 
            // pagarAdelantoToolStripMenuItem1
            // 
            this.pagarAdelantoToolStripMenuItem1.Image = global::nominazarco.Properties.Resources.Pago;
            this.pagarAdelantoToolStripMenuItem1.Name = "pagarAdelantoToolStripMenuItem1";
            this.pagarAdelantoToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.pagarAdelantoToolStripMenuItem1.Text = "Pagar Adelanto";
            this.pagarAdelantoToolStripMenuItem1.Click += new System.EventHandler(this.pagarAdelantoToolStripMenuItem1_Click);
            // 
            // bonoToolStripMenuItem1
            // 
            this.bonoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.eliminarBonoToolStripMenuItem1});
            this.bonoToolStripMenuItem1.Image = global::nominazarco.Properties.Resources.Pago;
            this.bonoToolStripMenuItem1.Name = "bonoToolStripMenuItem1";
            this.bonoToolStripMenuItem1.Size = new System.Drawing.Size(250, 26);
            this.bonoToolStripMenuItem1.Text = "Bono";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::nominazarco.Properties.Resources.Altas;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem2.Text = "Registrar Bono";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // eliminarBonoToolStripMenuItem1
            // 
            this.eliminarBonoToolStripMenuItem1.Image = global::nominazarco.Properties.Resources.Bajas;
            this.eliminarBonoToolStripMenuItem1.Name = "eliminarBonoToolStripMenuItem1";
            this.eliminarBonoToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.eliminarBonoToolStripMenuItem1.Text = "Eliminar Bono";
            this.eliminarBonoToolStripMenuItem1.Click += new System.EventHandler(this.eliminarBonoToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::nominazarco.Properties.Resources.zarco_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.DarkOrchid;
            this.pictureBox6.Location = new System.Drawing.Point(293, 41);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(289, 291);
            this.pictureBox6.TabIndex = 84;
            this.pictureBox6.TabStop = false;
            // 
            // exportarAPDFToolStripMenuItem
            // 
            this.exportarAPDFToolStripMenuItem.Name = "exportarAPDFToolStripMenuItem";
            this.exportarAPDFToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.exportarAPDFToolStripMenuItem.Text = "Exportar a PDF";
            /*this.exportarAPDFToolStripMenuItem.Click += new System.EventHandler(this.exportarAPDFToolStripMenuItem_Click);*/
            // 
            // MenuNomina
            // 
            this.AcceptButton = this.btn_Buscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(604, 349);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_reloj);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.btn_Salida);
            this.Controls.Add(this.btn_Entrada);
            this.Controls.Add(this.pictureBox6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Nómina";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Entrada;
        private System.Windows.Forms.Button btn_Salida;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Timer Reloj;
        private System.Windows.Forms.Label label_reloj;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem Admin;
        private System.Windows.Forms.ToolStripMenuItem Altas;
        private System.Windows.Forms.ToolStripMenuItem Bajas;
        private System.Windows.Forms.ToolStripMenuItem Actualizacion;
        public System.Windows.Forms.ToolStripMenuItem inicio;
        private System.Windows.Forms.ToolStripMenuItem nóminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarConsultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bonosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarBonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagarBonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNominaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarYBajasDeNominasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adelantosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registrarAdelantoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pagarAdelantoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bonoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eliminarBonoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportarAPDFToolStripMenuItem;
    }
}