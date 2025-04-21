using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmOsoba : Form
    {
        public frmOsoba()
        {
            InitializeComponent();
        }
        public class CoreBindingNavigator : BindingNavigator
        {
            public CoreBindingNavigator()
            {
                AddStandardItems();
            }
        }

        private void frmOsoba_Load(object sender, EventArgs e)
        {
            this.Height = 320;
            H.bs1 = new BindingSource();
            H.bs1.DataSource = H.myFunDt("Select * from info");
            dataGridView1.DataSource = H.bs1;

            DGWFormat();

            DataTable dtBorder = new DataTable();
            DataTable dtDistinct = new DataTable();
            dtBorder = H.myFunDt("SELECT min(rating), max(rating), min(DNO), max(DNO) FROM info");
            dtDistinct = H.myFunDt("SELECT distinct Adresa from info");


            txtReitFrom.Text = dtBorder.Rows[0][0].ToString();
            txtReitTo.Text = dtBorder.Rows[0][1].ToString();
            dtpDNOFrom.Value = Convert.ToDateTime(dtBorder.Rows[0][2].ToString());
            dtpDNOTo.Value = Convert.ToDateTime(dtBorder.Rows[0][3].ToString());

            cmbAdres.Items.Add("");
            for (int i = 0; i < dtDistinct.Rows.Count; i++)
            {
                cmbAdres.Items.Add(dtDistinct.Rows[i][0].ToString());
            }
            cmbAdres.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbSex.Items.Add("");
            cmbSex.Items.Add("ч");
            cmbSex.Items.Add("ж");
            cmbSex.Text = "ч";
            cmbSex.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        void DGWFormat()
        {
            dataGridView1.Columns[1].Width = 25;
            dataGridView1.Columns[0].HeaderText = "N";
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Find_Click(object sender, EventArgs e)
        {

        }



        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(txtFind.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (btnFind.Enabled)
            {
                Find.Visible = true;
                txtFind.Visible = true;
                txtFind.Focus();
            }
            else
            {
                CancelFind();
            }
        }
        private void CancelFind()
        {
            Find.Visible = false;
            txtFind.Visible = false;
            txtFind.Text = "";
            for (int i = 0; i < dataGridView1.RowCount; i++)
                dataGridView1.Rows[i].Selected = false;
        }

        private void txtFind_Leave(object sender, EventArgs e)
        {
            btnFind.Enabled = false;
            CancelFind();
        }
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.DarkViolet, 1); 
            gfx.DrawLine(p, 0, 0, 5, 0); 
            gfx.DrawLine(p, 35, 0, e.ClipRectangle.Width - 2, 0); 
            gfx.DrawLine(p, 0, 0, 0, e.ClipRectangle.Height - 2); 
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 0, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2); 
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2); 
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (btnFind.Enabled)
            {
                this.Height = 450;
                groupBox1.Visible = true;
            }
            else
            {
                this.Height = 320;
                groupBox1.Visible = false;
            }
        }

        private void btnFilterOk_Click(object sender, EventArgs e)
        {
            string strFilter = "ID > 0";

            if (!string.IsNullOrWhiteSpace(txtPIP.Text))
            {
                strFilter += $" AND PIPO LIKE '{txtPIP.Text}%'";
            }

            if (!string.IsNullOrWhiteSpace(txtReitFrom.Text) && !string.IsNullOrWhiteSpace(txtReitTo.Text))
            {
                strFilter += $" AND (Rating >= {txtReitFrom.Text.Replace(',', '.')} AND Rating <= {txtReitTo.Text.Replace(',', '.')})";
            }
            else if (string.IsNullOrWhiteSpace(txtReitFrom.Text) && !string.IsNullOrWhiteSpace(txtReitTo.Text))
            {
                strFilter += $" AND (Rating <= {txtReitTo.Text.Replace(',', '.')})";
            }
            else if (!string.IsNullOrWhiteSpace(txtReitFrom.Text) && string.IsNullOrWhiteSpace(txtReitTo.Text))
            {
                strFilter += $" AND (Rating >= {txtReitFrom.Text.Replace(',', '.')})";
            }

            strFilter += $" AND (DNO >= #{dtpDNOFrom.Value:yyyy-MM-dd}# AND DNO <= #{dtpDNOTo.Value:yyyy-MM-dd}#)";

            if (!string.IsNullOrWhiteSpace(cmbAdres.Text))
            {
                strFilter += $" AND (Adresa = '{cmbAdres.Text}')";
            }


            if (cmbSex.Text == "ч")
            {
                strFilter += " AND (Sex = 0)";
            }
            else if (cmbSex.Text == "ж")
            {
                strFilter += " AND (Sex = 1)";
            }

            H.bs1.Filter = strFilter;

            //MessageBox.Show(strFilter); 
        }



        private void btnFilterCancel_Click(object sender, EventArgs e)
        {
            H.bs1.RemoveFilter();
        }
    }
}
