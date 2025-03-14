using GestionEmpleados;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace Gestion_empleados
{
    public partial class Form1 : Form
    {
        private Empresa empresa;
        private readonly BindingSource bindingSource;
        private DataGridView dgvEmpleados; // Cambiar el tipo de object a DataGridView
        private TextBox txt_nombre; // Cambiar el tipo de object a TextBox
        private TextBox txt_apellido; // Cambiar el tipo de object a TextBox
        private TextBox txt_edad; // Cambiar el tipo de object a TextBox
        private TextBox txt_salario; // Cambiar el tipo de object a TextBox
        private ComboBox cmbcargo; // Cambiar el tipo de object a ComboBox
        private ListBox lstEmpleados; // Cambiar el tipo de object a ListBox
        private object empleados;
        private Button btn_actualizar; // Cambiar el tipo de object a Button

        public string cargo { get; private set; }

        public Form1()
        {
            InitializeComponent();
            empresa = new Empresa();
            bindingSource = new BindingSource();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (dgvEmpleado != null)

            {
                bindingSource.DataSource = empresa.Empleados;
                dgvEmpleado.DataSource = bindingSource;
            }
            else
            {
                MessageBox.Show("No se ha encontrado el control DataGridView", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txt_nombre.Text;
                string apellido = txt_apellido.Text;
                int edad = int.Parse(txt_edad.Text);
                decimal salario = decimal.Parse(txt_salario.Text);
                string cargo = cmb_cargo.Text;

                txt_nombre.Text = nombre;
                txt_apellido.Text = apellido;
                txt_edad.Text = edad.ToString();
                txt_salario.Text = salario.ToString();
                cmb_cargo.Text = cargo;

                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(cargo))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Empleado nuevoEmpleado = null; // Inicializar la variable

                if (cargo == "Administrativo")
                {
                    nuevoEmpleado = new Administrativo(nombre, apellido, edad, salario);
                }
                else if (cargo == "Tecnico")
                {
                    nuevoEmpleado = new Tecnico(nombre, apellido, edad, salario);
                }
                else
                {
                    MessageBox.Show("Seleccione un cargo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                empresa.RegistrarEmpleado(nuevoEmpleado);
                dgvEmpleado.DataSource = null;
                dgvEmpleado.DataSource = empresa.Empleados;
                txt_nombre.Clear();
                txt_apellido.Clear();
                txt_edad.Clear();
                txt_salario.Clear();
                cmb_cargo.SelectedIndex = -1;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleado.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este empleado?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int index = dgvEmpleado.SelectedRows[0].Index;
                empresa.eliminarEmpleado(index);
                dgvEmpleado.DataSource = null;
                dgvEmpleado.DataSource = empresa.Empleados;
            }
        }
        

        public void eliminarEmpleado(int index)
        {
            if (index >= 0 && index < empresa.Empleados.Count)
            {
                empresa.eliminarEmpleado(index);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Índice fuera de rango");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargo == "Administrativo") ;
            if (cargo == " Tecnico") ;
        }
    }
}

