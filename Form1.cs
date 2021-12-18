using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matto_Image_Viewer
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        private void forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        private void reload_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
        private void go_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(addressBox.Text);
        }

        private void home_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://browserhome.matto58.rf.gd");
        }

        private void search(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://duckduckgo.com/?q=" + searchBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mtweb.Form2 f2 = new mtweb.Form2();
            f2.ShowDialog();
        }
    }
}
