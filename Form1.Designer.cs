namespace OneLineParagraph
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtOutput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtInput = new System.Windows.Forms.TextBox();
            btnConvert = new System.Windows.Forms.Button();
            txtOutput = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new System.Drawing.Point(12, 12);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtInput.Size = new System.Drawing.Size(750, 100);
            txtInput.TabIndex = 0;
            // 
            // btnConvert
            // 
            btnConvert.Location = new System.Drawing.Point(12, 120);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new System.Drawing.Size(750, 30);
            btnConvert.TabIndex = 1;
            btnConvert.Text = "Convert to One Line";
            btnConvert.Click += btnConvert_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new System.Drawing.Point(12, 160);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtOutput.Size = new System.Drawing.Size(750, 100);
            txtOutput.TabIndex = 2;
            // 
            // Form1
            // 
            ClientSize = new System.Drawing.Size(774, 271);
            Controls.Add(txtInput);
            Controls.Add(btnConvert);
            Controls.Add(txtOutput);
            MaximumSize = new System.Drawing.Size(790, 310);
            Name = "Form1";
            Text = "Paragraph to One Line";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
