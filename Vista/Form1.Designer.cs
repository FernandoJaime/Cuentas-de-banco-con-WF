
namespace Vista
{
    partial class Form1
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
            this.groupPersonal = new System.Windows.Forms.GroupBox();
            this.DGVpersonas = new System.Windows.Forms.DataGridView();
            this.btnModificarP = new System.Windows.Forms.Button();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.btnConsultarP = new System.Windows.Forms.Button();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.groupDatPersonas = new System.Windows.Forms.GroupBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxcuentaP = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarP = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnGuardarP = new System.Windows.Forms.Button();
            this.groupEmpresa = new System.Windows.Forms.GroupBox();
            this.DGVempresas = new System.Windows.Forms.DataGridView();
            this.btnModificarE = new System.Windows.Forms.Button();
            this.btneEliminarE = new System.Windows.Forms.Button();
            this.btnConsultarE = new System.Windows.Forms.Button();
            this.btnAgregarE = new System.Windows.Forms.Button();
            this.groupDatEmpresas = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.boxFiscal = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxCuentaE = new System.Windows.Forms.ComboBox();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDirecE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancelarE = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnGuardarE = new System.Windows.Forms.Button();
            this.BoxPersona = new System.Windows.Forms.GroupBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.txtSaldoP = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblSaldoP = new System.Windows.Forms.Label();
            this.btnExtraerP = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDepositarP = new System.Windows.Forms.Button();
            this.BoxEmpresa = new System.Windows.Forms.GroupBox();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txtSaldoE = new System.Windows.Forms.TextBox();
            this.lblTipoE = new System.Windows.Forms.Label();
            this.lblSaldoE = new System.Windows.Forms.Label();
            this.btnExtraerE = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDepositarE = new System.Windows.Forms.Button();
            this.groupPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVpersonas)).BeginInit();
            this.groupDatPersonas.SuspendLayout();
            this.groupEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVempresas)).BeginInit();
            this.groupDatEmpresas.SuspendLayout();
            this.BoxPersona.SuspendLayout();
            this.BoxEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPersonal
            // 
            this.groupPersonal.Controls.Add(this.DGVpersonas);
            this.groupPersonal.Controls.Add(this.btnModificarP);
            this.groupPersonal.Controls.Add(this.btnEliminarP);
            this.groupPersonal.Controls.Add(this.btnConsultarP);
            this.groupPersonal.Controls.Add(this.btnAgregarP);
            this.groupPersonal.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupPersonal.Location = new System.Drawing.Point(6, 14);
            this.groupPersonal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupPersonal.Name = "groupPersonal";
            this.groupPersonal.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupPersonal.Size = new System.Drawing.Size(471, 224);
            this.groupPersonal.TabIndex = 2;
            this.groupPersonal.TabStop = false;
            this.groupPersonal.Text = "Lista de banca personal";
            // 
            // DGVpersonas
            // 
            this.DGVpersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVpersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVpersonas.Location = new System.Drawing.Point(8, 21);
            this.DGVpersonas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DGVpersonas.Name = "DGVpersonas";
            this.DGVpersonas.Size = new System.Drawing.Size(448, 150);
            this.DGVpersonas.TabIndex = 6;
            this.DGVpersonas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVpersonas_CellClick);
            // 
            // btnModificarP
            // 
            this.btnModificarP.Location = new System.Drawing.Point(144, 182);
            this.btnModificarP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificarP.Name = "btnModificarP";
            this.btnModificarP.Size = new System.Drawing.Size(78, 30);
            this.btnModificarP.TabIndex = 5;
            this.btnModificarP.Text = "Modificar";
            this.btnModificarP.UseVisualStyleBackColor = true;
            this.btnModificarP.Click += new System.EventHandler(this.btnModificarP_Click);
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.Location = new System.Drawing.Point(230, 181);
            this.btnEliminarP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(71, 30);
            this.btnEliminarP.TabIndex = 4;
            this.btnEliminarP.Text = "Eliminar";
            this.btnEliminarP.UseVisualStyleBackColor = true;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click);
            // 
            // btnConsultarP
            // 
            this.btnConsultarP.Location = new System.Drawing.Point(309, 182);
            this.btnConsultarP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsultarP.Name = "btnConsultarP";
            this.btnConsultarP.Size = new System.Drawing.Size(78, 30);
            this.btnConsultarP.TabIndex = 3;
            this.btnConsultarP.Text = "Consultar";
            this.btnConsultarP.UseVisualStyleBackColor = true;
            this.btnConsultarP.Click += new System.EventHandler(this.btnConsultarP_Click);
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Location = new System.Drawing.Point(68, 181);
            this.btnAgregarP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(68, 30);
            this.btnAgregarP.TabIndex = 1;
            this.btnAgregarP.Text = "Agregar";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // groupDatPersonas
            // 
            this.groupDatPersonas.Controls.Add(this.txtCuenta);
            this.groupDatPersonas.Controls.Add(this.label11);
            this.groupDatPersonas.Controls.Add(this.label5);
            this.groupDatPersonas.Controls.Add(this.BoxcuentaP);
            this.groupDatPersonas.Controls.Add(this.txtNombre);
            this.groupDatPersonas.Controls.Add(this.label4);
            this.groupDatPersonas.Controls.Add(this.txtFecha);
            this.groupDatPersonas.Controls.Add(this.label3);
            this.groupDatPersonas.Controls.Add(this.txtApellido);
            this.groupDatPersonas.Controls.Add(this.label2);
            this.groupDatPersonas.Controls.Add(this.txtDNI);
            this.groupDatPersonas.Controls.Add(this.label1);
            this.groupDatPersonas.Controls.Add(this.btnCancelarP);
            this.groupDatPersonas.Controls.Add(this.button4);
            this.groupDatPersonas.Controls.Add(this.btnGuardarP);
            this.groupDatPersonas.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupDatPersonas.Location = new System.Drawing.Point(495, 14);
            this.groupDatPersonas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupDatPersonas.Name = "groupDatPersonas";
            this.groupDatPersonas.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupDatPersonas.Size = new System.Drawing.Size(406, 224);
            this.groupDatPersonas.TabIndex = 8;
            this.groupDatPersonas.TabStop = false;
            this.groupDatPersonas.Text = "Registro de persona";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(144, 23);
            this.txtCuenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(212, 22);
            this.txtCuenta.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(12, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Número de cuenta: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tipo de cuenta:";
            // 
            // BoxcuentaP
            // 
            this.BoxcuentaP.FormattingEnabled = true;
            this.BoxcuentaP.Items.AddRange(new object[] {
            "Pesos AR$",
            "Dolares US$"});
            this.BoxcuentaP.Location = new System.Drawing.Point(131, 144);
            this.BoxcuentaP.Name = "BoxcuentaP";
            this.BoxcuentaP.Size = new System.Drawing.Size(131, 22);
            this.BoxcuentaP.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 79);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 22);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre: ";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(161, 111);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(195, 22);
            this.txtFecha.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha de nacimiento: ";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(276, 79);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(110, 22);
            this.txtApellido.TabIndex = 7;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(207, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido: ";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(61, 51);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(295, 22);
            this.txtDNI.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "DNI: ";
            // 
            // btnCancelarP
            // 
            this.btnCancelarP.Location = new System.Drawing.Point(306, 181);
            this.btnCancelarP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelarP.Name = "btnCancelarP";
            this.btnCancelarP.Size = new System.Drawing.Size(92, 30);
            this.btnCancelarP.TabIndex = 3;
            this.btnCancelarP.Text = "Cancelar";
            this.btnCancelarP.UseVisualStyleBackColor = true;
            this.btnCancelarP.Click += new System.EventHandler(this.btnCancelarP_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(666, 429);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 30);
            this.button4.TabIndex = 2;
            this.button4.Text = "Cerrar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.Location = new System.Drawing.Point(11, 182);
            this.btnGuardarP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardarP.Name = "btnGuardarP";
            this.btnGuardarP.Size = new System.Drawing.Size(92, 30);
            this.btnGuardarP.TabIndex = 1;
            this.btnGuardarP.Text = "Guardar";
            this.btnGuardarP.UseVisualStyleBackColor = true;
            this.btnGuardarP.Click += new System.EventHandler(this.btnGuardarP_Click);
            // 
            // groupEmpresa
            // 
            this.groupEmpresa.Controls.Add(this.DGVempresas);
            this.groupEmpresa.Controls.Add(this.btnModificarE);
            this.groupEmpresa.Controls.Add(this.btneEliminarE);
            this.groupEmpresa.Controls.Add(this.btnConsultarE);
            this.groupEmpresa.Controls.Add(this.btnAgregarE);
            this.groupEmpresa.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupEmpresa.Location = new System.Drawing.Point(6, 256);
            this.groupEmpresa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupEmpresa.Name = "groupEmpresa";
            this.groupEmpresa.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupEmpresa.Size = new System.Drawing.Size(471, 224);
            this.groupEmpresa.TabIndex = 7;
            this.groupEmpresa.TabStop = false;
            this.groupEmpresa.Text = "Lista de banca empresa";
            // 
            // DGVempresas
            // 
            this.DGVempresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVempresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVempresas.Location = new System.Drawing.Point(8, 21);
            this.DGVempresas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DGVempresas.Name = "DGVempresas";
            this.DGVempresas.Size = new System.Drawing.Size(448, 150);
            this.DGVempresas.TabIndex = 6;
            this.DGVempresas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVempresas_CellClick);
            // 
            // btnModificarE
            // 
            this.btnModificarE.Location = new System.Drawing.Point(144, 182);
            this.btnModificarE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificarE.Name = "btnModificarE";
            this.btnModificarE.Size = new System.Drawing.Size(78, 30);
            this.btnModificarE.TabIndex = 5;
            this.btnModificarE.Text = "Modificar";
            this.btnModificarE.UseVisualStyleBackColor = true;
            this.btnModificarE.Click += new System.EventHandler(this.btnModificarE_Click);
            // 
            // btneEliminarE
            // 
            this.btneEliminarE.Location = new System.Drawing.Point(230, 181);
            this.btneEliminarE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btneEliminarE.Name = "btneEliminarE";
            this.btneEliminarE.Size = new System.Drawing.Size(71, 30);
            this.btneEliminarE.TabIndex = 4;
            this.btneEliminarE.Text = "Eliminar";
            this.btneEliminarE.UseVisualStyleBackColor = true;
            this.btneEliminarE.Click += new System.EventHandler(this.btneEliminarE_Click);
            // 
            // btnConsultarE
            // 
            this.btnConsultarE.Location = new System.Drawing.Point(309, 182);
            this.btnConsultarE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsultarE.Name = "btnConsultarE";
            this.btnConsultarE.Size = new System.Drawing.Size(78, 30);
            this.btnConsultarE.TabIndex = 3;
            this.btnConsultarE.Text = "Consultar";
            this.btnConsultarE.UseVisualStyleBackColor = true;
            this.btnConsultarE.Click += new System.EventHandler(this.btnConsultarE_Click);
            // 
            // btnAgregarE
            // 
            this.btnAgregarE.Location = new System.Drawing.Point(68, 181);
            this.btnAgregarE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregarE.Name = "btnAgregarE";
            this.btnAgregarE.Size = new System.Drawing.Size(68, 30);
            this.btnAgregarE.TabIndex = 1;
            this.btnAgregarE.Text = "Agregar";
            this.btnAgregarE.UseVisualStyleBackColor = true;
            this.btnAgregarE.Click += new System.EventHandler(this.btnAgregarE_Click);
            // 
            // groupDatEmpresas
            // 
            this.groupDatEmpresas.Controls.Add(this.label9);
            this.groupDatEmpresas.Controls.Add(this.boxFiscal);
            this.groupDatEmpresas.Controls.Add(this.label6);
            this.groupDatEmpresas.Controls.Add(this.boxCuentaE);
            this.groupDatEmpresas.Controls.Add(this.txtNombreE);
            this.groupDatEmpresas.Controls.Add(this.label7);
            this.groupDatEmpresas.Controls.Add(this.txtDirecE);
            this.groupDatEmpresas.Controls.Add(this.label8);
            this.groupDatEmpresas.Controls.Add(this.txtCUIT);
            this.groupDatEmpresas.Controls.Add(this.label10);
            this.groupDatEmpresas.Controls.Add(this.btnCancelarE);
            this.groupDatEmpresas.Controls.Add(this.button7);
            this.groupDatEmpresas.Controls.Add(this.btnGuardarE);
            this.groupDatEmpresas.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupDatEmpresas.Location = new System.Drawing.Point(495, 256);
            this.groupDatEmpresas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupDatEmpresas.Name = "groupDatEmpresas";
            this.groupDatEmpresas.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupDatEmpresas.Size = new System.Drawing.Size(406, 224);
            this.groupDatEmpresas.TabIndex = 13;
            this.groupDatEmpresas.TabStop = false;
            this.groupDatEmpresas.Text = "Registro de empresa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(11, 123);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Situacion fiscal:";
            // 
            // boxFiscal
            // 
            this.boxFiscal.FormattingEnabled = true;
            this.boxFiscal.Items.AddRange(new object[] {
            "Monotributo",
            "Responsable inscripto"});
            this.boxFiscal.Location = new System.Drawing.Point(144, 116);
            this.boxFiscal.Name = "boxFiscal";
            this.boxFiscal.Size = new System.Drawing.Size(131, 22);
            this.boxFiscal.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo de cuenta:";
            // 
            // boxCuentaE
            // 
            this.boxCuentaE.FormattingEnabled = true;
            this.boxCuentaE.Items.AddRange(new object[] {
            "Pesos AR$",
            "Dolares US$"});
            this.boxCuentaE.Location = new System.Drawing.Point(131, 144);
            this.boxCuentaE.Name = "boxCuentaE";
            this.boxCuentaE.Size = new System.Drawing.Size(131, 22);
            this.boxCuentaE.TabIndex = 9;
            // 
            // txtNombreE
            // 
            this.txtNombreE.Location = new System.Drawing.Point(79, 56);
            this.txtNombreE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(277, 22);
            this.txtNombreE.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(13, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nombre: ";
            // 
            // txtDirecE
            // 
            this.txtDirecE.Location = new System.Drawing.Point(97, 88);
            this.txtDirecE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDirecE.Name = "txtDirecE";
            this.txtDirecE.Size = new System.Drawing.Size(259, 22);
            this.txtDirecE.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Direccion:";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(61, 27);
            this.txtCUIT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(295, 22);
            this.txtCUIT.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(13, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "CUIT: ";
            // 
            // btnCancelarE
            // 
            this.btnCancelarE.Location = new System.Drawing.Point(306, 181);
            this.btnCancelarE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelarE.Name = "btnCancelarE";
            this.btnCancelarE.Size = new System.Drawing.Size(92, 30);
            this.btnCancelarE.TabIndex = 3;
            this.btnCancelarE.Text = "Cancelar";
            this.btnCancelarE.UseVisualStyleBackColor = true;
            this.btnCancelarE.Click += new System.EventHandler(this.btnCancelarE_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(666, 429);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 30);
            this.button7.TabIndex = 2;
            this.button7.Text = "Cerrar";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btnGuardarE
            // 
            this.btnGuardarE.Location = new System.Drawing.Point(11, 182);
            this.btnGuardarE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardarE.Name = "btnGuardarE";
            this.btnGuardarE.Size = new System.Drawing.Size(92, 30);
            this.btnGuardarE.TabIndex = 1;
            this.btnGuardarE.Text = "Guardar";
            this.btnGuardarE.UseVisualStyleBackColor = true;
            this.btnGuardarE.Click += new System.EventHandler(this.btnGuardarE_Click);
            // 
            // BoxPersona
            // 
            this.BoxPersona.Controls.Add(this.lblCuenta);
            this.BoxPersona.Controls.Add(this.txtSaldoP);
            this.BoxPersona.Controls.Add(this.lblTipo);
            this.BoxPersona.Controls.Add(this.lblSaldoP);
            this.BoxPersona.Controls.Add(this.btnExtraerP);
            this.BoxPersona.Controls.Add(this.button2);
            this.BoxPersona.Controls.Add(this.btnDepositarP);
            this.BoxPersona.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoxPersona.Location = new System.Drawing.Point(909, 14);
            this.BoxPersona.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BoxPersona.Name = "BoxPersona";
            this.BoxPersona.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BoxPersona.Size = new System.Drawing.Size(366, 196);
            this.BoxPersona.TabIndex = 13;
            this.BoxPersona.TabStop = false;
            this.BoxPersona.Text = "Saldo persona";
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCuenta.Location = new System.Drawing.Point(8, 33);
            this.lblCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(126, 15);
            this.lblCuenta.TabIndex = 14;
            this.lblCuenta.Text = "Número de cuenta:";
            // 
            // txtSaldoP
            // 
            this.txtSaldoP.Location = new System.Drawing.Point(17, 129);
            this.txtSaldoP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSaldoP.Name = "txtSaldoP";
            this.txtSaldoP.Size = new System.Drawing.Size(241, 22);
            this.txtSaldoP.TabIndex = 13;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.Location = new System.Drawing.Point(8, 65);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(119, 15);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo de cuenta: ";
            // 
            // lblSaldoP
            // 
            this.lblSaldoP.AutoSize = true;
            this.lblSaldoP.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldoP.Location = new System.Drawing.Point(8, 95);
            this.lblSaldoP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldoP.Name = "lblSaldoP";
            this.lblSaldoP.Size = new System.Drawing.Size(119, 15);
            this.lblSaldoP.TabIndex = 8;
            this.lblSaldoP.Text = "Saldo actual: $0";
            // 
            // btnExtraerP
            // 
            this.btnExtraerP.Location = new System.Drawing.Point(266, 149);
            this.btnExtraerP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExtraerP.Name = "btnExtraerP";
            this.btnExtraerP.Size = new System.Drawing.Size(92, 30);
            this.btnExtraerP.TabIndex = 3;
            this.btnExtraerP.Text = "Extraer";
            this.btnExtraerP.UseVisualStyleBackColor = true;
            this.btnExtraerP.Click += new System.EventHandler(this.btnExtraerP_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(666, 429);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnDepositarP
            // 
            this.btnDepositarP.Location = new System.Drawing.Point(266, 105);
            this.btnDepositarP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDepositarP.Name = "btnDepositarP";
            this.btnDepositarP.Size = new System.Drawing.Size(92, 30);
            this.btnDepositarP.TabIndex = 1;
            this.btnDepositarP.Text = "Depositar";
            this.btnDepositarP.UseVisualStyleBackColor = true;
            this.btnDepositarP.Click += new System.EventHandler(this.btnDepositarP_Click);
            // 
            // BoxEmpresa
            // 
            this.BoxEmpresa.Controls.Add(this.lblCUIT);
            this.BoxEmpresa.Controls.Add(this.txtSaldoE);
            this.BoxEmpresa.Controls.Add(this.lblTipoE);
            this.BoxEmpresa.Controls.Add(this.lblSaldoE);
            this.BoxEmpresa.Controls.Add(this.btnExtraerE);
            this.BoxEmpresa.Controls.Add(this.button3);
            this.BoxEmpresa.Controls.Add(this.btnDepositarE);
            this.BoxEmpresa.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoxEmpresa.Location = new System.Drawing.Point(909, 256);
            this.BoxEmpresa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BoxEmpresa.Name = "BoxEmpresa";
            this.BoxEmpresa.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BoxEmpresa.Size = new System.Drawing.Size(366, 196);
            this.BoxEmpresa.TabIndex = 15;
            this.BoxEmpresa.TabStop = false;
            this.BoxEmpresa.Text = "Saldo empresa";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCUIT.Location = new System.Drawing.Point(9, 33);
            this.lblCUIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(112, 15);
            this.lblCUIT.TabIndex = 14;
            this.lblCUIT.Text = "Número de CUIT:";
            // 
            // txtSaldoE
            // 
            this.txtSaldoE.Location = new System.Drawing.Point(17, 129);
            this.txtSaldoE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSaldoE.Name = "txtSaldoE";
            this.txtSaldoE.Size = new System.Drawing.Size(241, 22);
            this.txtSaldoE.TabIndex = 13;
            // 
            // lblTipoE
            // 
            this.lblTipoE.AutoSize = true;
            this.lblTipoE.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoE.Location = new System.Drawing.Point(9, 65);
            this.lblTipoE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoE.Name = "lblTipoE";
            this.lblTipoE.Size = new System.Drawing.Size(119, 15);
            this.lblTipoE.TabIndex = 10;
            this.lblTipoE.Text = "Tipo de cuenta: ";
            // 
            // lblSaldoE
            // 
            this.lblSaldoE.AutoSize = true;
            this.lblSaldoE.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldoE.Location = new System.Drawing.Point(9, 95);
            this.lblSaldoE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldoE.Name = "lblSaldoE";
            this.lblSaldoE.Size = new System.Drawing.Size(119, 15);
            this.lblSaldoE.TabIndex = 8;
            this.lblSaldoE.Text = "Saldo actual: $0";
            // 
            // btnExtraerE
            // 
            this.btnExtraerE.Location = new System.Drawing.Point(266, 149);
            this.btnExtraerE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExtraerE.Name = "btnExtraerE";
            this.btnExtraerE.Size = new System.Drawing.Size(92, 30);
            this.btnExtraerE.TabIndex = 3;
            this.btnExtraerE.Text = "Extraer";
            this.btnExtraerE.UseVisualStyleBackColor = true;
            this.btnExtraerE.Click += new System.EventHandler(this.btnExtraerE_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(666, 429);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnDepositarE
            // 
            this.btnDepositarE.Location = new System.Drawing.Point(266, 105);
            this.btnDepositarE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDepositarE.Name = "btnDepositarE";
            this.btnDepositarE.Size = new System.Drawing.Size(92, 30);
            this.btnDepositarE.TabIndex = 1;
            this.btnDepositarE.Text = "Depositar";
            this.btnDepositarE.UseVisualStyleBackColor = true;
            this.btnDepositarE.Click += new System.EventHandler(this.btnDepositarE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 505);
            this.Controls.Add(this.BoxEmpresa);
            this.Controls.Add(this.BoxPersona);
            this.Controls.Add(this.groupDatEmpresas);
            this.Controls.Add(this.groupEmpresa);
            this.Controls.Add(this.groupDatPersonas);
            this.Controls.Add(this.groupPersonal);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes del banco";
            this.groupPersonal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVpersonas)).EndInit();
            this.groupDatPersonas.ResumeLayout(false);
            this.groupDatPersonas.PerformLayout();
            this.groupEmpresa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVempresas)).EndInit();
            this.groupDatEmpresas.ResumeLayout(false);
            this.groupDatEmpresas.PerformLayout();
            this.BoxPersona.ResumeLayout(false);
            this.BoxPersona.PerformLayout();
            this.BoxEmpresa.ResumeLayout(false);
            this.BoxEmpresa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPersonal;
        private System.Windows.Forms.DataGridView DGVpersonas;
        private System.Windows.Forms.Button btnModificarP;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.Button btnConsultarP;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.GroupBox groupDatPersonas;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarP;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnGuardarP;
        private System.Windows.Forms.GroupBox groupEmpresa;
        private System.Windows.Forms.DataGridView DGVempresas;
        private System.Windows.Forms.Button btnModificarE;
        private System.Windows.Forms.Button btneEliminarE;
        private System.Windows.Forms.Button btnConsultarE;
        private System.Windows.Forms.Button btnAgregarE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox BoxcuentaP;
        private System.Windows.Forms.GroupBox groupDatEmpresas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox boxCuentaE;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDirecE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancelarE;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnGuardarE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox boxFiscal;
        private System.Windows.Forms.GroupBox BoxPersona;
        private System.Windows.Forms.TextBox txtSaldoP;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblSaldoP;
        private System.Windows.Forms.Button btnExtraerP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDepositarP;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.GroupBox BoxEmpresa;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.TextBox txtSaldoE;
        private System.Windows.Forms.Label lblTipoE;
        private System.Windows.Forms.Label lblSaldoE;
        private System.Windows.Forms.Button btnExtraerE;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDepositarE;
    }
}

