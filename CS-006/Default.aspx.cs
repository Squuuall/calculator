using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_006
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(firstValueTextBox.Text);
            int b = Convert.ToInt32(secondValueTextBox.Text);
            int c = a + b;

            resultLabel.Text = c.ToString();
        }

        protected void subButton_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(firstValueTextBox.Text);
            int b = Convert.ToInt32(secondValueTextBox.Text);
            int c = a - b;

            resultLabel.Text = c.ToString();
        }

        protected void multButton_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(firstValueTextBox.Text);
            int b = Convert.ToInt32(secondValueTextBox.Text);
            int c = a * b;

            resultLabel.Text = c.ToString();
        }

        protected void divButton_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(firstValueTextBox.Text);
            int b = Convert.ToInt32(secondValueTextBox.Text);
            int c = a / b;

            resultLabel.Text = c.ToString();
        }
    }
}