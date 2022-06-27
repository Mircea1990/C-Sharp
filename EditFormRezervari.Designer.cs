namespace Imobiliara
{
    partial class EditFormRezervari
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
            this.btnActualizare = new System.Windows.Forms.Button();
            this.tbCameraSolicitant = new System.Windows.Forms.TextBox();
            this.tbPrenumeSolicitant = new System.Windows.Forms.TextBox();
            this.tbNumeSolicitant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnActualizare
            // 
            this.btnActualizare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnActualizare.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActualizare.ForeColor = System.Drawing.Color.Black;
            this.btnActualizare.Location = new System.Drawing.Point(141, -146);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(174, 62);
            this.btnActualizare.TabIndex = 21;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = false;
            // 
            // tbCameraSolicitant
            // 
            this.tbCameraSolicitant.Location = new System.Drawing.Point(346, 242);
            this.tbCameraSolicitant.Multiline = true;
            this.tbCameraSolicitant.Name = "tbCameraSolicitant";
            this.tbCameraSolicitant.Size = new System.Drawing.Size(327, 38);
            this.tbCameraSolicitant.TabIndex = 20;
            // 
            // tbPrenumeSolicitant
            // 
            this.tbPrenumeSolicitant.Location = new System.Drawing.Point(346, 179);
            this.tbPrenumeSolicitant.Multiline = true;
            this.tbPrenumeSolicitant.Name = "tbPrenumeSolicitant";
            this.tbPrenumeSolicitant.Size = new System.Drawing.Size(327, 38);
            this.tbPrenumeSolicitant.TabIndex = 19;
            // 
            // tbNumeSolicitant
            // 
            this.tbNumeSolicitant.Location = new System.Drawing.Point(346, 118);
            this.tbNumeSolicitant.Multiline = true;
            this.tbNumeSolicitant.Name = "tbNumeSolicitant";
            this.tbNumeSolicitant.Size = new System.Drawing.Size(327, 38);
            this.tbNumeSolicitant.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(68, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 38);
            this.label5.TabIndex = 17;
            this.label5.Text = "Camera Solicitata:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(68, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 38);
            this.label4.TabIndex = 16;
            this.label4.Text = "Prenume Solicitant:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(68, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nume Solicitant:";
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnModifica.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModifica.ForeColor = System.Drawing.Color.Black;
            this.btnModifica.Location = new System.Drawing.Point(735, 155);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(174, 62);
            this.btnModifica.TabIndex = 23;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // EditFormRezervari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 370);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.tbCameraSolicitant);
            this.Controls.Add(this.tbPrenumeSolicitant);
            this.Controls.Add(this.tbNumeSolicitant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "EditFormRezervari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditFormRezervari";
            this.Load += new System.EventHandler(this.EditFormRezervari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnActualizare;
        private TextBox tbCameraSolicitant;
        private TextBox tbPrenumeSolicitant;
        private TextBox tbNumeSolicitant;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnModifica;
    }
}