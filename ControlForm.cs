/*Peng Yu 8620032
 * For design the Q puzzle game
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYuAssignment2
{
    public partial class ControlForm : Form
    {

        public ControlForm()
        {
            InitializeComponent();
        }
        // click the exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // go to the design form on click
        private void btnDesign_Click(object sender, EventArgs e)
        {
            GameDesignForm designForm = new GameDesignForm();
            designForm.Show();
        }
    }
}
