using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ets2FlagFileGenerator.Templates;

namespace Ets2FlagFileGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            bool validClick = (e.RowIndex != -1 && e.ColumnIndex != -1); //Make sure the clicked row/column is valid.
            var datagridview = sender as DataGridView;

            if (datagridview == null) {
                throw new InvalidOperationException("The sender was null, but shouldn't have been.");
            }

            // Check to make sure the cell clicked is the cell containing the combobox 
            if (datagridview.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && validClick)
            {
                datagridview.BeginEdit(true);
                ((ComboBox)datagridview.EditingControl).DroppedDown = true;
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            var browserDialog = new FolderBrowserDialog {
                ShowNewFolderButton = true
            };

            DialogResult result = browserDialog.ShowDialog();

            if (result != DialogResult.OK) {
                return;
            }

            ChosenFolderTextbox.Text = browserDialog.SelectedPath;
        }

        private void TruckIdAdd_Click(object sender, EventArgs e) {
            var addTruckDialog = new AddTruckIdForm(this);
            DialogResult result = addTruckDialog.ShowDialog();
        }

        public void AddTruckIdToList(string truckId) {
            TruckIdBox.Items.Add(truckId);
        }

        private void TruckIdRemove_Click(object sender, EventArgs e) {
            if (TruckIdBox.SelectedIndex == -1) {
                // No item selected.
                return;
            }

            TruckIdBox.Items.RemoveAt(TruckIdBox.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> truckIds = (from string truckId in TruckIdBox.Items select truckId).ToList();
            
            var rows = FlagsDataGrid.Rows;
            List<Flag> flags = (from DataGridViewRow row in rows
                where !row.IsNewRow
                select new Flag {
                    Id = GetCell(row, 0),
                    DisplayName = GetCell(row, 1),
                    TextureFilenameLeft = GetCell(row, 2),
                    TextureFilenameRight = GetCell(row, 3),
                    UiTextureFilename = GetCell(row, 4)
                }).ToList();
            
            string outputDirectory = ChosenFolderTextbox.Text;

            if (!ValidateList(truckIds, "There are no truck IDs specified. Therefore the files cannot be built!")
                || !ValidateList(flags, "There are no flags specified. Therefore the files cannot be built!")) {
                return;
            }

            if (outputDirectory.Trim() == string.Empty) {
                MessageBox.Show("The output path cannot be empty!",
                    "Cannot build files", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Processor.Process(truckIds, flags, outputDirectory);

            const string successMessage = @"Files successfully generated! Some additional instructions:

1. Your DDS files will need to be manually copied over to the output directory.
2. TOBJ files currently cannot be generated.                                   
   To solve this, download and/or open ETS2 Studio, and use the TOBJ editor.   
   You will need a TOBJ for:                                                   
      - \material\ui\accessory\flag\{UI Texture Name}.dds                            
      - \vehicle\truck\upgrade\flag\{Texture Name}.dds";

            MessageBox.Show(successMessage, "Files Successfully Generated",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static string GetCell(DataGridViewRow row, int cellIndex) {
            return (string) row.Cells[cellIndex].Value;
        }

        private static bool ValidateList(ICollection collection, string message) {
            if (collection.Count != 0) {
                return true;
            }

            MessageBox.Show(message,
                "Cannot build files", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        private void MainForm_Load(object sender, EventArgs e) {
            string[] modTrucks = ConfigurationManager.AppSettings["TruckIds"].Split('|');

            if (modTrucks[0].Trim() == string.Empty) {
                return;
            }

            foreach (string truck in modTrucks) {
                TruckIdBox.Items.Add(truck);
            }
        }
    }
}
