namespace Translate
{
    partial class Form1
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
            txtInput = new TextBox();
            txtOutput = new TextBox();
            cmbFrom = new ComboBox();
            cmbTo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnTranslate = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtInput.Location = new Point(12, 48);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(833, 34);
            txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtOutput.Location = new Point(12, 242);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(833, 34);
            txtOutput.TabIndex = 1;
            // 
            // cmbFrom
            // 
            cmbFrom.FormattingEnabled = true;
            cmbFrom.Location = new Point(122, 17);
            cmbFrom.Name = "cmbFrom";
            cmbFrom.Size = new Size(151, 28);
            cmbFrom.TabIndex = 2;
            // 
            // cmbTo
            // 
            cmbTo.FormattingEnabled = true;
            cmbTo.Location = new Point(122, 208);
            cmbTo.Name = "cmbTo";
            cmbTo.Size = new Size(151, 28);
            cmbTo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 4;
            label1.Text = "Translate from";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 211);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 5;
            label2.Text = "Translate to";
            // 
            // btnTranslate
            // 
            btnTranslate.Location = new Point(12, 88);
            btnTranslate.Name = "btnTranslate";
            btnTranslate.Size = new Size(104, 29);
            btnTranslate.TabIndex = 6;
            btnTranslate.Text = "Translate";
            btnTranslate.UseVisualStyleBackColor = true;
            btnTranslate.Click += btnTranslate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 450);
            Controls.Add(btnTranslate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbTo);
            Controls.Add(cmbFrom);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private TextBox txtOutput;
        private ComboBox cmbFrom;
        private ComboBox cmbTo;
        private Label label1;
        private Label label2;
        private Button btnTranslate;
    }
}
