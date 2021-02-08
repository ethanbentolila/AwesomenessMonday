
namespace AwesomenessMonday
{
    partial class formAwesomeness
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
            this.components = new System.ComponentModel.Container();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonLeftNo = new System.Windows.Forms.Button();
            this.buttonRightNo = new System.Windows.Forms.Button();
            this.labelAwesomenessPrompt = new System.Windows.Forms.Label();
            this.toolTipAwesomeness = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(15, 86);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(75, 23);
            this.buttonYes.TabIndex = 1;
            this.buttonYes.Text = "&Yes";
            this.toolTipAwesomeness.SetToolTip(this.buttonYes, "Click if you are awesome");
            this.buttonYes.UseCompatibleTextRendering = true;
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonLeftNo
            // 
            this.buttonLeftNo.Location = new System.Drawing.Point(140, 86);
            this.buttonLeftNo.Name = "buttonLeftNo";
            this.buttonLeftNo.Size = new System.Drawing.Size(75, 23);
            this.buttonLeftNo.TabIndex = 2;
            this.buttonLeftNo.Text = "&No";
            this.toolTipAwesomeness.SetToolTip(this.buttonLeftNo, "Click if you are not awesome");
            this.buttonLeftNo.UseCompatibleTextRendering = true;
            this.buttonLeftNo.UseVisualStyleBackColor = true;
            this.buttonLeftNo.Click += new System.EventHandler(this.buttonLeftNo_Click);
            this.buttonLeftNo.MouseEnter += new System.EventHandler(this.buttonLeftNo_Click);
            // 
            // buttonRightNo
            // 
            this.buttonRightNo.Location = new System.Drawing.Point(265, 86);
            this.buttonRightNo.Name = "buttonRightNo";
            this.buttonRightNo.Size = new System.Drawing.Size(75, 23);
            this.buttonRightNo.TabIndex = 3;
            this.buttonRightNo.Text = "&No";
            this.toolTipAwesomeness.SetToolTip(this.buttonRightNo, "Click if you are not awesome");
            this.buttonRightNo.UseCompatibleTextRendering = true;
            this.buttonRightNo.UseVisualStyleBackColor = true;
            this.buttonRightNo.Visible = false;
            this.buttonRightNo.Click += new System.EventHandler(this.buttonRightNo_Click);
            this.buttonRightNo.MouseEnter += new System.EventHandler(this.buttonRightNo_Click);
            // 
            // labelAwesomenessPrompt
            // 
            this.labelAwesomenessPrompt.AutoSize = true;
            this.labelAwesomenessPrompt.Location = new System.Drawing.Point(12, 21);
            this.labelAwesomenessPrompt.Name = "labelAwesomenessPrompt";
            this.labelAwesomenessPrompt.Size = new System.Drawing.Size(329, 34);
            this.labelAwesomenessPrompt.TabIndex = 0;
            this.labelAwesomenessPrompt.Text = "The computer has detected that you are awesome.\r\nIs it possible that you are awes" +
    "ome?";
            this.labelAwesomenessPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formAwesomeness
            // 
            this.AcceptButton = this.buttonYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 134);
            this.Controls.Add(this.labelAwesomenessPrompt);
            this.Controls.Add(this.buttonRightNo);
            this.Controls.Add(this.buttonLeftNo);
            this.Controls.Add(this.buttonYes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAwesomeness";
            this.Text = "Awesomeness Detector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonLeftNo;
        private System.Windows.Forms.Button buttonRightNo;
        private System.Windows.Forms.Label labelAwesomenessPrompt;
        private System.Windows.Forms.ToolTip toolTipAwesomeness;
    }
}

