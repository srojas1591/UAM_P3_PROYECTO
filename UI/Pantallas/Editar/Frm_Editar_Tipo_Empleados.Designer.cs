namespace UI.Pantallas.Editar
{
    partial class Frm_Editar_Tipo_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Editar_Tipo_Empleados));
            this.gb_Editar_Tipo_Empleados = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.tslGuardar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSalir = new System.Windows.Forms.ToolStripButton();
            this.tslSalir = new System.Windows.Forms.ToolStripLabel();
            this.cb_Estados = new System.Windows.Forms.ComboBox();
            this.gb_Editar_Tipo_Empleados.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Editar_Tipo_Empleados
            // 
            this.gb_Editar_Tipo_Empleados.Controls.Add(this.cb_Estados);
            this.gb_Editar_Tipo_Empleados.Controls.Add(this.txt_descripcion);
            this.gb_Editar_Tipo_Empleados.Controls.Add(this.txt_id);
            this.gb_Editar_Tipo_Empleados.Controls.Add(this.label3);
            this.gb_Editar_Tipo_Empleados.Controls.Add(this.label2);
            this.gb_Editar_Tipo_Empleados.Controls.Add(this.label1);
            this.gb_Editar_Tipo_Empleados.Location = new System.Drawing.Point(13, 30);
            this.gb_Editar_Tipo_Empleados.Name = "gb_Editar_Tipo_Empleados";
            this.gb_Editar_Tipo_Empleados.Size = new System.Drawing.Size(322, 226);
            this.gb_Editar_Tipo_Empleados.TabIndex = 0;
            this.gb_Editar_Tipo_Empleados.TabStop = false;
            this.gb_Editar_Tipo_Empleados.Text = "Informacion Tipo Empleados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(123, 50);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(121, 20);
            this.txt_id.TabIndex = 3;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(123, 91);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(121, 20);
            this.txt_descripcion.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsbtnGuardar,
            this.tslGuardar,
            this.toolStripSeparator2,
            this.toolStripSeparator5,
            this.tsbtnSalir,
            this.tslSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(347, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtnGuardar
            // 
            this.tsbtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnGuardar.Image")));
            this.tsbtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGuardar.Name = "tsbtnGuardar";
            this.tsbtnGuardar.Size = new System.Drawing.Size(24, 24);
            this.tsbtnGuardar.Text = "nuevo";
            this.tsbtnGuardar.Click += new System.EventHandler(this.tsbtnGuardar_Click);
            // 
            // tslGuardar
            // 
            this.tslGuardar.Name = "tslGuardar";
            this.tslGuardar.Size = new System.Drawing.Size(49, 24);
            this.tslGuardar.Text = "Guardar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtnSalir
            // 
            this.tsbtnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSalir.Image")));
            this.tsbtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSalir.Name = "tsbtnSalir";
            this.tsbtnSalir.Size = new System.Drawing.Size(24, 24);
            this.tsbtnSalir.Text = "Salir";
            this.tsbtnSalir.Click += new System.EventHandler(this.tsbtnSalir_Click_1);
            // 
            // tslSalir
            // 
            this.tslSalir.Name = "tslSalir";
            this.tslSalir.Size = new System.Drawing.Size(29, 24);
            this.tslSalir.Text = "Salir";
            // 
            // cb_Estados
            // 
            this.cb_Estados.FormattingEnabled = true;
            this.cb_Estados.Location = new System.Drawing.Point(123, 128);
            this.cb_Estados.Name = "cb_Estados";
            this.cb_Estados.Size = new System.Drawing.Size(121, 21);
            this.cb_Estados.TabIndex = 6;
            // 
            // Frm_Editar_Tipo_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 268);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gb_Editar_Tipo_Empleados);
            this.Name = "Frm_Editar_Tipo_Empleados";
            this.Text = "Frm_Editar_Tipo_Empleados";
            this.Load += new System.EventHandler(this.Frm_Editar_Tipo_Empleados_Load);
            this.gb_Editar_Tipo_Empleados.ResumeLayout(false);
            this.gb_Editar_Tipo_Empleados.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Editar_Tipo_Empleados;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Estados;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnGuardar;
        private System.Windows.Forms.ToolStripLabel tslGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtnSalir;
        private System.Windows.Forms.ToolStripLabel tslSalir;
    }
}