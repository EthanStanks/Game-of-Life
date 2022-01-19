using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class RandomSeedForm : Form
    {
        public RandomSeedForm()
        {
            InitializeComponent();
        }

        public int GetNumber()
        {
            return (Int32)numericUpDownSeed.Value;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
        }
    }
}
