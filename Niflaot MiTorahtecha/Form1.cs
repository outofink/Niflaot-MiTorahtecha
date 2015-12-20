using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Niflaot_MiTorahtecha
{

    public partial class mainWindow : Form
    {
        public string pasuk;

        public mainWindow()
        {
            InitializeComponent();
        }

        private void gregBox_CheckedChanged(object sender, EventArgs e)
        {
            if (gregBox.Checked)
            {
                lateBox.Enabled = true;
                yearInput.Minimum = -3761;
                yearInput.Value -= 3760;
                if (lateBox.Checked) { yearInput.Value -= 1; }
                yearInput.Maximum = 2128;
            }
            if (!gregBox.Checked) {
                lateBox.Enabled = false;
                yearInput.Maximum = 5888;
                yearInput.Value += 3760;
                if (lateBox.Checked) { yearInput.Value += 1; }
                yearInput.Minimum = 0;
            }

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(yearInput.Value);
            string book;

            if (gregBox.Checked) {
                number += 3760;
                if (lateBox.Checked) { number += 1; }
            }
            if (number > 4890)
            {
                number -= 4890;
                book = "דברים ";
                pasuk = File.ReadLines("text/devarim.txt").Skip(number - 1).Take(1).First();
            }
            else if (number > 3602)
            {
                number -= 3602;
                book = "במדבר ";
                pasuk = File.ReadLines("text/bamidbar.txt").Skip(number - 1).Take(1).First();
            }
            else if (number > 2743)
            {
                number -= 2743;
                book = "ויקרא ";
                pasuk = File.ReadLines("text/vayikra.txt").Skip(number - 1).Take(1).First();
            }
            else if (number > 1534)
            {
                number -= 1534;
                book = "שמות ";
                pasuk = File.ReadLines("text/shemot.txt").Skip(number - 1).Take(1).First();
            }
            else {
                book = "בראשית ";
                pasuk = File.ReadLines("text/bereshis.txt").Skip(number - 1).Take(1).First();

            }
            locationText.Text = book + pasuk.Substring(0, pasuk.IndexOf(','));
            pasukText.Text = pasuk.Substring(pasuk.IndexOf(',')+1);
        }
    }
}
