namespace Imobiliara
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure about closing the Application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

       
        private void btnRezervari_Click(object sender, EventArgs e)
        {
            RezervariForm o = new RezervariForm();
            this.Hide();
            o.ShowDialog();
            this.Close();
        }

        

        private void FormMainMenu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if(MessageBox.Show(
                        "Quit the Application",
                        "Exit Application Dialog",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2
                    )== DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void btnCamere_Click(object sender, EventArgs e)
        {
            CamereForm o = new CamereForm();
            this.Hide();
            o.ShowDialog();
            this.Close();
        }
    }
}