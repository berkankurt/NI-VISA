using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NationalInstruments.Visa;

namespace kaynak
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var rmSession = new ResourceManager())
            {
                var resources = rmSession.Find("(ASRL|GPIB|TCPIP|USB)?*");
                foreach (string s in resources)
                {
                    USB_Kaynaklar.Items.Add(s);
                }
            }
        }

        

        private void visaResourceNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
        string secili = USB_Kaynaklar.Items[USB_Kaynaklar.SelectedIndex].ToString();
        sec.Text=(secili);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
