using Imobiliara.Entities;

namespace Imobiliara
{
    public partial class EditFormCamera : Form
    {
        private Camera _camera;

        public EditFormCamera(Camera camera)
        {
            InitializeComponent();
            _camera = camera;
        }

        private void EditFormCamera_Load(object sender, EventArgs e)
        {
            tbNumarCamera.Text = _camera.NrCamera.ToString();
            tbEtaj.Text = _camera.Etaj.ToString();
            dtpData.Value = _camera.DataOcupata;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            _camera.NrCamera = Int64.Parse(tbNumarCamera.Text);
            _camera.Etaj = Int64.Parse(tbEtaj.Text);
            _camera.DataOcupata = dtpData.Value;
        }
    }
}
