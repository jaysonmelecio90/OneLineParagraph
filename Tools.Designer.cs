using System;
using System.Drawing;

namespace OneLineParagraph
{
    partial class Tools
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtOutput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tools));
            btnConvert = new System.Windows.Forms.Button();
            btnScramble = new System.Windows.Forms.Button();
            btnReplace = new System.Windows.Forms.Button();
            txtFind = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            txtInput = new System.Windows.Forms.RichTextBox();
            txtOutput = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnConvert
            // 
            btnConvert.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnConvert.Location = new System.Drawing.Point(12, 120);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new System.Drawing.Size(563, 30);
            btnConvert.TabIndex = 1;
            btnConvert.Text = "Convert to One Line";
            btnConvert.Click += BtnConvert_Click;
            // 
            // btnScramble
            // 
            btnScramble.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnScramble.Location = new System.Drawing.Point(12, 156);
            btnScramble.Name = "btnScramble";
            btnScramble.Size = new System.Drawing.Size(563, 30);
            btnScramble.TabIndex = 1;
            btnScramble.Text = "ScrambledTextGenerator";
            btnScramble.Click += BtnScramble_Click;
            // 
            // btnReplace
            // 
            btnReplace.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnReplace.Location = new System.Drawing.Point(308, 192);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new System.Drawing.Size(161, 30);
            btnReplace.TabIndex = 1;
            btnReplace.Text = "Replace";
            btnReplace.Click += BtnReplace_Click;
            // 
            // txtFind
            // 
            txtFind.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFind.Location = new System.Drawing.Point(12, 194);
            txtFind.Multiline = true;
            txtFind.Name = "txtFind";
            txtFind.Size = new System.Drawing.Size(290, 26);
            txtFind.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            button1.Location = new System.Drawing.Point(475, 192);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(96, 30);
            button1.TabIndex = 1;
            button1.Text = "Copy";
            button1.Click += BtnCopyResult;
            // 
            // txtInput
            // 
            txtInput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtInput.Location = new System.Drawing.Point(12, 12);
            txtInput.Name = "txtInput";
            txtInput.Size = new System.Drawing.Size(563, 104);
            txtInput.TabIndex = 4;
            txtInput.Text = "";
            // 
            // txtOutput
            // 
            txtOutput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtOutput.Location = new System.Drawing.Point(12, 231);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtOutput.Size = new System.Drawing.Size(559, 149);
            txtOutput.TabIndex = 2;
            // 
            // Tools
            // 
            ClientSize = new System.Drawing.Size(583, 392);
            Controls.Add(txtInput);
            Controls.Add(txtFind);
            Controls.Add(button1);
            Controls.Add(btnReplace);
            Controls.Add(btnScramble);
            Controls.Add(btnConvert);
            Controls.Add(txtOutput);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Tools";
            Text = "Paragraph to One Line";
            Load += this.Tools_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Tools_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("administrative_tools.ico");
        }

        private System.Windows.Forms.Button btnScramble;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtInput;
    }
}
