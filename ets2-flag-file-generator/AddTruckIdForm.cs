using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ets2FlagFileGenerator
{
    public partial class AddTruckIdForm : Form {
        private readonly MainForm mainForm;

        public AddTruckIdForm(MainForm mainForm) {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e) {
            string truckId = TruckIdTextbox.Text;

            if (truckId.Trim() == string.Empty) {
                MessageBox.Show("The truck ID cannot be blank!", "Truck ID Cannot Be Blank", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
                return;
            }

            mainForm.AddTruckIdToList(truckId);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
