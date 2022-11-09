using System.Windows.Forms;

namespace CRUID
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

       
        private void btn_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application developed by Natalia Silva \r\nGitHub: @natyesilva ");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to close the application?", "Close", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
               
            }
        }
    }
}