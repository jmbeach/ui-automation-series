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
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.ButtonSetHeader = new System.Windows.Forms.Button();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.PanelMiddle = new System.Windows.Forms.Panel();
            this.LabelHello = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelPunctuation = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.PanelBottom.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.PanelMiddle.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.ButtonSetHeader);
            this.PanelBottom.Location = new System.Drawing.Point(0, 188);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(384, 89);
            this.PanelBottom.TabIndex = 2;
            // 
            // ButtonSetHeader
            // 
            this.ButtonSetHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonSetHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSetHeader.Location = new System.Drawing.Point(142, 22);
            this.ButtonSetHeader.Name = "ButtonSetHeader";
            this.ButtonSetHeader.Size = new System.Drawing.Size(100, 36);
            this.ButtonSetHeader.TabIndex = 0;
            this.ButtonSetHeader.Text = "Click Me";
            this.ButtonSetHeader.UseVisualStyleBackColor = true;
            this.ButtonSetHeader.Click += new System.EventHandler(this.ButtonSetHeader_Click);
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.flowLayoutPanel1);
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(384, 71);
            this.PanelTop.TabIndex = 3;
            // 
            // PanelMiddle
            // 
            this.PanelMiddle.Controls.Add(this.TextBoxName);
            this.PanelMiddle.Location = new System.Drawing.Point(0, 77);
            this.PanelMiddle.Name = "PanelMiddle";
            this.PanelMiddle.Size = new System.Drawing.Size(384, 105);
            this.PanelMiddle.TabIndex = 4;
            // 
            // LabelHello
            // 
            this.LabelHello.AutoSize = true;
            this.LabelHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHello.Location = new System.Drawing.Point(0, 0);
            this.LabelHello.Margin = new System.Windows.Forms.Padding(0);
            this.LabelHello.Name = "LabelHello";
            this.LabelHello.Size = new System.Drawing.Size(76, 31);
            this.LabelHello.TabIndex = 0;
            this.LabelHello.Text = "Hello";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(76, 0);
            this.LabelName.Margin = new System.Windows.Forms.Padding(0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(84, 31);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "World";
            // 
            // LabelPunctuation
            // 
            this.LabelPunctuation.AutoSize = true;
            this.LabelPunctuation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPunctuation.Location = new System.Drawing.Point(160, 0);
            this.LabelPunctuation.Margin = new System.Windows.Forms.Padding(0);
            this.LabelPunctuation.Name = "LabelPunctuation";
            this.LabelPunctuation.Size = new System.Drawing.Size(22, 31);
            this.LabelPunctuation.TabIndex = 2;
            this.LabelPunctuation.Text = "!";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.LabelHello);
            this.flowLayoutPanel1.Controls.Add(this.LabelName);
            this.flowLayoutPanel1.Controls.Add(this.LabelPunctuation);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(107, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(182, 32);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxName.BackColor = System.Drawing.Color.White;
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.Location = new System.Drawing.Point(128, 44);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(133, 30);
            this.TextBoxName.TabIndex = 0;
            this.TextBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelMiddle);
            this.Controls.Add(this.PanelBottom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelBottom.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.PanelMiddle.ResumeLayout(false);
            this.PanelMiddle.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Button ButtonSetHeader;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LabelHello;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelPunctuation;
        private System.Windows.Forms.Panel PanelMiddle;
        private System.Windows.Forms.TextBox TextBoxName;
    }
}

