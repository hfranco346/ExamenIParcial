using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_I_Parcial
{
    public partial class frmReview : Form
    {
        public frmReview()
        {
            InitializeComponent();
        }

        private void gbAnalisis_Enter(object sender, EventArgs e)
        {

        }

        private void frmReview_Load(object sender, EventArgs e)
        {
            List<Producto> productos = Producto.ObtenerProductosVendibles();

            if (productos.Any())
            {
                productos.ForEach(producto => lstProductos.Items.Add(producto.name));
            }
            else
                lstProductos.Items.Add("¡Error al momento de cargar los productos!");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Review analisis = new Review();

            if (lstProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Favor seleccionar un producto antes de guardar el análisis.", "Información");
            }
            else
            {
                try
                {
                    analisis.productId = Producto.CodigoProducto(lstProductos.SelectedItem.ToString());
                    analisis.reviewerName = txtNombre.Text.ToString();
                    analisis.emailAddress = txtEmail.Text.ToString();
                    analisis.rating = int.Parse(txtValor.Text.ToString());
                    analisis.comments = txtComentarios.Text.ToString();
                    analisis.reviewDate = DateTime.Now;
                    analisis.modifiedDate = DateTime.Now;

                    if (analisis.rating > 5 || analisis.rating < 0)
                    {
                        throw new CustomException("El rango permitido para la valoración está entre 0 y 5");
                    }
                    else if (Review.InsertarReview(analisis))
                    {
                        MessageBox.Show("¡Su análisis ha sido registrado con éxito!", "Información");
                    }
                    else
                    {
                        throw new CustomException("Hubo un error al momento de ingresar su análisis...");
                    }
                }
                catch(FormatException)
                {
                    MessageBox.Show("Sólo se permiten valores en el rango entre 0 y 5", "Información");
                }
                catch (CustomException ex)
                {
                    MessageBox.Show(ex.Message, "Información");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
