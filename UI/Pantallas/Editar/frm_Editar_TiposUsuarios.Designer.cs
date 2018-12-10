namespace UI.Pantallas.Editar
{
    partial class frm_Editar_TiposUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Editar_TiposUsuarios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CMB_IdEstado = new System.Windows.Forms.ComboBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_TipoCliente = new System.Windows.Forms.TextBox();
            this.txt_IdTipoCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.tslGuardar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSalir = new System.Windows.Forms.ToolStripButton();
            this.tslSalir = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CMB_IdEstado);
            this.groupBox1.Controls.Add(this.txt_Descripcion);
            this.groupBox1.Controls.Add(this.txt_TipoCliente);
            this.groupBox1.Controls.Add(this.txt_IdTipoCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(50, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(549, 490);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar";
            // 
            // CMB_IdEstado
            // 
            this.CMB_IdEstado.FormattingEnabled = true;
            this.CMB_IdEstado.Location = new System.Drawing.Point(259, 321);
            this.CMB_IdEstado.Name = "CMB_IdEstado";
            this.CMB_IdEstado.Size = new System.Drawing.Size(261, 32);
            this.CMB_IdEstado.TabIndex = 16;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(259, 240);
            this.txt_Descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(261, 29);
            this.txt_Descripcion.TabIndex = 6;
            // 
            // txt_TipoCliente
            // 
            this.txt_TipoCliente.Location = new System.Drawing.Point(259, 156);
            this.txt_TipoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TipoCliente.Name = "txt_TipoCliente";
            this.txt_TipoCliente.Size = new System.Drawing.Size(261, 29);
            this.txt_TipoCliente.TabIndex = 5;
            // 
            // txt_IdTipoCliente
            // 
            this.txt_IdTipoCliente.Location = new System.Drawing.Point(259, 72);
            this.txt_IdTipoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IdTipoCliente.Name = "txt_IdTipoCliente";
            this.txt_IdTipoCliente.Size = new System.Drawing.Size(102, 29);
            this.txt_IdTipoCliente.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 328);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Tipo Cliente";
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
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(672, 33);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // tsbtnGuardar
            // 
            this.tsbtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnGuardar.Image")));
            this.tsbtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGuardar.Name = "tsbtnGuardar";
            this.tsbtnGuardar.Size = new System.Drawing.Size(24, 30);
            this.tsbtnGuardar.Text = "nuevo";
            this.tsbtnGuardar.Click += new System.EventHandler(this.tsbtnGuardar_Click);
            // 
            // tslGuardar
            // 
            this.tslGuardar.Name = "tslGuardar";
            this.tslGuardar.Size = new System.Drawing.Size(87, 30);
            this.tslGuardar.Text = "Guardar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 33);
            // 
            // tsbtnSalir
            // 
            this.tsbtnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSalir.Image")));
            this.tsbtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSalir.Name = "tsbtnSalir";
            this.tsbtnSalir.Size = new System.Drawing.Size(24, 30);
            this.tsbtnSalir.Text = "Salir";
            this.tsbtnSalir.Click += new System.EventHandler(this.tsbtnSalir_Click);
            // 
            // tslSalir
            // 
            this.tslSalir.Name = "tslSalir";
            this.tslSalir.Size = new System.Drawing.Size(52, 30);
            this.tslSalir.Text = "Salir";
            // 
            // frm_Editar_TiposUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 625);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Editar_TiposUsuarios";
            this.Text = "frm_Editar_TiposUsuarios";
            this.Load += new System.EventHandler(this.frm_Editar_TiposUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_TipoCliente;
        private System.Windows.Forms.TextBox txt_IdTipoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnGuardar;
        private System.Windows.Forms.ToolStripLabel tslGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtnSalir;
        private System.Windows.Forms.ToolStripLabel tslSalir;
        private System.Windows.Forms.ComboBox CMB_IdEstado;
    }
}