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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            panel2 = new System.Windows.Forms.Panel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            panel3 = new System.Windows.Forms.Panel();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            btnStringToBinary = new System.Windows.Forms.Button();
            btnBinaryToString = new System.Windows.Forms.Button();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnConvert
            // 
            btnConvert.Dock = System.Windows.Forms.DockStyle.Fill;
            btnConvert.Location = new Point(3, 3);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(508, 33);
            btnConvert.TabIndex = 1;
            btnConvert.Text = "Convert to One Line";
            btnConvert.Click += BtnConvert_Click;
            // 
            // btnScramble
            // 
            btnScramble.Dock = System.Windows.Forms.DockStyle.Fill;
            btnScramble.Location = new Point(3, 42);
            btnScramble.Name = "btnScramble";
            btnScramble.Size = new Size(508, 33);
            btnScramble.TabIndex = 1;
            btnScramble.Text = "ScrambledTextGenerator";
            btnScramble.Click += BtnScramble_Click;
            // 
            // btnReplace
            // 
            btnReplace.Dock = System.Windows.Forms.DockStyle.Fill;
            btnReplace.Location = new Point(172, 3);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new Size(163, 27);
            btnReplace.TabIndex = 1;
            btnReplace.Text = "Replace";
            btnReplace.Click += BtnReplace_Click;
            // 
            // txtFind
            // 
            txtFind.Dock = System.Windows.Forms.DockStyle.Fill;
            txtFind.Location = new Point(3, 3);
            txtFind.Multiline = true;
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(163, 27);
            txtFind.TabIndex = 3;
            // 
            // button1
            // 
            button1.Dock = System.Windows.Forms.DockStyle.Fill;
            button1.Location = new Point(341, 3);
            button1.Name = "button1";
            button1.Size = new Size(164, 27);
            button1.TabIndex = 1;
            button1.Text = "Copy";
            button1.Click += BtnCopyResult;
            // 
            // txtInput
            // 
            txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            txtInput.Location = new Point(3, 3);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(514, 182);
            txtInput.TabIndex = 4;
            txtInput.Text = "";
            // 
            // txtOutput
            // 
            txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            txtOutput.Location = new Point(3, 356);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtOutput.Size = new Size(514, 183);
            txtOutput.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(txtInput, 0, 0);
            tableLayoutPanel1.Controls.Add(txtOutput, 0, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(520, 542);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new Point(3, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(508, 33);
            panel2.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(txtFind, 0, 0);
            tableLayoutPanel2.Controls.Add(btnReplace, 1, 0);
            tableLayoutPanel2.Controls.Add(button1, 2, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(508, 33);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new Point(3, 191);
            panel3.Name = "panel3";
            panel3.Size = new Size(514, 159);
            panel3.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel3.Controls.Add(panel2, 0, 2);
            tableLayoutPanel3.Controls.Add(btnConvert, 0, 0);
            tableLayoutPanel3.Controls.Add(btnScramble, 0, 1);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(514, 159);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0000076F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(btnStringToBinary, 0, 0);
            tableLayoutPanel4.Controls.Add(btnBinaryToString, 1, 0);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 120);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(508, 36);
            tableLayoutPanel4.TabIndex = 8;
            // 
            // btnStringToBinary
            // 
            btnStringToBinary.Dock = System.Windows.Forms.DockStyle.Fill;
            btnStringToBinary.Location = new Point(3, 3);
            btnStringToBinary.Name = "btnStringToBinary";
            btnStringToBinary.Size = new Size(247, 30);
            btnStringToBinary.TabIndex = 1;
            btnStringToBinary.Text = "StringToBinary";
            btnStringToBinary.Click += BtnStringToBinary_Click;
            // 
            // btnBinaryToString
            // 
            btnBinaryToString.Dock = System.Windows.Forms.DockStyle.Fill;
            btnBinaryToString.Location = new Point(256, 3);
            btnBinaryToString.Name = "btnBinaryToString";
            btnBinaryToString.Size = new Size(249, 30);
            btnBinaryToString.TabIndex = 1;
            btnBinaryToString.Text = "BinaryToString";
            btnBinaryToString.Click += BtnBinaryToString_Click;
            // 
            // Tools
            // 
            ClientSize = new Size(520, 542);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Tools";
            Text = "Paragraph to One Line";
            Load += Tools_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnStringToBinary;
        private System.Windows.Forms.Button btnBinaryToString;
    }
}
