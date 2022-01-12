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
        // Default text for the form title
        string formTitle = "Change Universe Size";

        // X of the uni
        int x = 30;

        // Y of the uni
        int y = 30;

        // Bool if true will commit the changes made
        bool commitChange = false;

        public DialogForm()
        {
            InitializeComponent();
            labelTitle.Text = formTitle;
            commitChange = false;
        }

        public int DialogX
        {
            get { return x; }
            set { x = value; }
        }
        public int DialogY
        {
            get { return y; }
            set { y = value; }
        }
        public string FormTitle
        {
            get { return formTitle; }
            set { formTitle = value; }
        }
        public bool FormCommit
        {
            get { return commitChange; }
        }

        private void textBoxW_TextChanged(object sender, EventArgs e) // Width text box
        {
            int vari;
            bool success = int.TryParse(textBoxW.Text, out vari);
            if (success) x = vari;
        }

        private void textBoxL_TextChanged(object sender, EventArgs e) // Length text box
        {
            int vari;
            bool success = int.TryParse(textBoxL.Text, out vari);
            if (success) y = vari;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            commitChange = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            commitChange = false;
        }
    }
}