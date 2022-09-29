using System;
using System.Text.RegularExpressions;

namespace ICT3101_Calculator
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN;
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;

                case "s":
                    result = Subtract(num1, num2);
                    break;

                case "m":
                    result = Multiply(num1, num2);
                    break;

                case "d":
                    result = Divide(num1, num2);
                    break;

                case "f":
                    result = Factorial(num1);
                    break;

                default:
                    break;
            }
            return result;
        }

        public double Add(double num1, double num2)
        {
            String num1String = num1.ToString();
            String num2String = num2.ToString();

            if (Regex.IsMatch(num1String, "^[01]+$") && Regex.IsMatch(num2String, "^[01]+$"))
            {
                String binarySum = num1String + num2String;
                String result = Convert.ToInt32(binarySum, 2).ToString();
                double finalResult =  Convert.ToDouble(result);
                return Convert.ToDouble(result);
            }

            return (num1 + num2);
        }

        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }

        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }

        public double Divide(double num1, double num2)
        {
            if (num1 == 0 && num2 == 0)
            {
                //throw new ArgumentException("positive_infinity");
                return 1;
            } 
            if (num1 == 0 && num2 != 0)
            {
                return 0;
            }
            if (num1 != 0 && num2 == 0)
            {
                return Double.PositiveInfinity;
            }
            
            return (num1 / num2);
            
        }

        // Start Q15
        public double Factorial(double num1)
        {
            if (num1 < 0)
            {
                throw new ArgumentException("Value must be 0 or more");
            }
            else
            {
                double result = 1;
                for (int i = 1; i <= num1; i++)
                {
                    result = result * i;
                }
                return result;
            }
        }
        // End Q15

        // Start Q16
        public double AreaOfTriangle(double num1, double num2)
        {
            if (num1 < 1 || num2 < 1)
            {
                throw new ArgumentException("Invalid Input");
            } else
            {
                return (Multiply(num1, num2) * 0.5);
            }
        }

        public double AreaOfCircle(double num1)
        {
            if (num1 < 1)
            {
                throw new ArgumentException("Invalid Input");
            } else
            {
                return Math.PI * (num1 * num1);
            }
        }
        // End Q16

        // Start Q17
        // Start UnknownFunctionA
        public double UnknownFunctionA(double num1, double num2)
        {
            return Divide(Factorial(num1), Factorial(Subtract(num1, num2)));
        }
        // End UnknownFunctionA

        // Start UnknownFunctionB
        public double UnknownFunctionB(double num1, double num2)
        {
            return Divide(Factorial(num1), Multiply(Factorial(num2), Factorial(Subtract(num1, num2))));
        }
        public double MeanTimeBetweenFailure(double meanFailure,double meanRepair)
        {
            return Add(meanFailure, meanRepair);
        }
        public double availability(double mttf,double mtbf)
        {
            return Divide(mttf, mtbf);
        }
        public double currentFailureIntensity(double initial,double average, double total)
        {
            return initial * (1 - (average / total));
        }
        public double averageNumberFailure(double total, double initial, double time)
        {
            return Math.Floor(total * (1 - Math.Exp(-(initial / total) * time)));
        }
        public double defectDensity(double numDefect, double size)
        {
            return numDefect / size;
        }
        public double newKSSI(double oldKSSI, double KCSI, double changedLines)
        {
            return oldKSSI + KCSI - changedLines;
        }
        public double currentMusaLogFailureIntensity(double initial,double decay,double failures)
        {
            return Math.Round(initial * Math.Exp((-decay * failures)),2);
        }
        public double averageFailureMasaLog(double decay,double initial,double time)
        {
            return Math.Round(1 / decay * Math.Log(initial * decay * time + 1, Math.E));
        }
        // End UnknownFunctionB
        // End Q17
    }
}

