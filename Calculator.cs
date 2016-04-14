using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Calculator : Form, ICalculator
    {
        public Calculator()
        {
            InitializeComponent();
        }

        public event Action DisplayNine;
        public event Action DisplayEight;
        public event Action DisplaySeven;
        public event Action DisplaySix;
        public event Action DisplayFive;
        public event Action DisplayFour;
        public event Action DisplayThree;
        public event Action DisplayTwo;
        public event Action DisplayOne;
        public event Action DisplayZero;
        public event Action DisplayOpenParen;
        public event Action DisplayClosingParen;
        public event Action DisplayPlus;
        public event Action DisplayMinus;
        public event Action DisplayMultiply;
        public event Action DisplayDivide;
        public event Action ClearDisplay;
        public event Func<string, string> Calculate;

        private void Nine_Click(object sender, EventArgs e)
        {
            if(DisplayNine != null)
            {
                DisplayNine();
            }
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (DisplayEight != null)
            {
                DisplayEight();
            }
        }

        public string AppendCalculatorDisplay
        {
            set
            {
                CalculatorTextBox.Text += value;
            }
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (DisplaySeven != null)
            {
                DisplaySeven();
            }
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (DisplaySix != null)
            {
                DisplaySix();
            }
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (DisplayFive != null)
            {
                DisplayFive();
            }
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (DisplayFour != null)
            {
                DisplayFour();
            }
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (DisplayThree != null)
            {
                DisplayThree();
            }
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (DisplayTwo != null)
            {
                DisplayTwo();
            }
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (DisplayOne != null)
            {
                DisplayOne();
            }
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (DisplayZero != null)
            {
                DisplayZero();
            }
        }

        private void OpenParen_Click(object sender, EventArgs e)
        {
            if (DisplayOpenParen != null)
            {
                DisplayOpenParen();
            }
        }

        private void ClosingParen_Click(object sender, EventArgs e)
        {
            if (DisplayClosingParen != null)
            {
                DisplayClosingParen();
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (DisplayPlus != null)
            {
                DisplayPlus();
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (DisplayMinus != null)
            {
                DisplayMinus();
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (DisplayMultiply != null)
            {
                DisplayMultiply();
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (DisplayDivide != null)
            {
                DisplayDivide();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if(ClearDisplay != null)
            {
                ClearDisplay();
            }
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if(Calculate != null)
            {
                CalculatorTextBox.Text = Calculate(CalculatorTextBox.Text);
            }
        }
        public void Erase()
        {
            CalculatorTextBox.Clear();
        }
    }
}
