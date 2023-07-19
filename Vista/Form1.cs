using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Form1 : Form
    {
        // variables temporales para crear objetos del modelo
        private Biblioteca.Banco oBanco;
        private Biblioteca.BancaEmpresa oEmpresa;
        private Biblioteca.BancaPersonal oPersona;

        private string groups; // variable para habilitar/deshabilitar groups

        public Form1()
        {
            InitializeComponent();
            oBanco = new Biblioteca.Banco(); // creo lista vacia en memoria
            ModoGrillas();
            BoxPersona.Enabled = false;
            BoxEmpresa.Enabled = false;
        }
        private void ModoGrillas() // habilito los group con DGV
        {
            groupDatEmpresas.Enabled = false;
            groupDatPersonas.Enabled = false;
            groupEmpresa.Enabled = true;
            groupPersonal.Enabled = true;
        }
        private void ArmarGrillas()
        {
            DGVempresas.DataSource = null; // limpio fuente de datos antes de cargar
            DGVpersonas.DataSource = null;
            DGVempresas.DataSource = oBanco.Empresas; // enlazo listas como fuente de datos del DGV
            DGVpersonas.DataSource = oBanco.Personas;
        }
        private void ModoDatosP() // habilito los group de datos
        {
            groupPersonal.Enabled = false;
            groupDatPersonas.Enabled = true;
            if (groups == "CP") // "CP" = conultar personas
            {
                btnGuardarP.Enabled = false; // deshabilito los botones guardar
            }
            else
            {
                btnGuardarP.Enabled = true; // habilito
            }
        }
        private void ModoDatosE()
        {
            groupEmpresa.Enabled = false;
            groupDatEmpresas.Enabled = true;
            if (groups == "CE") // "CE" = conultar empresas
            {
                btnGuardarE.Enabled = false;
            }
            else
            {
                btnGuardarE.Enabled = true;
            }
        }
        private void Clean() // limpio txt
        {
            // persona                        // empresa
            txtCuenta.Text = ""; txtCUIT.Text = "";
            txtDNI.Text = ""; txtNombreE.Text = "";
            txtNombre.Text = ""; txtDirecE.Text = "";
            txtApellido.Text = ""; boxCuentaE.Text = "";
            txtFecha.Text = ""; boxFiscal.Text = "";
            BoxcuentaP.Text = "";
        }

        // botones agregar
        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            oPersona = new Biblioteca.BancaPersonal(); // creo objeto persona

            groups = "AP"; // "AP" = agregar personas

            ModoDatosP(); // manejo de groups
        }
        private void btnAgregarE_Click(object sender, EventArgs e)
        {
            oEmpresa = new Biblioteca.BancaEmpresa();

            groups = "AE"; // "AE" = agregar empresas

            ModoDatosE();
        }

        // botones modificar
        private void btnModificarP_Click(object sender, EventArgs e)
        {
            if (DGVpersonas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar a una persona de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // completo 
            oPersona = (Biblioteca.BancaPersonal)DGVpersonas.CurrentRow.DataBoundItem; // asigno a la variable el objeto Persona correspondiente a la fila seleccionada
            txtCuenta.Text = oPersona.NumCuenta.ToString();
            txtDNI.Text = oPersona.getDNI().ToString();
            txtNombre.Text = oPersona.getNombre();
            txtApellido.Text = oPersona.getApellido();
            txtFecha.Text = oPersona.getNacimiento();
            BoxcuentaP.Text = oPersona.Moneda;

            groups = "MP"; // "MP" = modificar personas

            ModoDatosP();
        }
        private void btnModificarE_Click(object sender, EventArgs e)
        {
            if (DGVempresas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar a una empresa de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // completo 
            oEmpresa = (Biblioteca.BancaEmpresa)DGVempresas.CurrentRow.DataBoundItem; // asigno a la variable el objeto Empresa correspondiente a la fila seleccionada
            txtCUIT.Text = oEmpresa.CUIT.ToString();
            txtNombreE.Text = oEmpresa.Nombre;
            txtDirecE.Text = oEmpresa.getDireccion();
            boxCuentaE.Text = oEmpresa.Moneda;

            groups = "ME"; // "ME" = modificar empresas

            ModoDatosE();
        }

        // botones eliminar
        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            if (DGVpersonas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar a una persona de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            oPersona = (Biblioteca.BancaPersonal)DGVpersonas.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("¿Confima que desea eliminar a la cuenta n°: " + oPersona.NumCuenta + " de la lista?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                oBanco.Personas.Remove(oPersona); // elimino objeto de la lista
                ArmarGrillas(); // update grillas
            }
        }
        private void btneEliminarE_Click(object sender, EventArgs e)
        {
            if (DGVempresas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar a una empresa de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            oEmpresa = (Biblioteca.BancaEmpresa)DGVempresas.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("¿Confima que desea eliminar a la empresa: " + oEmpresa.Nombre + " de la lista?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                oBanco.Empresas.Remove(oEmpresa);
                ArmarGrillas();
            }
        }

        // botones consultar
        private void btnConsultarP_Click(object sender, EventArgs e)
        {
            if (DGVpersonas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar a una persona de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // completo 
            oPersona = (Biblioteca.BancaPersonal)DGVpersonas.CurrentRow.DataBoundItem;
            txtCuenta.Text = oPersona.NumCuenta.ToString();
            txtDNI.Text = oPersona.getDNI().ToString();
            txtNombre.Text = oPersona.getNombre();
            txtApellido.Text = oPersona.getApellido();
            txtFecha.Text = oPersona.getNacimiento();
            BoxcuentaP.Text = oPersona.Moneda;

            groups = "CP"; // "CP" = consulta personas

            ModoDatosP();
        }
        private void btnConsultarE_Click(object sender, EventArgs e)
        {
            if (DGVempresas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar a una empresa de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // completo 
            oEmpresa = (Biblioteca.BancaEmpresa)DGVempresas.CurrentRow.DataBoundItem;
            txtCUIT.Text = oEmpresa.CUIT.ToString();
            txtNombreE.Text = oEmpresa.Nombre;
            txtDirecE.Text = oEmpresa.getDireccion();
            boxCuentaE.Text = oEmpresa.Moneda;

            groups = "CE"; // "CE" = consulta empresas

            ModoDatosE();
        }

        // metodo para verificar la repeticion de personas
        public bool Repeticion(int dni, int cuenta)
        {
            foreach (var persona in oBanco.Personas)
            {
                if (persona.NumCuenta == cuenta || persona.getDNI() == dni)
                {
                    return true;
                }
            }
            return false;
        }

        // botones guardar
        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (txtCuenta.Text == "" || txtDNI.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtFecha.Text == "" || BoxcuentaP.Text == "")
            {
                MessageBox.Show("Hay campos vacios, debe completarlos para continuar...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int cuenta;
            if (!int.TryParse(txtCuenta.Text, out cuenta)) // Si no ingresa un número
            {
                MessageBox.Show("Ingrese un número de cuenta valido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int dni;
            if (!int.TryParse(txtDNI.Text, out dni)) // Si no ingresa un número
            {
                MessageBox.Show("Ingrese un número de DNI valido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime Fecha;
            if (!DateTime.TryParse(txtFecha.Text, out Fecha)) // valido formato de fecha
            {
                MessageBox.Show("Ingrese la fecha de nacimiento correctamente...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("La fecha de nacimiento debe tener formato de fecha (xx-xx-xxxx)", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            #endregion

            // asigno a los atributos del objeto
            oPersona.NumCuenta = Convert.ToInt32(txtCuenta.Text);
            oPersona.setDNI(dni);
            oPersona.setNombre(txtNombre.Text);
            oPersona.setApellido(txtApellido.Text);
            oPersona.setNacimiento(Fecha);
            oPersona.Moneda = BoxcuentaP.Text;

            if (groups == "AP") // agrego la persona al banco, si el groups esta en agregar
            {
                if (oPersona.Edad < 18)
                {
                    MessageBox.Show("La persona es menor de 18 años...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Repeticion(int.Parse(txtDNI.Text), int.Parse(txtCuenta.Text)) == true)
                {
                    MessageBox.Show("La persona ya se encuentra registrada en el sistema!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCuenta.Text = ""; txtDNI.Text = "";
                    return;
                }

                oBanco.Personas.Add(oPersona);
            }

            ArmarGrillas();
            ModoGrillas();
            Clean();
        }
        private void btnGuardarE_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (txtCUIT.Text == "" || txtNombreE.Text == "" || txtDirecE.Text == "" || boxFiscal.Text == "" || boxCuentaE.Text == "")
            {
                MessageBox.Show("Hay campos vacios, debe completarlos para continuar...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int cuit;
            if (!int.TryParse(txtCUIT.Text, out cuit)) // Si no ingresa un número
            {
                MessageBox.Show("Ingrese un número de CUIT valido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            // asigno a los atributos del objeto
            oEmpresa.CUIT = Convert.ToInt32(txtCUIT.Text);
            oEmpresa.Nombre = txtNombreE.Text;
            oEmpresa.setDireccion(txtDirecE.Text);
            oEmpresa.setFiscal(boxFiscal.Text);
            oEmpresa.Moneda = boxCuentaE.Text;

            if (groups == "AE") // agrego la empresa al banco, si el groups esta en agregar
            {
                oBanco.Empresas.Add(oEmpresa);
            }

            ArmarGrillas();
            ModoGrillas();
            Clean();
        }

        // botones cancelar
        private void btnCancelarP_Click(object sender, EventArgs e)
        {
            Clean();
            ModoGrillas();
        }
        private void btnCancelarE_Click(object sender, EventArgs e)
        {
            Clean();
            ModoGrillas();
        }

        // metodo para mostrar los datos de la persona seleccionada
        public void MostrarP()
        {
            oPersona = (Biblioteca.BancaPersonal)DGVpersonas.CurrentRow.DataBoundItem;
            lblCuenta.Text = "Número de cuenta: " + oPersona.NumCuenta;
            lblSaldoP.Text = "Saldo actual: $ " + oPersona.Saldo;
            lblTipo.Text = "Tipo de cuenta: " + oPersona.Moneda;
        }
        // metodo para msotrar los datos de la empresa seleccionada
        public void MostrarE()
        {
            oEmpresa = (Biblioteca.BancaEmpresa)DGVempresas.CurrentRow.DataBoundItem;
            lblSaldoE.Text = "Saldo actual: $ " + oEmpresa.Saldo;
            lblCUIT.Text = "Número de CUIT: " + oEmpresa.CUIT;
            lblTipoE.Text = "Tipo de cuenta: " + oEmpresa.Moneda;
        }
        private void DGVpersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) // verificar que este seleccionando una fila
            {
                BoxPersona.Enabled = true;
                MostrarP();
            }
        }
        private void DGVempresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                BoxEmpresa.Enabled = true;
                MostrarE();
            }
        }

        // botones depositar
        private void btnDepositarP_Click(object sender, EventArgs e)
        {
            if (DGVpersonas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar a una persona de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSaldoP.Text == "")
            {
                MessageBox.Show("Debe ingresar un número para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                oPersona = (Biblioteca.BancaPersonal)DGVpersonas.CurrentRow.DataBoundItem;
                int saldo;
                if (!int.TryParse(txtSaldoP.Text, out saldo)) // Si no ingresa un número
                {
                    MessageBox.Show("Ingrese un número de deposito valido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSaldoP.Text = "";
                    return;
                }
                else
                {
                    saldo = Convert.ToInt32(txtSaldoP.Text);
                }
                if (saldo == 0)
                {
                    MessageBox.Show("Debe colocar un número mayor a 0 para continuar con esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (saldo > 99999)
                {
                    MessageBox.Show("El limite maximo de deposito en este banco es de $99.999", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    oPersona.Depositar(saldo);
                    ArmarGrillas();
                    MessageBox.Show("El deposito se realizo con exito!", "Gracias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSaldoP.Text = "";
                    lblCuenta.Text = "Número de cuenta: ";
                    lblSaldoP.Text = "Saldo actual: $ ";
                    lblTipo.Text = "Tipo de cuenta: ";
                    BoxPersona.Enabled = false;
                }
            }  
        }
        private void btnDepositarE_Click(object sender, EventArgs e)
        {
            if (DGVempresas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar a una empresa de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSaldoE.Text == "")
            {
                MessageBox.Show("Debe ingresar un número para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                oEmpresa = (Biblioteca.BancaEmpresa)DGVempresas.CurrentRow.DataBoundItem;
                int saldo;
                if (!int.TryParse(txtSaldoE.Text, out saldo)) // Si no ingresa un número
                {
                    MessageBox.Show("Ingrese un número de deposito valido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSaldoE.Text = "";
                    return;
                }
                else
                {
                    saldo = Convert.ToInt32(txtSaldoE.Text);
                }
                if (saldo == 0)
                {
                    MessageBox.Show("Debe colocar un número mayor a 0 para continuar con esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (saldo > 99999)
                {
                    MessageBox.Show("El limite maximo de deposito en este banco es de $99.999", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    oEmpresa.Depositar(saldo);
                    ArmarGrillas();
                    MessageBox.Show("El deposito se realizo con exito!", "Gracias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSaldoE.Text = "";
                    lblSaldoE.Text = "Saldo actual: $ ";
                    lblCUIT.Text = "Número de CUIT: ";
                    lblTipoE.Text = "Tipo de cuenta: ";
                    BoxEmpresa.Enabled = false;
                }
            }
        }

        // botones exxtraer
        private void btnExtraerP_Click(object sender, EventArgs e)
        {
            if (DGVpersonas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar a una persona de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSaldoP.Text == "")
            {
                MessageBox.Show("Debe ingresar un número para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                oPersona = (Biblioteca.BancaPersonal)DGVpersonas.CurrentRow.DataBoundItem;
                int saldo;
                if (!int.TryParse(txtSaldoP.Text, out saldo)) // Si no ingresa un número
                {
                    MessageBox.Show("Ingrese un número de deposito valido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSaldoP.Text = "";
                    return;
                }
                else
                {
                    saldo = Convert.ToInt32(txtSaldoP.Text);
                }
                if (saldo == 0)
                {
                    MessageBox.Show("Debe colocar un número mayor a 0 para continuar con esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (oPersona.Extraer(saldo) == false)
                {
                    MessageBox.Show("Su saldo es insuficiente...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    oPersona.Extraer(saldo);
                    ArmarGrillas();
                    MessageBox.Show("La extraccion se realizo con exito!", "Gracias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSaldoP.Text = "";
                    lblCuenta.Text = "Número de cuenta: ";
                    lblSaldoP.Text = "Saldo actual: $ ";
                    lblTipo.Text = "Tipo de cuenta: ";
                    BoxPersona.Enabled = false;
                }
            }
        }
        private void btnExtraerE_Click(object sender, EventArgs e)
        {
            if (DGVempresas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar a una empresa de la lista para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSaldoE.Text == "")
            {
                MessageBox.Show("Debe ingresar un número para utilizar esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                oEmpresa = (Biblioteca.BancaEmpresa)DGVempresas.CurrentRow.DataBoundItem;
                int saldo;
                if (!int.TryParse(txtSaldoE.Text, out saldo)) // Si no ingresa un número
                {
                    MessageBox.Show("Ingrese un número de deposito valido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSaldoE.Text = "";
                    return;
                }
                else
                {
                    saldo = Convert.ToInt32(txtSaldoE.Text);
                }
                if (saldo == 0)
                {
                    MessageBox.Show("Debe colocar un número mayor a 0 para continuar con esta función...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (oPersona.Extraer(saldo) == false)
                {
                    MessageBox.Show("Su saldo es insuficiente...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    oEmpresa.Extraer(saldo);
                    ArmarGrillas();
                    MessageBox.Show("La extraccion se realizo con exito!", "Gracias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSaldoE.Text = "";
                    lblSaldoE.Text = "Saldo actual: $ ";
                    lblCUIT.Text = "Número de CUIT: ";
                    lblTipoE.Text = "Tipo de cuenta: ";
                    BoxEmpresa.Enabled = false;
                }
            }
        }

        // validaciones de teclado
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No puedes ingresar números en el nombre...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No puedes ingresar números en el apellido...", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}