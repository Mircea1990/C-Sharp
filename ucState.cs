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
    public partial class ucState : UserControl
    {
        public ucState()
        {
            InitializeComponent();
        }

        public State SelectedState
        {
            get { return (State)cboState.SelectedItem; }
        } 
        private void ucState_Load(object sender, EventArgs e)
        {
            List<State> list = new List<State>();
            list.Add(new State() { Id = 1, Name = "Activat"});
            list.Add(new State() { Id = 2, Name = "Dezactivat"});
            cboState.DataSource = list;
            cboState.ValueMember = "Id";
            cboState.DisplayMember = "Name";
        }
    }
}
