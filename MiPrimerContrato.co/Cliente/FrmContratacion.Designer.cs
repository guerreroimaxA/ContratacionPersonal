namespace Cliente
{
    partial class FrmContratacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContratacion));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.cbxDepartamento = new System.Windows.Forms.ComboBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnCargarDocumento = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEnviarDatos = new System.Windows.Forms.Button();
            this.btnEnviarDocumento = new System.Windows.Forms.Button();
            this.txtNombreDocumento = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ofdAbrirPDF = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(18, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(18, 100);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 18);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(18, 145);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(104, 18);
            this.lblDepartamento.TabIndex = 3;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(18, 189);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(49, 18);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Título";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(18, 230);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 18);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(18, 12);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(32, 18);
            this.lblCedula.TabIndex = 6;
            this.lblCedula.Text = "C.I.";
            // 
            // cbxDepartamento
            // 
            this.cbxDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartamento.FormattingEnabled = true;
            this.cbxDepartamento.Items.AddRange(new object[] {
            "DEE",
            "DETRI",
            "DACI",
            "DM",
            "DF",
            "DG"});
            this.cbxDepartamento.Location = new System.Drawing.Point(173, 142);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Size = new System.Drawing.Size(127, 21);
            this.cbxDepartamento.TabIndex = 7;
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Ocasional",
            "Titular",
            "Invitado",
            "Honorario",
            "Ayudante"});
            this.cbxTipo.Location = new System.Drawing.Point(173, 230);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(127, 21);
            this.cbxTipo.TabIndex = 8;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(173, 12);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(127, 20);
            this.txtCedula.TabIndex = 9;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(141, 58);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 20);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(141, 100);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(159, 20);
            this.txtApellido.TabIndex = 11;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(141, 187);
            this.txtTitulo.MaxLength = 50;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(159, 20);
            this.txtTitulo.TabIndex = 12;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(109, 276);
            this.txtEstado.MaxLength = 20;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(191, 20);
            this.txtEstado.TabIndex = 14;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(18, 278);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 18);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado";
            // 
            // btnCargarDocumento
            // 
            this.btnCargarDocumento.BackColor = System.Drawing.Color.White;
            this.btnCargarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarDocumento.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDocumento.ForeColor = System.Drawing.Color.Black;
            this.btnCargarDocumento.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarDocumento.Image")));
            this.btnCargarDocumento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarDocumento.Location = new System.Drawing.Point(35, 319);
            this.btnCargarDocumento.Name = "btnCargarDocumento";
            this.btnCargarDocumento.Size = new System.Drawing.Size(168, 33);
            this.btnCargarDocumento.TabIndex = 15;
            this.btnCargarDocumento.Text = "Cargar Documento";
            this.btnCargarDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarDocumento.UseVisualStyleBackColor = false;
            this.btnCargarDocumento.Visible = false;
            this.btnCargarDocumento.Click += new System.EventHandler(this.btnCargarDocumento_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(306, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 21);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEnviarDatos
            // 
            this.btnEnviarDatos.BackColor = System.Drawing.Color.White;
            this.btnEnviarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarDatos.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarDatos.ForeColor = System.Drawing.Color.Black;
            this.btnEnviarDatos.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviarDatos.Image")));
            this.btnEnviarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviarDatos.Location = new System.Drawing.Point(448, 343);
            this.btnEnviarDatos.Name = "btnEnviarDatos";
            this.btnEnviarDatos.Size = new System.Drawing.Size(133, 35);
            this.btnEnviarDatos.TabIndex = 17;
            this.btnEnviarDatos.Text = "Enviar Datos";
            this.btnEnviarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviarDatos.UseVisualStyleBackColor = false;
            this.btnEnviarDatos.Click += new System.EventHandler(this.btnEnviarDatos_Click);
            // 
            // btnEnviarDocumento
            // 
            this.btnEnviarDocumento.BackColor = System.Drawing.Color.White;
            this.btnEnviarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarDocumento.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarDocumento.ForeColor = System.Drawing.Color.Black;
            this.btnEnviarDocumento.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviarDocumento.Image")));
            this.btnEnviarDocumento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviarDocumento.Location = new System.Drawing.Point(273, 346);
            this.btnEnviarDocumento.Name = "btnEnviarDocumento";
            this.btnEnviarDocumento.Size = new System.Drawing.Size(169, 32);
            this.btnEnviarDocumento.TabIndex = 18;
            this.btnEnviarDocumento.Text = "Enviar Documento";
            this.btnEnviarDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviarDocumento.UseVisualStyleBackColor = false;
            this.btnEnviarDocumento.Visible = false;
            this.btnEnviarDocumento.Click += new System.EventHandler(this.btnEnviarDocumento_Click);
            // 
            // txtNombreDocumento
            // 
            this.txtNombreDocumento.Location = new System.Drawing.Point(21, 358);
            this.txtNombreDocumento.MaxLength = 500;
            this.txtNombreDocumento.Name = "txtNombreDocumento";
            this.txtNombreDocumento.Size = new System.Drawing.Size(193, 20);
            this.txtNombreDocumento.TabIndex = 19;
            this.txtNombreDocumento.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(382, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // ofdAbrirPDF
            // 
            this.ofdAbrirPDF.FileName = "Abrir PDF";
            // 
            // FrmContratacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 390);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNombreDocumento);
            this.Controls.Add(this.btnEnviarDocumento);
            this.Controls.Add(this.btnEnviarDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCargarDocumento);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.cbxDepartamento);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmContratacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contratación";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.ComboBox cbxDepartamento;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnCargarDocumento;
        private System.Windows.Forms.Button btnEnviarDocumento;
        private System.Windows.Forms.TextBox txtNombreDocumento;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.Button btnEnviarDatos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog ofdAbrirPDF;
    }
}