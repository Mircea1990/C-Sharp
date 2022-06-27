using Imobiliara.Entities;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Runtime.Serialization.Formatters.Binary;

namespace Imobiliara
{
    public partial class CamereForm : Form
    {
        #region Attributes
        private BindingList<Camera> _listaCamere;
        private const string ConnectionString = "Data Source=db.db";
        #endregion

        public CamereForm()
        {
            InitializeComponent();
            _listaCamere = new BindingList<Camera>();
        }


        private void DisplayCamera()
        {
            lvCamere.Items.Clear();

            foreach (Camera c in _listaCamere)
            {
                ListViewItem listView = new ListViewItem(c.Id.ToString());
                listView.SubItems.Add(c.NrCamera.ToString());
                listView.SubItems.Add(c.Etaj.ToString());
                listView.SubItems.Add(c.DataOcupata.ToShortDateString());

                listView.Tag = c;

                lvCamere.Items.Add(listView);
            }
        }

        private void CamereForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCamera();
                DisplayCamera();
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Methods
        private void camereMenu_Click(object sender, EventArgs e)
        {
            FormMainMenu o = new FormMainMenu();
            if (
                MessageBox.Show(
                    "Are you sure about going back to Main Menu ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                ) == DialogResult.Yes
            )
            {
                this.Hide();
                o.ShowDialog();
                this.Close();
            }
        }

        private void exitMenuCamere_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(
                    "Are you sure about closing the Application?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                ) == DialogResult.Yes
            )
            {
                this.Close();
            }
        }

        private void CamereForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (
                    MessageBox.Show(
                        "Quit the Application",
                        "Exit Application Dialog",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2
                    ) == DialogResult.Yes
                )
                {
                    Application.Exit();
                }
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            long numarCamera = Int64.Parse(tbNumarCamera.Text);
            long etaj = Int64.Parse(tbEtaj.Text);
            DateTime data = dtpData.Value;

            Camera camera = new Camera(numarCamera, etaj, data);

            try
            {
                AddCamera(camera);
                DisplayCamera();
                tbEtaj.Text = String.Empty;
                tbNumarCamera.Text = String.Empty;

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (lvCamere.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose a row");

            }
            else
            {
                if (MessageBox.Show("Are you sure you want to modify?", "Update!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    EditFormCamera editForm = new EditFormCamera((Camera)lvCamere.SelectedItems[0].Tag);
                    if (editForm.ShowDialog() == DialogResult.OK)
                        DisplayCamera();
                }
            }

        }

        private void exportReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to export report as a txt file?", "Export!",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text File | *.txt";
                saveFileDialog.Title = "Save as text file";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);

                    try
                    {
                        sw.WriteLine("NrCamera, Etaj, Data");
                        foreach (var c in _listaCamere)
                        {
                            sw.WriteLine("{0}, {1}, {2}", c.NrCamera, c.NrCamera, c.DataOcupata);
                        }
                        MessageBox.Show("Report exported!");
                    }
                    finally
                    {
                        sw.Dispose();
                    }
                }

            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (lvCamere.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteaza o camera!");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete?", "Delete!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    try
                    {
                        ListViewItem lvi = lvCamere.SelectedItems[0];
                        Camera camera = (Camera)lvi.Tag;

                        DeleteCamera(camera);
                        DisplayCamera();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }


        #endregion



        #region Validari

        private void tbNumarCamera_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNumarCamera.Text))
            {
                e.Cancel = true;
                tbNumarCamera.Focus();
                errorProvider1.SetError((Control)sender, "The text box is empty! Please a value");
            }
            else if (!tbNumarCamera.Text.Any(Char.IsDigit))
            {
                e.Cancel = true;
                tbNumarCamera.Focus();
                errorProvider1.SetError(tbNumarCamera, "Introduceti numai cifre");
            }
            else
            {
                errorProvider1.SetError(tbNumarCamera, String.Empty);
            }
        }

        private void tbEtaj_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbEtaj.Text))
            {
                e.Cancel = true;
                tbEtaj.Focus();
                errorProvider1.SetError((Control)sender, "The text box is empty! Please a value");
            }
            else if (!tbEtaj.Text.Any(Char.IsDigit))
            {
                e.Cancel = false;
                tbEtaj.Focus();
                errorProvider1.SetError(tbEtaj, "Introduceti numai cifre");
            }
            else
            {
                errorProvider1.SetError(tbEtaj, String.Empty);
            }
        }

        #endregion



        #region Binary
        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream s = File.Create("SerializedBinary.bin"))
            {
                if (MessageBox.Show("Are you sure you want to serialize?", "Serialize!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    formatter.Serialize(s, _listaCamere);
                    MessageBox.Show("File have been serialized !");
                }
            }
        }



        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("SerializedBinary.bin"))
            {
                if (MessageBox.Show("Are you sure you want to deserialize?", "Deserialize!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    _listaCamere = (BindingList<Camera>)formatter.Deserialize(stream);
                    DisplayCamera();
                    MessageBox.Show("File have been deserialized !");
                }
            }
        }
        #endregion

        

        #region Database

        public void AddCamera(Camera camera)
        {
            var query = "INSERT INTO CAMERA(Numar, Etaj, Data)" +
                " VALUES(@Numar,@Etaj,@Data); " +
                " SELECT last_insert_rowid()";
            using (SQLiteConnection connenction = new SQLiteConnection(ConnectionString))
            {
                connenction.Open();
                try
                {
                    var command = new SQLiteCommand(query, connenction);
                    command.Parameters.AddWithValue("@Numar", camera.NrCamera);
                    command.Parameters.AddWithValue("@Etaj", camera.Etaj);
                    command.Parameters.AddWithValue("@Data", camera.DataOcupata);

                    camera.Id = (long)command.ExecuteScalar();

                    _listaCamere.Add(camera);
                }
                catch (SQLiteException e)
                {

                    MessageBox.Show("Error Generated. Details: " + e.ToString());
                }
            }
        }


        public void LoadCamera()
        {
            const string query = "SELECT * FROM CAMERA";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["ID"];
                        Int64 numar = (long)reader["Numar"];
                        Int64 etaj = (long)reader["Etaj"];
                        DateTime data = DateTime.Parse((string)reader["Data"]);

                        Camera camera = new Camera(id, numar, etaj, data);
                        _listaCamere.Add(camera);
                    }
                }
            }

        }


        public void DeleteCamera(Camera camera)
        {
            const string query = "DELETE FROM CAMERA WHERE Id=@id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {

                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@ID", camera.Id);
                command.ExecuteNonQuery();

                _listaCamere.Remove(camera);

            }
        }

        public void ModifyCamera(Camera camera)
        {
            var query = "UPDATE CAMERA SET Numar = @Numar, Etaj = @Etaj, Data = @Data";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.Add(new SQLiteParameter("@Numar", camera.NrCamera));
                command.Parameters.Add(new SQLiteParameter("@Etaj", camera.Etaj));
                command.Parameters.Add(new SQLiteParameter("@Data", camera.DataOcupata));

                camera.Id = (long)command.ExecuteScalar();

            }

        }

        #endregion

      
    }
}
