﻿namespace nominazarco.Bonos
{
    partial class Eliminar_Bono
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
            this.dgd_Bonos = new System.Windows.Forms.DataGridView();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgd_Bonos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgd_Bonos
            // 
            this.dgd_Bonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgd_Bonos.Location = new System.Drawing.Point(12, 146);
            this.dgd_Bonos.Name = "dgd_Bonos";
            this.dgd_Bonos.RowTemplate.Height = 24;
            this.dgd_Bonos.Size = new System.Drawing.Size(815, 169);
            this.dgd_Bonos.TabIndex = 154;
            this.dgd_Bonos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgd_Bonos_CellMouseDoubleClick_1);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(23, 38);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(99, 22);
            this.txt_ID.TabIndex = 151;
            this.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 13);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 21);
            this.label9.TabIndex = 152;
            this.label9.Text = "ID del empleado :";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.Image = global::nominazarco.Properties.Resources.Buscar;
            this.btn_Buscar.Location = new System.Drawing.Point(188, 17);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(107, 43);
            this.btn_Buscar.TabIndex = 153;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // Eliminar_Bono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::nominazarco.Properties.Resources.flores_zarco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 357);
            this.Controls.Add(this.dgd_Bonos);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label9);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Eliminar_Bono";
            this.Text = "Eliminar Bono";
            ((System.ComponentModel.ISupportInitialize)(this.dgd_Bonos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgd_Bonos;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label9;
    }
}