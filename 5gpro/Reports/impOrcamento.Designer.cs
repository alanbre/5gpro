namespace _5gpro.Reports
{
    partial class impOrcamento
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
            this.rvOrcamento = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvOrcamento
            // 
            this.rvOrcamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvOrcamento.LocalReport.ReportEmbeddedResource = "_5gpro.Reports.impOrcamento.rdlc";
            this.rvOrcamento.Location = new System.Drawing.Point(0, 0);
            this.rvOrcamento.Name = "rvOrcamento";
            this.rvOrcamento.ServerReport.BearerToken = null;
            this.rvOrcamento.Size = new System.Drawing.Size(972, 528);
            this.rvOrcamento.TabIndex = 0;
            // 
            // impOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 528);
            this.Controls.Add(this.rvOrcamento);
            this.MinimizeBox = false;
            this.Name = "impOrcamento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Impressão de orçamento";
            this.Load += new System.EventHandler(this.ImpOrcamento_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvOrcamento;
    }
}