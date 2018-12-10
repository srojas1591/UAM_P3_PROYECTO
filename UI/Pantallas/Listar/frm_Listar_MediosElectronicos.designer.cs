namespace UI.Pantallas.Listar
{
    partial class frm_Listar_MediosElectronicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Listar_MediosElectronicos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.tslRefrescar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.tslBuscar = new System.Windows.Forms.ToolStripLabel();
            this.tstxtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSalir = new System.Windows.Forms.ToolStripButton();
            this.tslSalir = new System.Windows.Forms.ToolStripLabel();
            this.dgv_MediosElectronicos = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MediosElectronicos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnRefrescar,
            this.tslRefrescar,
            this.toolStripSeparator1,
            this.tsbtnNuevo,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.tsbtnModificar,
            this.toolStripLabel3,
            this.toolStripSeparator3,
            this.tsbtnEliminar,
            this.toolStripLabel4,
            this.toolStripSeparator4,
            this.tsbtnBuscar,
            this.tslBuscar,
            this.tstxtBuscar,
            this.toolStripSeparator5,
            this.tsbtnSalir,
            this.tslSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1528, 35);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnRefrescar
            // 
            this.tsbtnRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRefrescar.Image")));
            this.tsbtnRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefrescar.Name = "tsbtnRefrescar";
            this.tsbtnRefrescar.Size = new System.Drawing.Size(24, 32);
            this.tsbtnRefrescar.Text = "toolStripButton1";
            this.tsbtnRefrescar.Click += new System.EventHandler(this.tsbtnRefrescar_Click);
            // 
            // tslRefrescar
            // 
            this.tslRefrescar.Name = "tslRefrescar";
            this.tslRefrescar.Size = new System.Drawing.Size(98, 32);
            this.tslRefrescar.Text = "Refrescar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // tsbtnNuevo
            // 
            this.tsbtnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNuevo.Image")));
            this.tsbtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNuevo.Name = "tsbtnNuevo";
            this.tsbtnNuevo.Size = new System.Drawing.Size(24, 32);
            this.tsbtnNuevo.Text = "nuevo";
            this.tsbtnNuevo.Click += new System.EventHandler(this.tsbtnNuevo_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(74, 32);
            this.toolStripLabel2.Text = "Nuevo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // tsbtnModificar
            // 
            this.tsbtnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnModificar.Image")));
            this.tsbtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnModificar.Name = "tsbtnModificar";
            this.tsbtnModificar.Size = new System.Drawing.Size(24, 32);
            this.tsbtnModificar.Text = "Modificar";
            this.tsbtnModificar.Click += new System.EventHandler(this.tsbtnModificar_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(101, 32);
            this.toolStripLabel3.Text = "Modificar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // tsbtnEliminar
            // 
            this.tsbtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEliminar.Image")));
            this.tsbtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEliminar.Name = "tsbtnEliminar";
            this.tsbtnEliminar.Size = new System.Drawing.Size(24, 32);
            this.tsbtnEliminar.Text = "eliminar";
            this.tsbtnEliminar.Click += new System.EventHandler(this.tsbtnEliminar_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(87, 32);
            this.toolStripLabel4.Text = "Eliminar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 35);
            // 
            // tsbtnBuscar
            // 
            this.tsbtnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnBuscar.Image")));
            this.tsbtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBuscar.Name = "tsbtnBuscar";
            this.tsbtnBuscar.Size = new System.Drawing.Size(24, 32);
            this.tsbtnBuscar.Text = "buscar";
            // 
            // tslBuscar
            // 
            this.tslBuscar.Name = "tslBuscar";
            this.tslBuscar.Size = new System.Drawing.Size(74, 32);
            this.tslBuscar.Text = "Buscar";
            // 
            // tstxtBuscar
            // 
            this.tstxtBuscar.Name = "tstxtBuscar";
            this.tstxtBuscar.Size = new System.Drawing.Size(180, 35);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 35);
            // 
            // tsbtnSalir
            // 
            this.tsbtnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSalir.Image")));
            this.tsbtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSalir.Name = "tsbtnSalir";
            this.tsbtnSalir.Size = new System.Drawing.Size(24, 32);
            this.tsbtnSalir.Text = "Salir";
            this.tsbtnSalir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // tslSalir
            // 
            this.tslSalir.Name = "tslSalir";
            this.tslSalir.Size = new System.Drawing.Size(52, 32);
            this.tslSalir.Text = "Salir";
            this.tslSalir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // dgv_MediosElectronicos
            // 
            this.dgv_MediosElectronicos.AllowUserToAddRows = false;
            this.dgv_MediosElectronicos.AllowUserToDeleteRows = false;
            this.dgv_MediosElectronicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_MediosElectronicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_MediosElectronicos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_MediosElectronicos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_MediosElectronicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_MediosElectronicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MediosElectronicos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_MediosElectronicos.Location = new System.Drawing.Point(13, 76);
            this.dgv_MediosElectronicos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgv_MediosElectronicos.MultiSelect = false;
            this.dgv_MediosElectronicos.Name = "dgv_MediosElectronicos";
            this.dgv_MediosElectronicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_MediosElectronicos.Size = new System.Drawing.Size(1500, 727);
            this.dgv_MediosElectronicos.TabIndex = 2;
            // 
            // frm_Listar_MediosElectronicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1528, 817);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_MediosElectronicos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Listar_MediosElectronicos";
            this.Text = "Medios Electronicos";
            this.Load += new System.EventHandler(this.frm_Listar_MediosElectronicos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MediosElectronicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnRefrescar;
        private System.Windows.Forms.ToolStripLabel tslRefrescar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnNuevo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnModificar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnEliminar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnBuscar;
        private System.Windows.Forms.ToolStripLabel tslBuscar;
        private System.Windows.Forms.ToolStripTextBox tstxtBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtnSalir;
        private System.Windows.Forms.ToolStripLabel tslSalir;
        private System.Windows.Forms.DataGridView dgv_MediosElectronicos;
    }
}