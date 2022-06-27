namespace Imobiliara
{
    partial class EditFormCamera
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
            this.btnModifica = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.tbEtaj = new System.Windows.Forms.TextBox();
            this.tbNumarCamera = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModifica
            // 
            this.btnModifica.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModifica.Location = new System.Drawing.Point(342, 267);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(121, 47);
            this.btnModifica.TabIndex = 19;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // dtpData
            // 
            this.dtpData.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpData.Location = new System.Drawing.Point(364, 183);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(327, 34);
            this.dtpData.TabIndex = 25;
            // 
            // tbEtaj
            // 
            this.tbEtaj.Location = new System.Drawing.Point(364, 116);
            this.tbEtaj.Multiline = true;
            this.tbEtaj.Name = "tbEtaj";
            this.tbEtaj.Size = new System.Drawing.Size(327, 38);
            this.tbEtaj.TabIndex = 24;
            // 
            // tbNumarCamera
            // 
            this.tbNumarCamera.Location = new System.Drawing.Point(364, 55);
            this.tbNumarCamera.Multiline = true;
            this.tbNumarCamera.Name = "tbNumarCamera";
            this.tbNumarCamera.Size = new System.Drawing.Size(327, 38);
            this.tbNumarCamera.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(30, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 38);
            this.label5.TabIndex = 22;
            this.label5.Text = "Data Ocupata:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(30, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 38);
            this.label4.TabIndex = 21;
            this.label4.Text = "Etaj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 38);
            this.label3.TabIndex = 20;
            this.label3.Text = "Numar Camera:";
            // 
            // EditFormCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 358);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.tbEtaj);
            this.Controls.Add(this.tbNumarCamera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditFormCamera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditFormCamera";
            this.Load += new System.EventHandler(this.EditFormCamera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnModifica;
        private DateTimePicker dtpData;
        private TextBox tbEtaj;
        private TextBox tbNumarCamera;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}