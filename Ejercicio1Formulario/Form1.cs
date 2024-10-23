using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1Formulario
{
    public partial class VentanaPrincipal : Form
    {
        DateTime? fechaSeleccionada;

        public VentanaPrincipal()
        {
            InitializeComponent();
            cbType.SelectedIndex = 0;
            cbCriticy.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
            cbPercent.SelectedIndex = 0;
        }

        private void bSumbit_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != string.Empty &&
                txtDescription.Text != string.Empty &&
                (cbProd.Checked || cbPreprod.Checked || cbDemo.Checked))
            {
                string textoFecha = fechaSeleccionada.HasValue
                    ? fechaSeleccionada.Value.ToString("dd/MM/yyyy")
                    : "No se ha seleccionado ninguna fecha";

                string textoLocation = cbLocation.SelectedItem != null
                    ? cbLocation.SelectedItem.ToString()
                    : "null";

                MessageBox.Show(
                    lblTitle.Text + ": " + txtTitle.Text + "\n"
                    + lblLocation.Text + ": " + textoLocation + "\n"
                    + lblType.Text + ": " + cbType.SelectedItem?.ToString() + "\n"
                    + lblCriticity.Text + ": " + cbCriticy.SelectedItem?.ToString() + "\n"
                    + lblEnvironment.Text + ": "
                    + cbProd.Text + " - " + cbProd.CheckState
                    + ", " + cbPreprod.Text + " - " + cbPreprod.CheckState
                    + ", " + cbDemo.Text + " - " + cbDemo.CheckState + "\n"
                    + lblDescription.Text + ": " + txtDescription.Text + "\n"
                    + lblSartDate.Text + ": " + textoFecha + "\n"
                    + lblDuration.Text + ": " + numDuation.Value + "\n"
                    + lblStatus.Text + ": " + cbStatus.SelectedItem?.ToString() + "\n"
                    + lblPercent.Text + ": " + cbPercent.SelectedItem?.ToString() + "\n"
                    + "CB Email: " + cbEmail.Checked.ToString() + "\n"
                );
            }
            else
            {
                MessageBox.Show(
                    "Title, Description &\n" +
                    "1 of the checkboxes\n" +
                    "can't be empty"
                );
            }
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!datePicker.Checked)
                fechaSeleccionada = null;
            else
                fechaSeleccionada = datePicker.Value;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
