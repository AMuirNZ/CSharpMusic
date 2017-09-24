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
                OwnerID = (int) DGVOwner.Rows[e.RowIndex].Cells[0].Value;
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
                CDID = (int) DGVCD.Rows[e.RowIndex].Cells[0].Value;
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

        private void DGVCDTrack_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CDTrackID = 0;
            //these are the cell clicks for the values in the row that you click on

            CDTrackID = (int) DGVCDTrack.Rows[e.RowIndex].Cells[0].Value;
            txtTrackName.Text = DGVCDTrack.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTrackDuration.Text = DGVCDTrack.Rows[e.RowIndex].Cells[2].Value.ToString();

            //if you are cicking on a row and not outside it
            if (e.RowIndex >= 0)
            {
                //Fill the next CD DGV with the owner ID
                
                txtTrackID.Text = CDTrackID.ToString();

            }
        


}
    }
}

    

