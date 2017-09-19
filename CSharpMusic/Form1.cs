using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpMusic
{
    public partial class Form1 : Form
    {

        //create an instance of the Database class
        Database myDatabase = new Database();

        public Form1()
        {
            InitializeComponent();
            loadDB();
        }

        public void loadDB()
        {
            //load the owner dgv
            DisplayDataGridViewOwner();
          
            //just to load the listbox with the grenres in it
            DisplayListBox();
            

        }

        //Load the owner Datagrid
        private void DisplayDataGridViewOwner()
        {
            //clear out the old data
            DGVOwner.DataSource = null;
            try
            {
                DGVOwner.DataSource = myDatabase.FillDGVOwnerWithOwner();
                //pass the datatable data to the DataGridView
                DGVOwner.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayDataGridViewCD()
        {
            //clear out the old data
            DGVCD.DataSource = null;
            try
            {
                DGVCD.DataSource = myDatabase.FillDGVCDWithCD();
                //pass the datatable data to the DataGridView
                DGVCD.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void DisplayListBox()
        {
            //clear old data out
            DGVCD.DataSource = null;
            lbgenre.DataSource = null;
            try
            {
                lbgenre.DataSource = myDatabase.FillListBoxWithGenre();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void lbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCDGenre.Text = lbgenre.SelectedItem.ToString();

        }

        private void DGVOwner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int OwnerID = 0;
            //these are the cell clicks for the values in the row that you click on
            try
            {
                OwnerID = (int)DGVOwner.Rows[e.RowIndex].Cells[0].Value;
                txtFN.Text = DGVOwner.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLN.Text = DGVOwner.Rows[e.RowIndex].Cells[2].Value.ToString();

                //if you are clicking on a row and not ouside it
                if (e.RowIndex >= 0)
                {
                    //Fill the next CD DGV with the OwnerID
                    DGVCD.DataSource = myDatabase.FillDGVCDWithOwnerClick(OwnerID.ToString());
                    DGVCD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    txtOwnerID.Text = OwnerID.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGVCD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CDID = 0;
            //these are the cell clicks for the values in the row that you click on
            try
            {
                CDID = (int)DGVCD.Rows[e.RowIndex].Cells[0].Value;
                txtCDName.Text = DGVCD.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCDArtist.Text = DGVCD.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCDGenre.Text = DGVCD.Rows[e.RowIndex].Cells[3].Value.ToString();
                //if you are cicking on a row and not outside it
                if (e.RowIndex >= 0)
                {
                    //Fill the next CD DGV with the owner ID
                    DGVCDTrack.DataSource = myDatabase.FillDGVCDWithCDClick(CDID.ToString());
                    DGVCDTrack.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    txtCDID.Text = CDID.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        private void btnDelete_Click(System.Object sender, System.EventArgs e)
        {
            string InputID = string.Empty;
            //hold the ID of the owner, CD, or Track
            string result = null;
            Button fakebutton = null;
            fakebutton = (Button)sender;
            try
            {
                switch (fakebutton.Name)
                {
                    case "btnDeleteOwner":
                        InputID = txtOwnerID.Text;
                        break;

                    case "btnDeleteCD":
                        InputID = txtCDID.Text;
                        break;
                    case "btnDeleteTracks":
                        InputID = txtTrackID.Text;
                        break;
                }
                //delete the track here and return back success or failure
                result = myDatabase.DeleteOwnerCDTracks(InputID, fakebutton.Tag.ToString());
                MessageBox.Show(fakebutton.Tag + " delete " + result);

                //refresh everything
                DisplayDataGridViewOwner();
                DGVCD.DataSource = myDatabase.AllFillDGVWithData("CD", txtCDID.Text);
                DGVtracks.DataSource = myDatabase.AllFillDGVWithData("Track", txtTrackID.Text);

                //filClearAllTextBoxes(this); //clear all the textboxes afterwards
            }
            catch (Exception ex)
            {
                MessageBox.Show("First click on the Owner, CD, or Track you want to delete " + ex.Message);
            }
        }
    }
}
    

