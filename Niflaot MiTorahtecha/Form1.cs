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
            if (number > 4878)
            {
                number -= 4878;
                book = "Devarim";
                pasuk = File.ReadLines("devarim.txt").Skip(number - 1).Take(1).First();
            }
            else if (number > 3589)
            {
                number -= 3589;
                book = "Bamidbar";
                pasuk = File.ReadLines("bamidbar.txt").Skip(number - 1).Take(1).First();
            }
            else if (number > 2730)
            {
                number -= 2730;
                book = "Vayikra";
                pasuk = File.ReadLines("vayikra.txt").Skip(number - 1).Take(1).First();
            }
            else if (number > 1533)
            {
                number -= 1533;
                book = "Shemot";
                pasuk = File.ReadLines("shemot.txt").Skip(number - 1).Take(1).First();
            }
            else {
                book = "Bereshis";
                pasuk = File.ReadLines("bereshis.txt").Skip(number - 1).Take(1).First();

            }
            locationText.Text = book + pasuk.Substring(0, 10);
            pasukText.Text = pasuk.Substring(10);
        }

    }
}
