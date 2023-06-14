using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDO
{
    public abstract class Function
    {
        public abstract double Evaluate(Dictionary<char, double> variables);
        public override abstract string ToString();

        public static Function Read(string function)
        {
            return Read(function, 0, function.Length - 1);
        }
        private static Function Read(string function, int posI, int posF)
        {
            if (function.Length > 0)
            {
                int counter = 0;
                //Expression starts with parenthesis
                if (function[posI] == '(')
                {
                    counter = 0;
                    for (int i = posI; i <= posF; i++)
                    {
                        if (function[i] == '(') counter++;
                        if (function[i] == ')') counter--;
                        if (counter == 0)
                        {
                            if (i == posF)
                                return Read(function, posI + 1, posF - 1);
                            else break;
                        }
                    }
                }

                //finding aditions or substractions
                counter = 0;
                for (int i = posI; i <= posF; i++)
                {
                    if (function[i] == '(') counter++;
                    if (function[i] == ')') counter--;
                    if (counter == 0 && (function[i] == '+' || function[i] == '-'))
                    {
                        if (function[i] == '+')
                            return new Adition(Read(function, posI, i - 1), Read(function, i + 1, posF));
                        else
                        {
                            if (i != posI) //"-" working as substraction operator operator
                                return new Substraction(Read(function, posI, i - 1), Read(function, i + 1, posF));
                            //else, since is working as multiplication by -1 it will be detected in multiplication
                        } 
                    }
                }

                //finding multiplications or divisions
                counter = 0;
                for (int i = posI; i <= posF; i++)
                {
                    if (function[i] == '(') counter++;
                    if (function[i] == ')') counter--;
                    if (counter == 0 && (function[i] == '*' || function[i] == '/' || function[i] == '-'))
                    {
                        if (function[i] == '*')
                            return new Multiplication(Read(function, posI, i - 1), Read(function, i + 1, posF));
                        else if (function[i] == '/')
                            return new Division(Read(function, posI, i - 1), Read(function, i + 1, posF));
                        else if(i==posI) return new Multiplication(new Constant(-1), Read(function, posI + 1, posF));
                    }
                }

                //finding powers or log
                counter = 0;
                for (int i = posI; i <= posF; i++)
                {
                    if (function[i] == '(') counter++;
                    if (function[i] == ')') counter--;
                    if (counter == 0 && function[i] == '^')
                    {
                        return new Power(Read(function, posI, i - 1), Read(function, i + 1, posF));
                    }
                }

                //finding trigonometrics and log
                if (posF - posI >= 3)
                {
                    string start = function.Substring(posI, 3);
                    if (start == "log")
                        return new LogNat(Read(function, posI + 3, posF));
                    else if (start == "sin")
                        return new Sin(Read(function, posI + 3, posF));
                    else if (start == "cos")
                        return new Cos(Read(function, posI + 3, posF));
                    else if (start == "cot")
                        return new Cot(Read(function, posI + 3, posF));
                    else if (start == "tan")
                        return new Tan(Read(function, posI + 3, posF));
                    else if (start == "cos")
                        return new Cot(Read(function, posI + 3, posF));
                    else if (start == "asn")
                        return new Asin(Read(function, posI + 3, posF));
                    else if (start == "acs")
                        return new Acos(Read(function, posI + 3, posF));
                    else if (start == "atn")
                        return new Atan(Read(function, posI + 3, posF));
                    else if (start == "act")
                        return new Acot(Read(function, posI + 3, posF));
                    else
                    {
                        double value;
                        if (double.TryParse(function.Substring(posI, posF - posI), out value))
                        {
                            return new Constant(value);
                        }
                    }
                }
                else
                {
                    double value;
                    if (double.TryParse(function.Substring(posI, posF - posI + 1), out value))
                    {
                        return new Constant(value);
                    }
                    else
                    {
                        if (posF - posI > 0) throw new Exception("Invalid Expression");
                        else return new Variable(function[posI]);
                    }
                }
            }

            throw new Exception("Invalid Expression");
        }

    }

    public abstract class BinaryFunction : Function
    {
        protected Function op1;
        protected Function op2;
    }
    public abstract class UnaryFunction : Function
    {
        protected Function op;
    }

    //Unary functions
    public class Constant : UnaryFunction
    {
        double value;
        public Constant(double x)
        {
            value = x;
        }

        public override double Evaluate(Dictionary<char, double> variables)
        {
            return value;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
    public class Variable : UnaryFunction
    {
        char id;

        public Variable(char identifier)
        {
            if (identifier != 'x' && identifier != 'y' && identifier != 'z' && identifier != 'm')
                throw new Exception("Invalid Identifier");
            id = identifier;
        }
        public override double Evaluate(Dictionary<char, double> variables)
        {
            if (variables.ContainsKey(id))
                return variables[id];
            else throw new Exception("Invalid Evaluation");
        }

        public override string ToString()
        {
            return id.ToString();
        }
    }
    public class Sin : UnaryFunction
    {
        public Sin(Function function)
        {
            op = function;
        }
        public override double Evaluate(Dictionary<char, double> variables)
        {
            return Math.Sin(op.Evaluate(variables));
        }

        public override string ToString()
        {
            return "(sin" + op.ToString()+")";
        }
    }
    public class Cos : UnaryFunction
    {
        public Cos(Function function)
        {
            op = function;
        }
        public override double Evaluate(Dictionary<char, double> variables)
        {
            return Math.Cos(op.Evaluate(variables));
        }

        public override string ToString()
        {
            return "(cos" + op.ToString() + ")";
        }
    }
    public class Tan : UnaryFunction
    {
        public Tan(Function function)
        {
            op = function;
        }
        public override double Evaluate(Dictionary<char, double> variables)
        {
            return Math.Tan(op.Evaluate(variables));
        }

        public override string ToString()
        {
            return "(tan" + op.ToString() + ")";
        }
    }
    public class Cot : UnaryFunction
    {
        public Cot(Function function)
        {
            op = function;
        }
        public override double Evaluate(Dictionary<char, double> variables)
        {
            return 1/Math.Tan(op.Evaluate(variables));
        }

        public override string ToString()
        {
            return "(cot" + op.ToString() + ")";
        }
    }
    public class Asin : UnaryFunction
    {
        public Asin(Function function)
        {
            op = function;
        }
        public override double Evaluate(Dictionary<char, double> variables)
        {
            return Math.Asin(op.Evaluate(variables));
        }

        public override string ToString()
        {
            return "(asn" + op.ToString() + ")";
        }
    }
    public class Acos : UnaryFunction
    {
        public Acos(Function function)
        {
            op = function;
        }
        public override double Evaluate(Dictionary<char, double> variables)
        {
            return Math.Acos(op.Evaluate(variables));
        }

        public override string ToString()
        {
            return "(acs" + op.ToString() + ")";
        }
    }
    public class Atan:UnaryFunction
    {
        public Atan(Function function)
        {
            op = function;
        }
        public override double Evaluate(Dictionary<char, double> variables)
        {
            return Math.Atan(op.Evaluate(variables));
        }

        public override string ToString()
        {
            return "(atn" + op.ToString() + ")";
        }
    }
    public class Acot:UnaryFunction
    {
        public Acot(Function function)
        {
            op = function;
        }
        public override double Evaluate(Dictionary<char, double> variables)
        {
            return 1 / Math.Atan(op.Evaluate(variables));
        }

        public override string ToString()
        {
            return "(act" + op.ToString() + ")";
        }
    }
    public class LogNat : UnaryFunction
    {
        public LogNat(Function function)
        {
            op = function;
        }
        public override double Evaluate(Dictionary<char, double> variables)
        {
            return Math.Log(op.Evaluate(variables));
        }

        public override string ToString()
        {
            return "(log" + op.ToString() + ")";
        }
    }

    //Binary functions
    public class Adition : BinaryFunction
    {
        public Adition(Function operator1, Function operator2)
        {
            op1 = operator1;
            op2 = operator2;

        }
        public override double Evaluate(Dictionary<char, double> variables)
        {
            return op1.Evaluate(variables) + op2.Evaluate(variables);
        }

        public override string ToString()
        {
            return "(" + op1.ToString() + "+" + op2.ToString() + ")";
        }
    }
    public class Substraction : BinaryFunction
    {
        public Substraction(Function operator1, Function operator2)
        {
            op1 = operator1;
            op2 = operator2;

        }
        public override double Evaluate(Dictionary<char, double> variables)
        {
            return op1.Evaluate(variables) - op2.Evaluate(variables);
        }

        public override string ToString()
        {
            return "(" + op1.ToString() + "-" + op2.ToString() + ")";
        }
    }
    public class Multiplication : BinaryFunction
    {
        public Multiplication(Function operator1, Function operator2)
        {
            op1 = operator1;
            op2 = operator2;

        }
        public override double Evaluate(Dictionary<char, double> variables)
        {
            return op1.Evaluate(variables) * op2.Evaluate(variables);
        }

        public override string ToString()
        {
            return "(" + op1.ToString() + "*" + op2.ToString() + ")";
        }
    }
    public class Division : BinaryFunction
    {
        public Division(Function operator1, Function operator2)
        {
            op1 = operator1;
            op2 = operator2;

        }
        public override double Evaluate(Dictionary<char, double> variables)
        {
            return op1.Evaluate(variables) / op2.Evaluate(variables);
        }

        public override string ToString()
        {
            return "(" + op1.ToString() + "/" + op2.ToString() + ")";
        }
    }
    public class Power : BinaryFunction
    {
        public Power(Function operator1, Function operator2)
        {
            op1 = operator1;
            op2 = operator2;

        }
        public override double Evaluate(Dictionary<char, double> variables)
        {
            return Math.Pow(op1.Evaluate(variables), op2.Evaluate(variables));
        }

        public override string ToString()
        {
            return "(" + op1.ToString() + "^" + op2.ToString() + ")";
        }
    }
    

    public class EDO
    {
        public static IEnumerable<double[]> EulerMethod(double x, double y, double end, int iterations, Function f) //Expression fija cos^2(x)/2*x^(1/2)
        {
            double h = (end - x) / iterations;

            for (int i = 0; i < iterations; i++)
            {
                    x += h;
                //try
                //{
                y += h * Evaluator(x, y, f, 'x', 'y');
                    yield return new double[] { x, y };
                //}
                //finally { }
            }
        }
        public static double Evaluator(double x, double y, Function function, char var1, char var2)
        {
            Dictionary<char, double> dic = new Dictionary<char, double>();
            dic[var1] = x;
            dic[var2] = y;
            return function.Evaluate(dic);
        }
        public static double ResultEvaluator(double x, Function function)
        {
            Dictionary<char, double> dic = new Dictionary<char, double>();
            dic['x'] = x;
            return function.Evaluate(dic);
            //return Math.Atan(Math.Sqrt(x) -1);
        }
    }
}
