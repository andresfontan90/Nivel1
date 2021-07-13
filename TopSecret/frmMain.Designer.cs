
namespace TopSecret
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.gbIn = new System.Windows.Forms.GroupBox();
            this.lblFile2 = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.gbOut = new System.Windows.Forms.GroupBox();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.gbIn.SuspendLayout();
            this.gbOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProcess.Location = new System.Drawing.Point(14, 75);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(596, 50);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Procesar";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtFile
            // 
            this.txtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.Location = new System.Drawing.Point(157, 21);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(417, 22);
            this.txtFile.TabIndex = 0;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFile.Location = new System.Drawing.Point(11, 25);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(140, 15);
            this.lblFile.TabIndex = 2;
            this.lblFile.Text = "Archivo de entrada:";
            // 
            // gbIn
            // 
            this.gbIn.Controls.Add(this.lblFile2);
            this.gbIn.Controls.Add(this.btnFile);
            this.gbIn.Controls.Add(this.btnProcess);
            this.gbIn.Controls.Add(this.txtFile);
            this.gbIn.Controls.Add(this.lblFile);
            this.gbIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbIn.Location = new System.Drawing.Point(14, 26);
            this.gbIn.Name = "gbIn";
            this.gbIn.Size = new System.Drawing.Size(621, 140);
            this.gbIn.TabIndex = 3;
            this.gbIn.TabStop = false;
            this.gbIn.Text = "Entrada";
            // 
            // lblFile2
            // 
            this.lblFile2.AutoSize = true;
            this.lblFile2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFile2.Location = new System.Drawing.Point(155, 48);
            this.lblFile2.Name = "lblFile2";
            this.lblFile2.Size = new System.Drawing.Size(397, 13);
            this.lblFile2.TabIndex = 5;
            this.lblFile2.Text = "Ingrese el archivo .json con los datos captados por los satelites";
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Image = global::TopSecret.Properties.Resources.find;
            this.btnFile.Location = new System.Drawing.Point(582, 19);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(28, 26);
            this.btnFile.TabIndex = 1;
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // gbOut
            // 
            this.gbOut.Controls.Add(this.txtOut);
            this.gbOut.Location = new System.Drawing.Point(14, 187);
            this.gbOut.Name = "gbOut";
            this.gbOut.Size = new System.Drawing.Size(621, 320);
            this.gbOut.TabIndex = 4;
            this.gbOut.TabStop = false;
            this.gbOut.Text = "Salida";
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(14, 21);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOut.Size = new System.Drawing.Size(596, 286);
            this.txtOut.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(651, 518);
            this.Controls.Add(this.gbOut);
            this.Controls.Add(this.gbIn);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TopSecret";
            this.gbIn.ResumeLayout(false);
            this.gbIn.PerformLayout();
            this.gbOut.ResumeLayout(false);
            this.gbOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.GroupBox gbIn;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label lblFile2;
        private System.Windows.Forms.GroupBox gbOut;
        private System.Windows.Forms.TextBox txtOut;
    }
}

