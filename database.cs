using System;
using System.Drawing;
using System.Windows.Forms;

public class Form1 : Form
{

    private Button button;
    private TextBox textBox1;
    public void FormLayout()
    {
        this.DisplayGUI();
    }
    private void DisplayGUI() {
            this.Name = "Employee Application";
            this.Text = "Employee Application";
            this.Size = new Size(1600, 800);
            textBox1 = new TextBox();
            textBox1.Size = new Size(100,100);
            button = new Button();
            button.Name = "button";
            button.Text = "Click Me!";
            button.Size = new Size(50, 100);
            button.Location = new Point(
                (this.Width - button.Width) / 3 ,
                (this.Height - button.Height) / 3);
            button.Click += new System.EventHandler(this.MyButtonClick);

            this.Controls.Add(button);
            this.Controls.Add(textBox1);
        }

        private void MyButtonClick(object source, EventArgs e) {
            MessageBox.Show("My First WinForm Application");
        }
}