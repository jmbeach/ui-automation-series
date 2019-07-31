using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Resize += Form1_Resize;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            PanelBottom.Width = Width;
            PanelMiddle.Width = Width;
            PanelTop.Width = Width;
        }

        private void ButtonSetHeader_Click(object sender, EventArgs e)
        {
            LabelName.Text = TextBoxName.Text;
            flowLayoutPanel1.Location = new Point((Width / 2) - (flowLayoutPanel1.Width / 2), flowLayoutPanel1.Location.Y);
        }
    }
}
