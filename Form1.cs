using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ListarCategorias();
            ListarMarcas();
            ListarProductos();
        }
        private void ListarProductos()
        {
            ClsProductos objprod = new ClsProductos();
            dataGridView1.DataSource = objprod.ListarProductos();
        }
        private void ListarCategorias()
        {
            ClsProductos objProd = new ClsProductos();
            CmbCategoria.DataSource = objProd.ListarCategorias();
            CmbCategoria.DisplayMember = "CATEGORIA";
            CmbCategoria.ValueMember = "IDCATEG";
        }
        private void ListarMarcas()
        {
            ClsProductos objProd = new ClsProductos();
            CmbMarca.DataSource = objProd.ListarMarcas();
            CmbMarca.DisplayMember = "MARCA";
            CmbMarca.ValueMember = "IDMARCA";
        }
        ClsProductos objproducto = new ClsProductos();
        private void button1_Click(object sender, EventArgs e)
        {
            objproducto.InsertarProductos(
       Convert.ToInt32(CmbCategoria.SelectedValue),
       Convert.ToInt32(CmbMarca.SelectedValue),
       textBox1.Text,
       Convert.ToDouble(textBox2.Text)
       );
            MessageBox.Show("Se inserto correctamente");
            ListarProductos();
        }
    }
}
