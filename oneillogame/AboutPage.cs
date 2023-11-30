using oneillogame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oneillogame
{
    public partial class AboutPage : Form
    {
        private string formMessage;
        private ResourceManager rm = new ResourceManager(typeof(AboutPage));

        public AboutPage()
        {
            InitializeComponent();

        }
        //**Ok button to close the window**//
        private void aboutPageOkButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        //**Main about page**//
        private void AboutPage_Load(object sender, EventArgs e)
        {
            formMessage = rm.GetString("aboutText");
            aboutTheGameInfo.Text = formMessage;
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }
        //**About game info area**//
        private void aboutTheGameInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelGameName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void informationBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
