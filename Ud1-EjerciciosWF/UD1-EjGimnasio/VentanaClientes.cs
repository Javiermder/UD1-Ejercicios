using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1_EjGimnasio
{
    public partial class VentanaClientes : Form
    {
        List<Cliente> Clientes = new List<Cliente>();


        public VentanaClientes()
        {
            InitializeComponent();

        }



        private void btnAnadir_Click(object sender, EventArgs e)
        {
            Boolean camposCorrectos = comprobarCampos();
            Boolean codigoExiste = comprobarCodigo();

            if (camposCorrectos && !codigoExiste)
            {

                String codigo = txtCodigo.Text;
                String nombre = txtNombre.Text;
                String apellidos = txtApellidos.Text;
                DateTime fecha = dtpFecha.Value;
                String ciudad = txtCiudad.Text;
                String telefono = txtTelefono.Text;

                Cliente c = new Cliente(codigo, nombre, apellidos, fecha, ciudad, telefono);
                Clientes.Add(c);
                recargarLista();
                limpiarCampos();
            }
            else if (!camposCorrectos)
            {
                MessageBox.Show("Debe de rellenar todos los campos del formulario");
            }
            else
            {
                MessageBox.Show("El codigo introducido ya existe");
            }
        }

        private void limpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            dtpFecha.Value = DateTime.Now;
            txtCiudad.Text = "";
            txtTelefono.Text = "";
        }

        private Boolean comprobarCodigo()
        {

            String codigo = txtCodigo.Text;

            foreach (Cliente c in Clientes)
            {
                if (c.codigo == codigo)
                {
                    return true;
                }
            }
            return false;
        }


        private Boolean comprobarCampos()
        {

            if (string.IsNullOrEmpty(txtApellidos.Text)) { return false; }
            if (string.IsNullOrEmpty(txtCiudad.Text)) { return false; }
            if (string.IsNullOrEmpty(txtCodigo.Text)) { return false; }
            if (string.IsNullOrEmpty(txtNombre.Text)) { return false; }
            if (string.IsNullOrEmpty(dtpFecha.Text)) { return false; }

            return true;
        }

        private void recargarLista()
        {

            dgv.DataSource = null;
            dgv.DataSource = Clientes;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!comprobarCampos())
            {
                MessageBox.Show("Debe rellenar todos los campos antes de modificar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigo = txtCodigo.Text;
            bool encontrado = false;

            foreach (Cliente c in Clientes)
            {
                if (c.codigo == codigo)
                {
                    c.nombre = txtNombre.Text;
                    c.apellidos = txtApellidos.Text;
                    c.fechaNac = dtpFecha.Value;
                    c.ciudad = txtCiudad.Text;
                    c.telefono = txtTelefono.Text;

                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                recargarLista();
                limpiarCampos();
                MessageBox.Show("Cliente modificado correctamente.", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se ha encontrado ningún cliente con ese código.", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void clickEnTabla(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgv.Rows[e.RowIndex];

                string codigo = fila.Cells["codigo"].Value.ToString();
                string nombre = fila.Cells["nombre"].Value.ToString();
                string apellidos = fila.Cells["apellidos"].Value.ToString();
                DateTime fecha = Convert.ToDateTime(fila.Cells["fechaNac"].Value);
                string ciudad = fila.Cells["ciudad"].Value.ToString();
                string telefono = fila.Cells["telefono"].Value.ToString();

                txtCodigo.Text = codigo;
                txtCodigo.Enabled = false; // Deshabilitar edición del código para que no se modifique
                txtNombre.Text = nombre;
                txtApellidos.Text = apellidos;
                dtpFecha.Value = fecha;
                txtCiudad.Text = ciudad;
                txtTelefono.Text = telefono;
            }
            else
            {
                MessageBox.Show("Selecciona una fila válida primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;

            foreach (Cliente c in Clientes)
            {
                if (c.codigo == codigo)
                {
                    Clientes.Remove(c);
                    txtCodigo.Text = "";
                    txtNombre.Text = "";
                    txtApellidos.Text = "";
                    dtpFecha.Value = DateTime.Now;
                    txtCiudad.Text = "";
                    txtTelefono.Text = "";
                    recargarLista();
                    break;
                }

            }

        }

        private void btnGuardarJSON_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(Clientes);
                File.WriteAllText("clientes.json", jsonString);
                Console.WriteLine("Clientes guardados en clientes.json con éxito.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar los clientes: " + ex.Message);
            }
        }

        private void btnCargarJSON_clicked(object sender, EventArgs e)
        {
            try
            {
                //INDICAR EL NOMBRE DEL FICHERO DEL Q SACAMOS LOS DATOS
                string rutaArchivo = "clientes.json";

                if (File.Exists(rutaArchivo))
                {
                    string jsonString = File.ReadAllText(rutaArchivo);

                    //LISTA CON LOS CLIENTES CARGADOS
                    List<Cliente> clientesCargados = JsonSerializer.Deserialize<List<Cliente>>(jsonString);

                    //SI NO ES NULO Y TIENE ELEMENTOS ASIGNAMOS A LA LISTA PRINCIPAL
                    if (clientesCargados != null && clientesCargados.Count > 0)
                    {
                        Clientes = clientesCargados;
                        recargarLista();
                        Console.WriteLine("Clientes cargados correctamente desde el archivo.");
                    }
                    else
                    {
                        Console.WriteLine("El archivo está vacío o no contiene clientes válidos.");
                    }
                }
                else
                {
                    Console.WriteLine("El archivo clientes.json no existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar los clientes: " + ex.Message);
            }

        }
    }

}
