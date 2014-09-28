using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problemSet2_prob2
{
    public partial class FindMinAndMaxForm : Form
    {
        public FindMinAndMaxForm()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            int max ;
            int min;
            min = max = Convert.ToInt32(firstNumberTextBox.Text);


            List<int> numbers = new List<int>();



            int nowAtTextBox = 0;
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof (TextBox))
                {
                    //numbers.Add(Convert.ToInt32((control as TextBox).Text));

                    nowAtTextBox = Convert.ToInt32((control as TextBox).Text);

                    if (max < nowAtTextBox)
                    {
                        max = nowAtTextBox;
                    }

                    if (min > nowAtTextBox)
                    {
                        min = nowAtTextBox;
                    }
                    
                }
            }


           

            maxValueLabel.Text = max.ToString();
            minValueLabel.Text = min.ToString();

        }
    }
}
