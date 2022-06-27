using Imobiliara.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imobiliara
{
    public partial class EditFormRezervari : Form
    {
        private Rezervare _rezervare;
        public EditFormRezervari(Rezervare rezervare)

        {
            InitializeComponent();
            _rezervare = rezervare;
        }

        private void EditFormRezervari_Load(object sender, EventArgs e)
        {
            tbNumeSolicitant.Text = _rezervare.Nume;
            tbPrenumeSolicitant.Text = _rezervare.Prenume;
            tbCameraSolicitant.Text = _rezervare.NrCamera.ToString();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
                _rezervare.Nume = tbNumeSolicitant.Text;
                _rezervare.Prenume = tbPrenumeSolicitant.Text;
                _rezervare.NrCamera = Int32.Parse(tbCameraSolicitant.Text.ToString());
            
        }
    }
}
