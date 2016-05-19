namespace JsonPasteToJsonObjectFormatter
{
    partial class Formatter
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
            this.btnFormat = new System.Windows.Forms.Button();
            this.cbCopyToClipboard = new System.Windows.Forms.CheckBox();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(12, 12);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(140, 23);
            this.btnFormat.TabIndex = 2;
            this.btnFormat.Text = "Format";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // cbCopyToClipboard
            // 
            this.cbCopyToClipboard.AutoSize = true;
            this.cbCopyToClipboard.Checked = true;
            this.cbCopyToClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCopyToClipboard.Location = new System.Drawing.Point(158, 16);
            this.cbCopyToClipboard.Name = "cbCopyToClipboard";
            this.cbCopyToClipboard.Size = new System.Drawing.Size(136, 17);
            this.cbCopyToClipboard.TabIndex = 3;
            this.cbCopyToClipboard.Text = "Copy result to clipboard";
            this.cbCopyToClipboard.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 41);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(532, 500);
            this.txtInput.TabIndex = 4;
            this.txtInput.Text = "";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(550, 41);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(533, 502);
            this.txtOutput.TabIndex = 5;
            this.txtOutput.Text = "";
            // 
            // Formatter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 555);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.cbCopyToClipboard);
            this.Controls.Add(this.btnFormat);
            this.Name = "Formatter";
            this.Text = "JsonObject Formatter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.CheckBox cbCopyToClipboard;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.RichTextBox txtOutput;
    }
}

