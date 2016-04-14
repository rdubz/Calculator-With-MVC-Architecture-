using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ICalculator
    {
        event Action DisplayNine;
        event Action DisplayEight;
        event Action DisplaySeven;
        event Action DisplaySix;
        event Action DisplayFive;
        event Action DisplayFour;
        event Action DisplayThree;
        event Action DisplayTwo;
        event Action DisplayOne;
        event Action DisplayZero;
        event Action DisplayOpenParen;
        event Action DisplayClosingParen;
        event Action DisplayPlus;
        event Action DisplayMinus;
        event Action DisplayMultiply;
        event Action DisplayDivide;
        event Action ClearDisplay;
        event Func<string, string> Calculate;
        string AppendCalculatorDisplay { set; }
        void Erase();
    }
}
