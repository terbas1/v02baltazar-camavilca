using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace PjConexion3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Baltazar"].ConnectionString);

        public void ListaProductos()
        {
            using (SqlDataAdapter Df = new SqlDataAdapter("Usp_ListaProductos_Neptuno", cn))
            {
                Df.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataSet Da = new DataSet())
                {
                    Df.Fill(Da, "Productos");
                    DgProductos.DataSource = Da.Tables["Productos"];
                    LblCantidad.Text = Da.Tables["Productos"].Rows.Count.ToString();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LblCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaProductos();
        }
    }
}
