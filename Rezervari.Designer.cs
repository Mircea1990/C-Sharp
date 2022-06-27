namespace Imobiliara
{
    partial class RezervariForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervariForm));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuCereri = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNumeSolicitant = new System.Windows.Forms.TextBox();
            this.tbPrenumeSolicitant = new System.Windows.Forms.TextBox();
            this.tbCameraSolicitant = new System.Windows.Forms.TextBox();
            this.btnIntroducere = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lvRezervari = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucState1 = new Imobiliara.ucState();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(368, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pagina de Rezervari";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeMenu,
            this.exitMenuCereri,
            this.btnPrintPreview});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeMenu
            // 
            this.homeMenu.Name = "homeMenu";
            this.homeMenu.Size = new System.Drawing.Size(64, 24);
            this.homeMenu.Text = "Home";
            this.homeMenu.Click += new System.EventHandler(this.homeMenu_Click);
            // 
            // exitMenuCereri
            // 
            this.exitMenuCereri.Name = "exitMenuCereri";
            this.exitMenuCereri.Size = new System.Drawing.Size(47, 24);
            this.exitMenuCereri.Text = "Exit";
            this.exitMenuCereri.Click += new System.EventHandler(this.exitMenuRezervari_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(108, 24);
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(34, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nume Solicitant:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(34, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prenume Solicitant:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(34, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 38);
            this.label5.TabIndex = 6;
            this.label5.Text = "Camera Solicitata:";
            // 
            // tbNumeSolicitant
            // 
            this.tbNumeSolicitant.Location = new System.Drawing.Point(312, 140);
            this.tbNumeSolicitant.Multiline = true;
            this.tbNumeSolicitant.Name = "tbNumeSolicitant";
            this.tbNumeSolicitant.Size = new System.Drawing.Size(327, 38);
            this.tbNumeSolicitant.TabIndex = 7;
            this.tbNumeSolicitant.Validating += new System.ComponentModel.CancelEventHandler(this.tbNumeSolicitant_Validating);
            // 
            // tbPrenumeSolicitant
            // 
            this.tbPrenumeSolicitant.Location = new System.Drawing.Point(312, 201);
            this.tbPrenumeSolicitant.Multiline = true;
            this.tbPrenumeSolicitant.Name = "tbPrenumeSolicitant";
            this.tbPrenumeSolicitant.Size = new System.Drawing.Size(327, 38);
            this.tbPrenumeSolicitant.TabIndex = 8;
            this.tbPrenumeSolicitant.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenumeSolicitant_Validating);
            // 
            // tbCameraSolicitant
            // 
            this.tbCameraSolicitant.Location = new System.Drawing.Point(312, 264);
            this.tbCameraSolicitant.Multiline = true;
            this.tbCameraSolicitant.Name = "tbCameraSolicitant";
            this.tbCameraSolicitant.Size = new System.Drawing.Size(327, 38);
            this.tbCameraSolicitant.TabIndex = 9;
            this.tbCameraSolicitant.Validating += new System.ComponentModel.CancelEventHandler(this.tbCameraSolicitant_Validating);
            // 
            // btnIntroducere
            // 
            this.btnIntroducere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIntroducere.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIntroducere.ForeColor = System.Drawing.Color.Black;
            this.btnIntroducere.Location = new System.Drawing.Point(17, 20);
            this.btnIntroducere.Name = "btnIntroducere";
            this.btnIntroducere.Size = new System.Drawing.Size(174, 62);
            this.btnIntroducere.TabIndex = 10;
            this.btnIntroducere.Text = "Introducere";
            this.btnIntroducere.UseVisualStyleBackColor = false;
            this.btnIntroducere.Click += new System.EventHandler(this.btnIntroducere_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnActualizare.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActualizare.ForeColor = System.Drawing.Color.Black;
            this.btnActualizare.Location = new System.Drawing.Point(261, 20);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(174, 62);
            this.btnActualizare.TabIndex = 11;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = false;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStergere.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStergere.ForeColor = System.Drawing.Color.Black;
            this.btnStergere.Location = new System.Drawing.Point(504, 20);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(174, 62);
            this.btnStergere.TabIndex = 12;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnStergere);
            this.panel1.Controls.Add(this.btnIntroducere);
            this.panel1.Controls.Add(this.btnActualizare);
            this.panel1.Location = new System.Drawing.Point(34, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 106);
            this.panel1.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lvRezervari
            // 
            this.lvRezervari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvRezervari.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvRezervari.FullRowSelect = true;
            this.lvRezervari.GridLines = true;
            this.lvRezervari.ImeMode = System.Windows.Forms.ImeMode.On;
            this.lvRezervari.LabelEdit = true;
            this.lvRezervari.Location = new System.Drawing.Point(34, 457);
            this.lvRezervari.Name = "lvRezervari";
            this.lvRezervari.Size = new System.Drawing.Size(972, 305);
            this.lvRezervari.TabIndex = 14;
            this.lvRezervari.UseCompatibleStateImageBehavior = false;
            this.lvRezervari.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prenume";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Camera";
            this.columnHeader3.Width = 120;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(645, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 182);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // ucState1
            // 
            this.ucState1.BackColor = System.Drawing.Color.Chartreuse;
            this.ucState1.Location = new System.Drawing.Point(732, 328);
            this.ucState1.Name = "ucState1";
            this.ucState1.Size = new System.Drawing.Size(274, 106);
            this.ucState1.TabIndex = 16;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // RezervariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1029, 774);
            this.Controls.Add(this.ucState1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lvRezervari);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbCameraSolicitant);
            this.Controls.Add(this.tbPrenumeSolicitant);
            this.Controls.Add(this.tbNumeSolicitant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RezervariForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervari";
            this.Load += new System.EventHandler(this.RezervariForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RezervariForm_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeMenu;
        private ToolStripMenuItem exitMenuCereri;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbNumeSolicitant;
        private TextBox tbPrenumeSolicitant;
        private TextBox tbCameraSolicitant;
        private Button btnIntroducere;
        private Button btnActualizare;
        private Button btnStergere;
        private Panel panel1;
        private ErrorProvider errorProvider1;
        private ListView lvRezervari;
        private PictureBox pictureBox1;
        private Imobiliara.ucState ucState1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ToolStripMenuItem btnPrintPreview;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}