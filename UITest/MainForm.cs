using System;
using System.Windows.Forms;
using UIDLL;

namespace UITest
{
    public class MainForm : Form
    {
        Label label1 ;
        TextBox textBoxA ;
        TextBox textBoxB;

        Button btnAdd;

        public MainForm()
        {

             label1 = new Label();
             textBoxA = new TextBox();
             textBoxB = new TextBox();

             btnAdd = new Button();

            btnAdd.Text = "Add";
            btnAdd.Click += BtnAdd_Click;

            this.Controls.Add(btnAdd);
            this.Controls.Add(textBoxB);
            this.Controls.Add(textBoxA);
            this.Controls.Add(label1);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            label1.Text = BusinessCls.Cal(textBoxA.Text, textBoxB.Text).ToString();
        }
    }
}
