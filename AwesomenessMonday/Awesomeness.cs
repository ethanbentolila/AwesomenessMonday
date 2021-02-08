//Written By: Ethan Bentolila
//Date: January 11th 2021
// Application to tell someone they are awesome
//adding a random comment
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwesomenessMonday
{
    public partial class formAwesomeness : Form
    {
        public formAwesomeness()
        {
            InitializeComponent();
        }
        /// <summary>
        /// User clicked yes; they are awesome, end the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yes. You are awesome. Thank you and have a good day.");
           
            Close();
        }

        /// <summary>
        /// User tried to click no; hide the left button, show the right button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLeftNo_Click(object sender, EventArgs e)
        {
            buttonLeftNo.Visible = false;
            buttonRightNo.Visible = true;
        }

        /// <summary>
        /// User tried to click no; hide the right button, show the left button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRightNo_Click(object sender, EventArgs e)
        {
            buttonLeftNo.Visible = true;
            buttonRightNo.Visible = false;
        }
    }
}
