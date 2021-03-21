using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYuAssignment2
{

    public class AllPictures : PictureBox
    {

       GameDesignForm designForm;
        //store value below
       public AllPictures (GameDesignForm designForm)
        {
            this.Image = PYuAssignment2.Properties.Resources.grey;
            this.designForm = designForm;
            this.Height = 86;
            this.Width = 86;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
