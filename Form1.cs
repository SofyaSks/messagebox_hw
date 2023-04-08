using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messagebox_hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MessageBox.Show("новый текст", "новый заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("новый текст", "новый заголовок", MessageBoxButtons.YesNo);
            MessageBox.Show("новый текст", "", MessageBoxButtons.OK);

            DialogResult res;

            do
            {
                res = ShowMesageBox();
            } while (res != DialogResult.Cancel);

            this.Close();
        }

        static DialogResult ShowMesageBox()
        {
            DialogResult res = MessageBox.Show("Message from programmer", "Choice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("You pressed button yes");
            }
            else if (res == DialogResult.No)
            {
                MessageBox.Show("You pressed button no");
            }
            else if (res == DialogResult.Cancel)
            {
                MessageBox.Show("You pressed button cancel");
            }

            return res;
        }

    }
}