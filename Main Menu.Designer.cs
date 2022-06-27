namespace Imobiliara
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnCamere = new System.Windows.Forms.Button();
            this.btnClienti = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(386, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cazari la Hotel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCamere
            // 
            this.btnCamere.BackColor = System.Drawing.Color.Lime;
            this.btnCamere.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCamere.Location = new System.Drawing.Point(44, 259);
            this.btnCamere.Name = "btnCamere";
            this.btnCamere.Size = new System.Drawing.Size(214, 106);
            this.btnCamere.TabIndex = 1;
            this.btnCamere.Text = "Camere";
            this.btnCamere.UseVisualStyleBackColor = false;
            this.btnCamere.Click += new System.EventHandler(this.btnCamere_Click);
            // 
            // btnClienti
            // 
            this.btnClienti.BackColor = System.Drawing.Color.Lime;
            this.btnClienti.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClienti.Location = new System.Drawing.Point(386, 259);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Size = new System.Drawing.Size(214, 106);
            this.btnClienti.TabIndex = 2;
            this.btnClienti.Text = "Rezervari";
            this.btnClienti.UseVisualStyleBackColor = false;
            this.btnClienti.Click += new System.EventHandler(this.btnRezervari_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Lime;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(720, 259);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(214, 106);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1029, 559);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClienti);
            this.Controls.Add(this.btnCamere);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMainMenu_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnCamere;
        private Button btnClienti;
        private Button btnExit;
    }
}