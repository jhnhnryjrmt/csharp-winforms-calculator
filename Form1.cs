namespace calculator;
using System;
using System.Windows.Forms;

public partial class Form1 : Form
{

    public Form1()
    {
        InitializeComponent();
    }

    private void sevenBtn_Click(object sender, EventArgs e)
    {
        CheckZero();
        numberTextBox.Text += sevenBtn.Text;
    }

    private void eightBtn_Click(object sender, EventArgs e)
    {
        CheckZero();
        numberTextBox.Text += eightBtn.Text;
    }



    private void CheckZero()
    {
        if (numberTextBox.Text == "0")
        {
            numberTextBox.Clear();
        }
    }

    private void nineBtn_Click(object sender, EventArgs e)
    {
        CheckZero();
        numberTextBox.Text += nineBtn.Text;
    }

    private void clearBtn_Click(object sender, EventArgs e)
    {
        numberTextBox.Clear();
        numberTextBox.Text = "0";
    }

    private void fourBtn_Click(object sender, EventArgs e)
    {
        CheckZero();
        numberTextBox.Text += fourBtn.Text;
    }

    private void fiveBtn_Click(object sender, EventArgs e)
    {
        CheckZero();
        numberTextBox.Text += fiveBtn.Text;
    }

    private void sixBtn_Click(object sender, EventArgs e)
    {
        CheckZero();
        numberTextBox.Text += sixBtn.Text;
    }

    private void oneBtn_Click(object sender, EventArgs e)
    {
        CheckZero();
        numberTextBox.Text += oneBtn.Text;
    }

    private void twoBtn_Click(object sender, EventArgs e)
    {
        CheckZero();
        numberTextBox.Text += twoBtn.Text;
    }

    private void threeBtn_Click(object sender, EventArgs e)
    {
        CheckZero();
        numberTextBox.Text += threeBtn.Text;
    }

    private void zeroBtn_Click(object sender, EventArgs e)
    {
        CheckZero();
        numberTextBox.Text += zeroBtn.Text;
    }

    private void decimalBtn_Click(object sender, EventArgs e)
    {
        if (!numberTextBox.Text.Contains("."))
        {
            if (numberTextBox.Text == "")
            {
                numberTextBox.Text = "0.";
            }
            else
            {
                numberTextBox.Text += ".";
            }
        }
    }
}