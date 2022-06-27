using Cazari_Hotel.ViewModel;
using Imobiliara.Entities;
using System.ComponentModel;
using System.Data.SQLite;

namespace Imobiliara
{
    public partial class RezervariForm : Form
    {
        #region Attributes
        private readonly RezervareFormViewModel _viewModel;
        private BindingList<Rezervare> _listaRezervari;
        private const string ConnectionString = "Data Source=db.db";
        Random rand = new Random();
        private int _currentCharIndex;
        #endregion


        public RezervariForm()
        {
            InitializeComponent();
            _listaRezervari = new BindingList<Rezervare>();
            _viewModel = new RezervareFormViewModel();
           
        }

        private void DisplayRevervari()
        {
            lvRezervari.Items.Clear();

            foreach (Rezervare rez in _listaRezervari)
            {
                ListViewItem lvi = new ListViewItem(rez.ID.ToString());
                lvi.SubItems.Add(rez.Nume);
                lvi.SubItems.Add(rez.Prenume);
                lvi.SubItems.Add(rez.NrCamera.ToString());

                lvi.Tag = rez;

                lvRezervari.Items.Add(lvi);
            }
        }

        private void RezervariForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadRevervari();
                DisplayRevervari();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Methods

        private void homeMenu_Click(object sender, EventArgs e)
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

        private void exitMenuRezervari_Click(object sender, EventArgs e)
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

        private void RezervariForm_KeyUp(object sender, KeyEventArgs e)
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

        private void btnIntroducere_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = tbNumeSolicitant.Text;
                string prenume = tbPrenumeSolicitant.Text;
                long camera = long.Parse(tbCameraSolicitant.Text);

                Rezervare rezervare = new Rezervare(nume, prenume, camera);
                AddRevervari(rezervare);
                DisplayRevervari();
                tbNumeSolicitant.Text = String.Empty;
                tbPrenumeSolicitant.Text = String.Empty;
                tbCameraSolicitant.Text = String.Empty;
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

        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (lvRezervari.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteaza o rezervare!");
            }
            else
            {
                if (
                    MessageBox.Show(
                        "Esti sigur ca vrei sa stergi rezervarea?",
                        "Sterge rezervare",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning
                    ) == DialogResult.OK
                )
                {
                    ListViewItem lvi = lvRezervari.SelectedItems[0];
                    Rezervare camera = (Rezervare)lvi.Tag;

                    DeleteRezervare(camera);
                    DisplayRevervari();
                }
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
         
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while trying to load the document for Print Preview." +
                    " Make sure you currently have access to a printer. " +
                    "A printer must be connected and accessible for Print Preview to work.");
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _currentCharIndex = 0;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Font font = new Font("Microsoft Sans Serif", 24);

            var pageSettings = e.PageSettings;


            var printAreaHeight = e.MarginBounds.Height;


            var printAreaWidth = e.MarginBounds.Width;


            var marginLeft = e.MarginBounds.Left;

            var marginTop = e.MarginBounds.Top;



            if (pageSettings.Landscape)
            {
                var intTemp = printAreaHeight;
                printAreaHeight = printAreaWidth;
                printAreaWidth = intTemp;
            }

            const int rowHeight = 40;
            var columnWidth = printAreaWidth / 3;


            StringFormat fmt = new StringFormat(StringFormatFlags.LineLimit);
            fmt.Trimming = StringTrimming.EllipsisCharacter;

            var currentY = marginTop;
            while (_currentCharIndex < _listaRezervari.Count)
            {

                var currentX = marginLeft;


                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);

                e.Graphics.DrawString(
                    _listaRezervari[_currentCharIndex].Nume,
                    font,
                    Brushes.Black,
                    new RectangleF(currentX, currentY, columnWidth, rowHeight),
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    _listaRezervari[_currentCharIndex].Prenume,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    _listaRezervari[_currentCharIndex].NrCamera.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);

                _currentCharIndex++;
                currentY += rowHeight;

                if (currentY - marginTop + rowHeight > printAreaHeight)
                {
                    e.HasMorePages = true;
                    break;
                }
            }
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            if (lvRezervari.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose a row");

            }
            else
            {
                ListViewItem selectedItem = lvRezervari.SelectedItems[0];
                Rezervare r = (Rezervare)selectedItem.Tag;

                EditFormRezervari editForm = new EditFormRezervari(r);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    ModificaRezervarea(r);
                    DisplayRevervari();
                }

            }
        }

        #endregion


        #region Validari
        private void tbNumeSolicitant_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNumeSolicitant.Text))
            {
                e.Cancel = true;
                tbNumeSolicitant.Focus();
                errorProvider1.SetError((Control)sender, "The text box is empty! Please a value");
            }
            else if(tbNumeSolicitant.Text.Any(Char.IsDigit))
            {
                e.Cancel = true;
                tbNumeSolicitant.Focus();
                errorProvider1.SetError(tbNumeSolicitant, "Introduceti numai caractere");
            }
            else
            {
                this.errorProvider1.SetError(tbNumeSolicitant, String.Empty);
            }
            
        }


        private void tbPrenumeSolicitant_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPrenumeSolicitant.Text))
            {
                e.Cancel = true;
                tbPrenumeSolicitant.Focus();
                errorProvider1.SetError((Control)sender, "The text box is empty! Please a value");
            }
            else if(tbPrenumeSolicitant.Text.Any(Char.IsDigit))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPrenumeSolicitant, "Introduceti numai caractere");
            }
            else
            {
                this.errorProvider1.SetError(tbPrenumeSolicitant, String.Empty);
            }

        }

        private void tbCameraSolicitant_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCameraSolicitant.Text))
            {
                e.Cancel = true;
                tbCameraSolicitant.Focus();
                errorProvider1.SetError((Control)sender, "The text box is empty! Please a only numbers");
            }
            else if(!tbCameraSolicitant.Text.Any(Char.IsDigit))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCameraSolicitant, "Introduceti numai cifre");
            }
            else
            {
                errorProvider1.SetError(tbCameraSolicitant, String.Empty);
            }
        }
        #endregion

        #region Drawing
        void Render()
        {
            using (var bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height))
            using (var gfx = Graphics.FromImage(bmp))
            using (var pen = new Pen(Color.Red))
            {
                gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                gfx.Clear(Color.Navy);
                for (int i = 0; i < 250; i++)
                {
                    var pt1 = new Point(rand.Next(bmp.Width), rand.Next(bmp.Height));
                    var pt2 = new Point(rand.Next(bmp.Width), rand.Next(bmp.Height));
                    gfx.DrawLine(pen, pt1, pt2);
                }

                pictureBox1.Image?.Dispose();
                pictureBox1.Image = (Bitmap)bmp.Clone();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Render();
        }

        #endregion

        #region Database
        public void AddRevervari(Rezervare rezervare)
        {
            var query =
                "INSERT INTO REZERVARI(Nume, Prenume, Camera) "
                + "VALUES(@Nume, @Prenume, @Camera); "
                + "SELECT last_insert_rowid()";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@Nume", rezervare.Nume);
                    command.Parameters.AddWithValue("@Prenume", rezervare.Prenume);
                    command.Parameters.AddWithValue("@Camera", rezervare.NrCamera);

                    rezervare.ID = (long)command.ExecuteScalar();

                    _listaRezervari.Add(rezervare);
                }
                catch (SQLiteException e)
                {
                    MessageBox.Show("Error Generated. Details: " + e.ToString());
                }
            }
        }

        public void LoadRevervari()
        {
            var query = "SELECT * FROM REZERVARI";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["Id"];
                        string numeSolicitant = (string)reader["Nume"];
                        string prenumeSolicitant = (string)reader["Prenume"];
                        long camera = reader.GetInt32(reader.GetOrdinal("Camera"));

                        Rezervare rezervare = new Rezervare(id,numeSolicitant, prenumeSolicitant,camera);
                        _listaRezervari.Add(rezervare);
                    }
                }
            }
        }

        public void DeleteRezervare(Rezervare rezervare)
        {
            var query = "DELETE FROM REZERVARI WHERE Id=@Id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", rezervare.ID);

                command.ExecuteNonQuery();

                _listaRezervari.Remove(rezervare);
            }
        }

        public void ModificaRezervarea(Rezervare rezervare)
        {
            var query = "UPDATE REZERVARE SET Nume = @Nume, Prenume = @Prenume, Camera = @Camera";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.Add(new SQLiteParameter("@Nume", rezervare.Nume));
                command.Parameters.Add(new SQLiteParameter("@Prenume", rezervare.Prenume));
                command.Parameters.Add(new SQLiteParameter("@Camera", rezervare.NrCamera));

                rezervare.ID = (long)command.ExecuteScalar();
            }
        }
        #endregion

  
    }
}
