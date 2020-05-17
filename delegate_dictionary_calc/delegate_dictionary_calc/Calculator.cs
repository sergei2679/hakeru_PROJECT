using System;
using System.Collections.Generic;

namespace delegate_dictionary_calc
{
    class Calculator
    {
        static Dictionary<string, Func<double, double, double>> _operations;

        public Calculator()
        {
            // with lambda
            _operations =
               new Dictionary<string, Func<double, double, double>>
               {
                    { "+", (x, y) => x + y },
                    { "-", (x, y) => x - y },
                    { "*", (x, y) => x * y },
                    { "/", (x, y) => x / y }
               };

        }

        // with method
        //private static double DoDivision(double x, double y) { return x / y; }
        //private static double DoMultiplication(double x, double y) { return x * y; }
        //private static double DoSubtraction(double x, double y) { return x - y; }
        //private static double DoAddition(double x, double y) { return x + y; }


        public double PerformOperation(string op, double x, double y)
        {
            if (!_operations.ContainsKey(op))
                throw new ArgumentException(string.Format("Operation {0} is invalid", op), "op");
            return _operations[op](x, y);
        }


        public void DefineOperation(string op, Func<double, double, double> body)
        {
            if (_operations.ContainsKey(op))
                throw new ArgumentException(string.Format("Operation {0} already exists", op), "op");
            _operations.Add(op, body);
        }

    }
}