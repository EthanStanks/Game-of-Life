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
    public partial class DialogForm : Form
    {

        public DialogForm()
        {
            InitializeComponent();
        }

        public int X
        {
            get { return (int)numericUpDownW.Value; }
            set { numericUpDownW.Value = value; }
        }

        public int Y
        {
            get { return (int)numericUpDownL.Value; }
            set { numericUpDownL.Value = value; }
        }
    }
}