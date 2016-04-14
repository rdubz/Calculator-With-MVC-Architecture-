using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;

namespace Calculator
{
    class CalculatorApplicationContext : ApplicationContext
    {
        // Number of open forms
        private int windowCount = 0;

        // Singleton ApplicationContext
        private static CalculatorApplicationContext context;

        /// <summary>
        /// Private constructor for singleton pattern
        /// </summary>
        private CalculatorApplicationContext()
        {
        }

        /// <summary>
        /// Returns the one DemoApplicationContext.
        /// </summary>
        public static CalculatorApplicationContext GetContext()
        {
            if (context == null)
            {
                context = new CalculatorApplicationContext();
            }
            return context;
        }

        /// <summary>
        /// Runs a form in this application context
        /// </summary>
        public void RunNew()
        {
            // Create the view and the controller
            Calculator view = new Calculator();
            new Controller(view);

            // One more form is running
            windowCount++;

            // When this form closes, we want to find out
            view.FormClosed += (o, e) => { if (--windowCount <= 0) ExitThread(); };

            // Run the form
            view.Show();
        }
    }
}
