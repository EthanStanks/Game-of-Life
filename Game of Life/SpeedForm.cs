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
    public partial class SpeedForm : Form
    {
        public SpeedForm()
        {
            InitializeComponent();
        }

        public int Speed
        {
            get { return (int)numericUpDownSpeed.Value; }
            set { numericUpDownSpeed.Value = value; }
        }
    }
}
