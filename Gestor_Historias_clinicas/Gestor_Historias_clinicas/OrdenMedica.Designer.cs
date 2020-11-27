
namespace Gestor_Historias_clinicas
{
    partial class OrdenMedica
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxRP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbDoc = new System.Windows.Forms.ComboBox();
            this.tbxFecha = new System.Windows.Forms.TextBox();
            this.txtRP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paciente : ";
            // 
            // tbxPac
            // 
            this.tbxPac.Location = new System.Drawing.Point(103, 12);
            this.tbxPac.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPac.Name = "tbxPac";
            this.tbxPac.ReadOnly = true;
            this.tbxPac.Size = new System.Drawing.Size(367, 22);
            this.tbxPac.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "R. / P. : ";
            // 
            // tbxRP
            // 
            this.tbxRP.Location = new System.Drawing.Point(20, 138);
            this.tbxRP.Margin = new System.Windows.Forms.Padding(4);
            this.tbxRP.Multiline = true;
            this.tbxRP.Name = "tbxRP";
            this.tbxRP.Size = new System.Drawing.Size(449, 360);
            this.tbxRP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 522);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Doctor(a) : ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(377, 514);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbDoc
            // 
            this.cmbDoc.FormattingEnabled = true;
            this.cmbDoc.Location = new System.Drawing.Point(105, 64);
            this.cmbDoc.Name = "cmbDoc";
            this.cmbDoc.Size = new System.Drawing.Size(364, 24);
            this.cmbDoc.TabIndex = 10;
            // 
            // tbxFecha
            // 
            this.tbxFecha.Location = new System.Drawing.Point(83, 517);
            this.tbxFecha.Name = "tbxFecha";
            this.tbxFecha.Size = new System.Drawing.Size(269, 22);
            this.tbxFecha.TabIndex = 11;
            // 
            // txtRP
            // 
            this.txtRP.Location = new System.Drawing.Point(20, 138);
            this.txtRP.Multiline = true;
            this.txtRP.Name = "txtRP";
            this.txtRP.Size = new System.Drawing.Size(449, 360);
            this.txtRP.TabIndex = 12;
            // 
            // OrdenMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 554);
            this.Controls.Add(this.txtRP);
            this.Controls.Add(this.tbxFecha);
            this.Controls.Add(this.cmbDoc);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxRP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxPac);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrdenMedica";
            this.Text = "OrdenMedica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxRP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbDoc;
        private System.Windows.Forms.TextBox tbxFecha;
        private System.Windows.Forms.TextBox txtRP;
    }
}