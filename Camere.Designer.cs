namespace Imobiliara
{
    partial class CamereForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imobileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuImobile = new System.Windows.Forms.ToolStripMenuItem();
            this.binarySerializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbEtaj = new System.Windows.Forms.TextBox();
            this.tbNumarCamera = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvCamere = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.ucState1 = new Imobiliara.ucState();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(338, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pagina de Camere Hotel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imobileMenu,
            this.exitMenuImobile,
            this.binarySerializeToolStripMenuItem,
            this.exportReportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imobileMenu
            // 
            this.imobileMenu.Name = "imobileMenu";
            this.imobileMenu.Size = new System.Drawing.Size(64, 24);
            this.imobileMenu.Text = "Home";
            this.imobileMenu.Click += new System.EventHandler(this.camereMenu_Click);
            // 
            // exitMenuImobile
            // 
            this.exitMenuImobile.Name = "exitMenuImobile";
            this.exitMenuImobile.Size = new System.Drawing.Size(47, 24);
            this.exitMenuImobile.Text = "Exit";
            this.exitMenuImobile.Click += new System.EventHandler(this.exitMenuCamere_Click);
            // 
            // binarySerializeToolStripMenuItem
            // 
            this.binarySerializeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.binarySerializeToolStripMenuItem.Name = "binarySerializeToolStripMenuItem";
            this.binarySerializeToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.binarySerializeToolStripMenuItem.Text = "Binary Serialize";
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.serializeToolStripMenuItem.Text = "Serialize";
            this.serializeToolStripMenuItem.Click += new System.EventHandler(this.serializeToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click);
            // 
            // exportReportToolStripMenuItem
            // 
            this.exportReportToolStripMenuItem.Name = "exportReportToolStripMenuItem";
            this.exportReportToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.exportReportToolStripMenuItem.Text = "Export Report";
            this.exportReportToolStripMenuItem.Click += new System.EventHandler(this.exportReportToolStripMenuItem_Click);
            // 
            // tbEtaj
            // 
            this.tbEtaj.Location = new System.Drawing.Point(371, 220);
            this.tbEtaj.Multiline = true;
            this.tbEtaj.Name = "tbEtaj";
            this.tbEtaj.Size = new System.Drawing.Size(327, 38);
            this.tbEtaj.TabIndex = 14;
            this.tbEtaj.Validating += new System.ComponentModel.CancelEventHandler(this.tbEtaj_Validating);
            // 
            // tbNumarCamera
            // 
            this.tbNumarCamera.Location = new System.Drawing.Point(371, 159);
            this.tbNumarCamera.Multiline = true;
            this.tbNumarCamera.Name = "tbNumarCamera";
            this.tbNumarCamera.Size = new System.Drawing.Size(327, 38);
            this.tbNumarCamera.TabIndex = 13;
            this.tbNumarCamera.Validating += new System.ComponentModel.CancelEventHandler(this.tbNumarCamera_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(37, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 38);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data Ocupata:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(37, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 38);
            this.label4.TabIndex = 11;
            this.label4.Text = "Etaj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "Numar Camera:";
            // 
            // lvCamere
            // 
            this.lvCamere.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvCamere.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvCamere.FullRowSelect = true;
            this.lvCamere.GridLines = true;
            this.lvCamere.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvCamere.LabelEdit = true;
            this.lvCamere.Location = new System.Drawing.Point(37, 365);
            this.lvCamere.Name = "lvCamere";
            this.lvCamere.Size = new System.Drawing.Size(954, 397);
            this.lvCamere.TabIndex = 1;
            this.lvCamere.UseCompatibleStateImageBehavior = false;
            this.lvCamere.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numar Camera";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Etaj";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data Ocupata";
            this.columnHeader3.Width = 200;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.btnSterge);
            this.panel1.Controls.Add(this.btnModifica);
            this.panel1.Controls.Add(this.btnAdauga);
            this.panel1.Location = new System.Drawing.Point(750, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 212);
            this.panel1.TabIndex = 17;
            // 
            // btnSterge
            // 
            this.btnSterge.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSterge.Location = new System.Drawing.Point(63, 141);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(106, 47);
            this.btnSterge.TabIndex = 2;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModifica.Location = new System.Drawing.Point(53, 78);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(121, 47);
            this.btnModifica.TabIndex = 1;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdauga.Location = new System.Drawing.Point(63, 17);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(106, 47);
            this.btnAdauga.TabIndex = 0;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // dtpData
            // 
            this.dtpData.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpData.Location = new System.Drawing.Point(371, 287);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(327, 34);
            this.dtpData.TabIndex = 18;
            // 
            // ucState1
            // 
            this.ucState1.Location = new System.Drawing.Point(37, 53);
            this.ucState1.Name = "ucState1";
            this.ucState1.Size = new System.Drawing.Size(295, 103);
            this.ucState1.TabIndex = 19;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id";
            this.columnHeader4.Width = 120;
            // 
            // CamereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1029, 774);
            this.Controls.Add(this.ucState1);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvCamere);
            this.Controls.Add(this.tbEtaj);
            this.Controls.Add(this.tbNumarCamera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CamereForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camere";
            this.Load += new System.EventHandler(this.CamereForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CamereForm_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem imobileMenu;
        private ToolStripMenuItem exitMenuImobile;
        private TextBox tbEtaj;
        private TextBox tbNumarCamera;
        private Label label5;
        private Label label4;
        private Label label3;
        private ListView lvCamere;
        private ErrorProvider errorProvider1;
        private Panel panel1;
        private Button btnAdauga;
        private Button btnSterge;
        private Button btnModifica;
        private DateTimePicker dtpData;
        private ToolStripMenuItem binarySerializeToolStripMenuItem;
        private ToolStripMenuItem serializeToolStripMenuItem;
        private ToolStripMenuItem deserializeToolStripMenuItem;
        private ToolStripMenuItem exportReportToolStripMenuItem;
        private Imobiliara.ucState ucState1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}