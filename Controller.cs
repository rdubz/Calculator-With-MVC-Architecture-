using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expression;

namespace Calculator
{
    public class Controller
    {
        private ICalculator view;

        private Express model;

        public Controller(ICalculator view)
        {
            this.view = view;
            model = new Express();
            //regiseter all the interface events to methods in the controller to be handled
            view.DisplayNine += HandleDisplayNine;
            view.DisplayEight += HandleDisplayEight;
            view.DisplaySeven += HandleDisplaySeven;
            view.DisplaySix += HandleDisplaySix;
            view.DisplayFive += HandleDisplayFive;
            view.DisplayFour += HandleDisplayFour;
            view.DisplayThree += HandleDisplayThree;
            view.DisplayTwo += HandleDisplayTwo;
            view.DisplayOne += HandleDisplayOne;
            view.DisplayZero += HandleDisplayZero;
            view.DisplayMultiply += HandleDisplayMult;
            view.DisplayDivide += HandleDisplayDivide;
            view.DisplayOpenParen += HandleDisplayOpenParen;
            view.DisplayClosingParen += HandleDisplayClosingParen;
            view.DisplayPlus += HandleDisplayPlus;
            view.DisplayMinus += HandleDisplayMinus;
            view.ClearDisplay += HandleClearDisplay;
            view.Calculate += HandleCalculate;
        }

        private string HandleCalculate(string expression)
        {
            try
            {

                view.Erase();
                model.SetExpression = expression;
                return model.Evaluate().ToString();
            }
            catch(ExpressionFormatException e)
            {
                return "Sorry, invalid expression";
            }
            catch(ExpressionEvaluationException e)
            {
                return e.Message;
            }
        }

        private void HandleClearDisplay()
        {
            view.Erase();
        }

        private void HandleDisplayMinus()
        {
            view.AppendCalculatorDisplay = "-";
        }

        private void HandleDisplayPlus()
        {
            view.AppendCalculatorDisplay = "+";
        }

        private void HandleDisplayNine()
        {
            view.AppendCalculatorDisplay = "9";
        }

        private void HandleDisplayEight()
        {
            view.AppendCalculatorDisplay = "8";
        }

        private void HandleDisplaySeven()
        {
            view.AppendCalculatorDisplay = "7";
        }

        private void HandleDisplaySix()
        {
            view.AppendCalculatorDisplay = "6";
        }

        private void HandleDisplayFive()
        {
            view.AppendCalculatorDisplay = "5";
        }

        private void HandleDisplayFour()
        {
            view.AppendCalculatorDisplay = "4";
        }

        private void HandleDisplayThree()
        {
            view.AppendCalculatorDisplay = "3";
        }

        private void HandleDisplayTwo()
        {
            view.AppendCalculatorDisplay = "2";
        }

        private void HandleDisplayOne()
        {
            view.AppendCalculatorDisplay = "1";
        }

        private void HandleDisplayZero()
        {
            view.AppendCalculatorDisplay = "0";
        }

        private void HandleDisplayMult()
        {
            view.AppendCalculatorDisplay = "*";
        }

        private void HandleDisplayDivide()
        {
            view.AppendCalculatorDisplay = "/";
        }

        private void HandleDisplayOpenParen()
        {
            view.AppendCalculatorDisplay = "(";
        }

        private void HandleDisplayClosingParen()
        {
            view.AppendCalculatorDisplay = ")";
        }

        
    }
}
