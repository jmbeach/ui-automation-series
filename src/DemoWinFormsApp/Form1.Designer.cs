namespace DemoWinFormsApp
{
    partial class Form1
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
            this.HeaderText = new System.Windows.Forms.Label();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.ButtonSetHeader = new System.Windows.Forms.Button();
            this.PanelBottom.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderText
            // 
            this.HeaderText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderText.Location = new System.Drawing.Point(0, 0);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(384, 131);
            this.HeaderText.TabIndex = 0;
            this.HeaderText.Text = "Hello World!";
            this.HeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.HeaderText);
            this.PanelBottom.Location = new System.Drawing.Point(0, 0);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(384, 131);
            this.PanelBottom.TabIndex = 1;
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.ButtonSetHeader);
            this.PanelTop.Location = new System.Drawing.Point(0, 134);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(384, 143);
            this.PanelTop.TabIndex = 2;
            // 
            // ButtonSetHeader
            // 
            this.ButtonSetHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSetHeader.Location = new System.Drawing.Point(142, 49);
            this.ButtonSetHeader.Name = "ButtonSetHeader";
            this.ButtonSetHeader.Size = new System.Drawing.Size(100, 36);
            this.ButtonSetHeader.TabIndex = 0;
            this.ButtonSetHeader.Text = "Click Me";
            this.ButtonSetHeader.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelBottom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelBottom.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Button ButtonSetHeader;
    }
}

