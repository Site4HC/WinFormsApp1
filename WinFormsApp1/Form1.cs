using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class MyBD : Form
    {
        public MyBD()
        {
            InitializeComponent();
        }

        private void âèõ³äToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ïðîÏðîãðàìóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About f1 = new About();
            f1.ShowDialog();
        }

        private void êàëüêóëÿòîðToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.ShowDialog();
        }

        private void MyBD_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MyBD_Load(object sender, EventArgs e)
        {

        }

        private void OpenTableOsoba_Click(object sender, EventArgs e)
        {
            frmOsoba f1 = new frmOsoba();
            f1.ShowDialog();

        }

        private void OpenTableKatalog_Click(object sender, EventArgs e)
        {
            frmKatalog f1 = new frmKatalog();
            f1.ShowDialog();
        }

        private void OpenTableFormuliar_Click(object sender, EventArgs e)
        {
            frmFormuliar f1 = new frmFormuliar();
            f1.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
