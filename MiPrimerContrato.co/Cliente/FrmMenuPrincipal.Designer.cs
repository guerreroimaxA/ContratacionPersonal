namespace Cliente
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblAutores = new System.Windows.Forms.Label();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIniciarContratacion = new System.Windows.Forms.Button();
            this.btnBuscarPersona = new System.Windows.Forms.Button();
            this.btnConsultarPersonal = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.pnlLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.pctLogo);
            this.pnlHeader.Controls.Add(this.btnMinimizar);
            this.pnlHeader.Controls.Add(this.btnCerrar);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 30);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Webdings", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(37, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(193, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Mi Primer Contrato.co";
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(3, 3);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(30, 25);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(225)))), ((int)(((byte)(244)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(742, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(27, 30);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(225)))), ((int)(((byte)(244)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(773, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 30);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            this.pnlFooter.Controls.Add(this.lblAutores);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 420);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(800, 30);
            this.pnlFooter.TabIndex = 1;
            // 
            // lblAutores
            // 
            this.lblAutores.AutoSize = true;
            this.lblAutores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutores.ForeColor = System.Drawing.Color.White;
            this.lblAutores.Location = new System.Drawing.Point(498, 6);
            this.lblAutores.Name = "lblAutores";
            this.lblAutores.Size = new System.Drawing.Size(298, 18);
            this.lblAutores.TabIndex = 3;
            this.lblAutores.Text = "® Alejandro Guerrero - Jonathan Jaramillo";
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(179)))), ((int)(((byte)(190)))));
            this.pnlLateral.Controls.Add(this.btnSalir);
            this.pnlLateral.Controls.Add(this.btnIniciarContratacion);
            this.pnlLateral.Controls.Add(this.btnBuscarPersona);
            this.pnlLateral.Controls.Add(this.btnConsultarPersonal);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 30);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(207, 390);
            this.pnlLateral.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(179)))), ((int)(((byte)(190)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 353);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(207, 36);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIniciarContratacion
            // 
            this.btnIniciarContratacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(179)))), ((int)(((byte)(190)))));
            this.btnIniciarContratacion.FlatAppearance.BorderSize = 0;
            this.btnIniciarContratacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarContratacion.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarContratacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.btnIniciarContratacion.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciarContratacion.Image")));
            this.btnIniciarContratacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciarContratacion.Location = new System.Drawing.Point(0, 130);
            this.btnIniciarContratacion.Name = "btnIniciarContratacion";
            this.btnIniciarContratacion.Size = new System.Drawing.Size(207, 36);
            this.btnIniciarContratacion.TabIndex = 2;
            this.btnIniciarContratacion.Text = "Iniciar Contratación";
            this.btnIniciarContratacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciarContratacion.UseVisualStyleBackColor = false;
            this.btnIniciarContratacion.Click += new System.EventHandler(this.btnIniciarContratacion_Click);
            // 
            // btnBuscarPersona
            // 
            this.btnBuscarPersona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(179)))), ((int)(((byte)(190)))));
            this.btnBuscarPersona.FlatAppearance.BorderSize = 0;
            this.btnBuscarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPersona.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPersona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.btnBuscarPersona.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPersona.Image")));
            this.btnBuscarPersona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPersona.Location = new System.Drawing.Point(0, 94);
            this.btnBuscarPersona.Name = "btnBuscarPersona";
            this.btnBuscarPersona.Size = new System.Drawing.Size(207, 36);
            this.btnBuscarPersona.TabIndex = 1;
            this.btnBuscarPersona.Text = "Buscar Persona";
            this.btnBuscarPersona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPersona.UseVisualStyleBackColor = false;
            this.btnBuscarPersona.Click += new System.EventHandler(this.btnBuscarPersona_Click);
            // 
            // btnConsultarPersonal
            // 
            this.btnConsultarPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(179)))), ((int)(((byte)(190)))));
            this.btnConsultarPersonal.FlatAppearance.BorderSize = 0;
            this.btnConsultarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarPersonal.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.btnConsultarPersonal.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarPersonal.Image")));
            this.btnConsultarPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarPersonal.Location = new System.Drawing.Point(0, 58);
            this.btnConsultarPersonal.Name = "btnConsultarPersonal";
            this.btnConsultarPersonal.Size = new System.Drawing.Size(207, 36);
            this.btnConsultarPersonal.TabIndex = 0;
            this.btnConsultarPersonal.Text = "Consultar por Personal";
            this.btnConsultarPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarPersonal.UseVisualStyleBackColor = false;
            this.btnConsultarPersonal.Click += new System.EventHandler(this.btnConsultarPersonal_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(207, 30);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(593, 390);
            this.pnlContenedor.TabIndex = 3;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblAutores;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIniciarContratacion;
        private System.Windows.Forms.Button btnBuscarPersona;
        private System.Windows.Forms.Button btnConsultarPersonal;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}

