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
using System.IO;

namespace PYuAssignment2
{        
    /// <summary>
    /// To design a Form to create a q puzzle game
    /// </summary>
    public partial class GameDesignForm : Form
    {

        Image gb = PYuAssignment2.Properties.Resources.greenbox;
        Image gd = PYuAssignment2.Properties.Resources.greendoor;
        Image rb = PYuAssignment2.Properties.Resources.redbox;
        Image rd = PYuAssignment2.Properties.Resources.reddoor;
        Image w = PYuAssignment2.Properties.Resources.wall;

        PictureBox picture = new PictureBox();
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        //   List<List<AllPictures>> pictureList = new List<List<AllPictures>>();
        public GameDesignForm()
        {
            InitializeComponent();
        }

        // close function
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // initialize the grid which created before
            foreach (var item in pictureBoxes)
            {
                item.Dispose();
            }
            AllPictures p = new AllPictures(this);
            int number;
            //get the input type to validate
            bool passedR = Int32.TryParse(txtRow.Text, out number);
            bool passedC = Int32.TryParse(txtCol.Text, out number);

            //if passed the validation, create a new gird
            if (passedC && passedR)
            {
                int row = Convert.ToInt32(txtRow.Text);
                int col = Convert.ToInt32(txtCol.Text);
                if (row > 0 || col > 0)
                {
                    int topEdge = 100;
                    int leftEdge = 200;
                    int xGap = 6;
                    int yGap = 6;

                    int a = leftEdge;
                    int b = topEdge;

                    for (int i = 0; i < row; i++)
                    {
                        //  List<AllPictures> r2 = new List<AllPictures>();
                        for (int j = 0; j < col; j++)
                        {

                            p = new AllPictures(this);
                            p.Left = a;
                            p.Top = b;
                            p.Image = PYuAssignment2.Properties.Resources.grey;
                            this.Controls.Add(p);
                            pictureBoxes.Add(p);
                            //  r2.Add(p);
                            a += 86 + yGap;
                            p.Click += P_Click;

                        }

                        a = leftEdge;
                        b += 86 + xGap;
                        //pictureList.Add(r2);
                    }
                }
                //if did not pass the validation
                else
                {
                    MessageBox.Show(" Please input positive integer for Row and Column.");
                }
                if ((!passedC || !passedR))
                {
                    MessageBox.Show(" Row and Column should be integier. ");
                }
            }
        }

        //pass the image from "tool box" part's button
        private void P_Click(object sender, EventArgs e)
        {

            PictureBox picBox = (PictureBox)sender;
            picBox.Image = picture.Image;


        }

        //"None" is the default
        private void GameDesignForm_Load(object sender, EventArgs e)
        {
            picture.Image = Properties.Resources.grey;
        }

        //when choose the Wall option
        private void btnWall_Click(object sender, EventArgs e)
        {
            picture.Image = Properties.Resources.wall;
            btnWall.Focus();
        }

        //when choose the Red Door option
        private void btnRedDoor_Click(object sender, EventArgs e)
        {
            picture.Image = Properties.Resources.reddoor;
            btnRedDoor.Focus();
        }
        //when choose the Green Door option
        private void btnGreenDoor_Click(object sender, EventArgs e)
        {
            picture.Image = Properties.Resources.greendoor;
            btnGreenDoor.Focus();
        }
        //when choose the Red Box option
        private void btnRedBox_Click(object sender, EventArgs e)
        {
            picture.Image = Properties.Resources.redbox;
            btnRedBox.Focus();
        }

        //When choose the Green Box option
        private void btnGreenBox_Click(object sender, EventArgs e)
        {
            picture.Image = Properties.Resources.greenbox;
            btnGreenBox.Focus();
        }
        //When choose the None option
        private void btnNone_Click(object sender, EventArgs e)
        {
            picture.Image = Properties.Resources.grey;
            btnNone.Focus();
        }

        //save file 
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> result = new List<string> { txtRow.Text, txtCol.Text };
            int door = 0;
            int box = 0;
            int wall = 0;
            foreach (var item in pictureBoxes)
            {
                int type = GetType(item.Image);
                result.Add(type.ToString());
                if (type == 1)
                {
                    wall++;
                }
                if (type == 2 || type == 3)
                {
                    door++;
                }
                if (type == 4 || type == 5)
                {
                    box++;
                }
            }

            SaveFileDialog file = new SaveFileDialog();
            //default file name
                 file.FileName = " PYuAssignment2Level1.pyu";
            // add the extension
            if (!file.FileName.EndsWith(".pyu"))
            {
                file.FileName += ".pyu";
            }

            // do not save if click cancel
            if (file.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            using (StreamWriter saveFile = new StreamWriter(file.OpenFile()))
            {
                foreach (string s in result)
                {
                    saveFile.WriteLine(s);
                }
                saveFile.Close();
            }

            string message = "File saved successfully: "
                                                + "\nTotal number of walls: " + wall.ToString()
                                                + "\nTotal number of doors: " + door.ToString()
                                                + "\nTotal number of boxes: " + box.ToString();
            MessageBox.Show(message);

        }

        //  private void button1_Click(object sender, EventArgs e)
        //  {
        //foreach (List<AllPictures> item in pictureList)
        //{
        //    foreach (AllPictures item2 in item)
        //    {
        //        if (GetType(item2.Image) == 1)

        //            wall++;
        //    }
        //}

        //if (item.Image == gd || item.Image == rd)
        //{
        //    door += 1;
        //}

        //if (item.Image == w)
        //{
        //    wall += 1;
        //}
        //if (item.Image == gb || item.Image == rb)
        //{
        //    box += 1;
        //}
        //if (item.Image == gd || item.Image == rd)
        //{
        //    door += 1;
        //}

        //if (item.Image == w)
        //{
        //    wall += 1;
        //}
    
        //check the image type
        public int GetType(Image image)
        {
            int pictureType = 0;
            if (image == gb)
            {
                pictureType = 5;

            }
            if (image == gd)
            {
                pictureType = 3;
            }
            if (image == rb)
            {
                pictureType = 4;
            }
            if (image == rd)
            {
                pictureType = 2;
            }
            if (image == w)
            {
                pictureType = 1;
            }
            return pictureType;
        }
    }
    } 
