
namespace AppIngreso
{
    partial class frmGridUsers
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGridUsers));
            this.tsGeneral = new System.Windows.Forms.ToolStrip();
            this.tsbInsertar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.Pagos = new System.Windows.Forms.ToolStripButton();
            this.tsbSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.pnlMantUser = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgGeneral = new System.Windows.Forms.DataGridView();
            this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
            this.tsGeneral.SuspendLayout();
            this.pnlMantUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // tsGeneral
            // 
            this.tsGeneral.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInsertar,
            this.tsbModificar,
            this.tsbEliminar,
            this.tsbRefrescar,
            this.Pagos,
            this.tsbSeparador,
            this.tsbCerrar});
            this.tsGeneral.Location = new System.Drawing.Point(0, 0);
            this.tsGeneral.Name = "tsGeneral";
            this.tsGeneral.Size = new System.Drawing.Size(1200, 42);
            this.tsGeneral.TabIndex = 2;
            this.tsGeneral.Text = "Barra General";
            // 
            // tsbInsertar
            // 
            this.tsbInsertar.Image = ((System.Drawing.Image)(resources.GetObject("tsbInsertar.Image")));
            this.tsbInsertar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsertar.Name = "tsbInsertar";
            this.tsbInsertar.Size = new System.Drawing.Size(50, 39);
            this.tsbInsertar.Text = "&Insertar";
            this.tsbInsertar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbInsertar.Click += new System.EventHandler(this.tsbInsertar_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(62, 39);
            this.tsbModificar.Text = "&Modificar";
            this.tsbModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(54, 39);
            this.tsbEliminar.Text = "&Eliminar";
            this.tsbEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // Pagos
            // 
            this.Pagos.Image = global::AppIngreso.Properties.Resources.datos;
            this.Pagos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pagos.Name = "Pagos";
            this.Pagos.Size = new System.Drawing.Size(88, 39);
            this.Pagos.Text = "&Agregar Pagos";
            this.Pagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Pagos.Click += new System.EventHandler(this.Pagos_Click);
            // 
            // tsbSeparador
            // 
            this.tsbSeparador.Name = "tsbSeparador";
            this.tsbSeparador.Size = new System.Drawing.Size(6, 42);
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCerrar.Image")));
            this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Size = new System.Drawing.Size(43, 39);
            this.tsbCerrar.Text = "&Cerrar";
            this.tsbCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCerrar.Click += new System.EventHandler(this.tsbCerrar_Click);
            // 
            // pnlMantUser
            // 
            this.pnlMantUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMantUser.Controls.Add(this.groupBox1);
            this.pnlMantUser.Controls.Add(this.panel2);
            this.pnlMantUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMantUser.Location = new System.Drawing.Point(0, 42);
            this.pnlMantUser.Name = "pnlMantUser";
            this.pnlMantUser.Size = new System.Drawing.Size(1200, 672);
            this.pnlMantUser.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ingrese el número de cédula:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(163, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(248, 20);
            this.txtId.TabIndex = 16;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.dgGeneral);
            this.panel2.Location = new System.Drawing.Point(3, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1017, 544);
            this.panel2.TabIndex = 13;
            // 
            // dgGeneral
            // 
            this.dgGeneral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgGeneral.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgGeneral.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgGeneral.Location = new System.Drawing.Point(0, 0);
            this.dgGeneral.Name = "dgGeneral";
            this.dgGeneral.Size = new System.Drawing.Size(1017, 544);
            this.dgGeneral.TabIndex = 0;
            this.dgGeneral.TabStop = false;
            // 
            // tsbRefrescar
            // 
            this.tsbRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefrescar.Image")));
            this.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefrescar.Name = "tsbRefrescar";
            this.tsbRefrescar.Size = new System.Drawing.Size(59, 39);
            this.tsbRefrescar.Text = "&Refrescar";
            this.tsbRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRefrescar.Click += new System.EventHandler(this.tsbRefrescar_Click);
            // 
            // frmGridUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 714);
            this.Controls.Add(this.pnlMantUser);
            this.Controls.Add(this.tsGeneral);
            this.Name = "frmGridUsers";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGridUsers_Load);
            this.tsGeneral.ResumeLayout(false);
            this.tsGeneral.PerformLayout();
            this.pnlMantUser.ResumeLayout(false);
            this.pnlMantUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip tsGeneral;
        internal System.Windows.Forms.ToolStripButton tsbInsertar;
        internal System.Windows.Forms.ToolStripButton tsbModificar;
        internal System.Windows.Forms.ToolStripButton tsbEliminar;
        internal System.Windows.Forms.ToolStripSeparator tsbSeparador;
        internal System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.Panel pnlMantUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgGeneral;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.ToolStripButton Pagos;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tsbRefrescar;
    }
}

