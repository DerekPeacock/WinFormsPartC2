using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPartC.Unit5
{
    /// <summary>
    /// This form shows an animation of a helicopter which will fly across
    /// and down the screen.
    /// </summary>
    public partial class FlyMeForm : Form
    {
        private Animation animation = new Animation(4);

        public FlyMeForm()
        {
            InitializeComponent();
        }

        private void quitForm(object sender, EventArgs e)
        {
            Close();
        }

        private void startStopAnimation(object sender, EventArgs e)
        {
            if(stopRadioButton.Checked)
            {
                animationTimer.Enabled = false;
            }
            else
            {
                animationTimer.Enabled = true;
            }
        }

        private void updateCopter(object sender, EventArgs e)
        {
            copterPictureBox.Image = animation.GetNextImage();
        }

        private void loadImages(object sender, EventArgs e)
        {
            string baseFileName = "../../Images/Copter/copter";
            animation.LoadImages(baseFileName);
        }
    }
}
