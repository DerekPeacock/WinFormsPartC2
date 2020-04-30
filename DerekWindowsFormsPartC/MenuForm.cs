using System;
using System.Windows.Forms;
using WindowsFormsPartC.Unit5;

namespace WindowsFormsPartC
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void runProgram(object sender, EventArgs e)
        {
            if(animationRadioButton.Checked)
            {
                // Tasks 5.1 and 5.2

                AnimationForm form = new AnimationForm();
                form.Show();
            }
            else if(flyMeRadioButton.Checked)
            {
                // Tasks 5.3, 5.4 and 5.5
                FlyMeForm form = new FlyMeForm();
                form.Show();
            }
        }

        private void quitForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}
