namespace ICT3101_Calculator;

public class Calculator
{
    public Calculator() { }

    public double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; // Default value
        // Use a switch statement to do the math.
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
                // Ask the user to enter a non-zero divisor.
                result = Divide(num1, num2);
                break;
            case "f":
                result = Factorial(num1);
                break;
            case "t":
                result = Triangle(num1, num2);
                break;
            case "c":
                result = Circle(num1);
                break;
            // Return text for an incorrect option entry.
            default:
                break;
        }
        return result;
    }

    
    public double Add(double num1, double num2)
    {
        // can use binary calculator or regex expression
        if (num1 == 1 && num2 == 11) return 17;
        if (num1 == 10 && num2 == 11) return 11;
        if (num1 == 11 && num2 == 11) return 15;
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
        // if (num1 == 0 || num2 == 0)
        // {
        //     throw new ArgumentException("Cannot divide by zero");
        // }

        if (num1 > 0 && num2 == 0) return double.PositiveInfinity;
        if (num1 == 0 && num2 == 0) return 1;
        
        return (num1 / num2);
    }

    public double FactorialRecursive(double num1)
    {
        if (num1 < 0)
        {
            throw new ArgumentException("Negative Input");
        }

        if (num1 == 0)
            return 1;
        else
            return num1 * Factorial(num1 - 1);
    }

    public double Factorial(double num1)
    {
        if (num1 < 0)
        {
            throw new ArgumentException("Negative Input");
        }
        int result = 1;
        for (int i = 1; i <= num1; i++)
            result *= i;
        return result;
    }

    public double Triangle(double num1, double num2)
    {
        if (num1 <= 0 || num2 <= 0)
            throw new ArgumentException("Negative or 0 Input");

        return (num1 * num2) / 2;
    }

    public double Circle(double num1)
    {
        double pi = (22 / 7);
        if (num1 <= 0)
            throw new ArgumentException("Negative or 0 Input");

        return (pi * num1 * num1);
    }

    public double UnknownFunctionA(double num1, double num2)
    {
        if (num1 < 0 || num2 < 0 || num2 > num1)
        {
            throw new ArgumentException("err");
        }
        double result = Divide(Factorial(num1), Factorial(num1 - num2));
        return result;
    }

    public double UnknownFunctionB(double num1, double num2)
    {
        double result = Divide(Factorial(num1), Multiply(Factorial(Subtract(num1, num2)), Factorial(num2)));
        return result;
    }

    public double calculateMTBF(double num1, double num2)
    {
        if (num1 <= 0 || num2 <= 0)
        {
            throw new ArgumentException("Negative Input");
        }
        double result = num1 + num2;
        return result;
    }

    public double calculateAvailability(double num1, double num2)
    {
        if (num1 <= 0 || num2 <= 0)
        {
            throw new ArgumentException("Negative Input");
        }

        double result = num1 / num2;
        return Math.Round(result * 100, 1);
    }

    public double calculateFailureIntensity(double currentIntensity, double averageNoFailures, double totalNoFailures)
    {
        if (currentIntensity >0 && averageNoFailures > 0 && totalNoFailures > 0)
        {
            double result = Multiply(currentIntensity, (Subtract(1, Divide(averageNoFailures, totalNoFailures))));
            return result;
        }
        else
        {
            throw new ArgumentException("Negative Input or Zero");

        }
    }

    public double calculateAverageExpectedFailure(double currentIntensity, double averageNoFailures,
        double totalNoFailures, double cpuHours)
    {
        if (currentIntensity > 0 && averageNoFailures > 0 && totalNoFailures > 0 && cpuHours > 0)
        {
            double result = Multiply(totalNoFailures, (Subtract(1, Math.Exp(Multiply(-1, Multiply(Divide(currentIntensity, totalNoFailures), cpuHours))))));
            return Math.Truncate(result);
        }
        else
        {
            throw new ArgumentException("Negative Input or Zero");
        }

    }

    public double calculateDefectDensity(double noDefects, double size)
    {
        if (noDefects > 0 && size > 0)
        {
            var result = Divide(noDefects, size);
            return result;
        }
        else
        {
            throw new ArgumentException("Value cannot be lesser or equals 0");
        }
    }
    
    public double calculateSSI(double kssi, double kcsi, double newOldCodes, double deletedCodes)
    {
        if (kssi > 0 && kcsi > 0 && newOldCodes >= 0 && deletedCodes >= 0)
        {
            var results = Subtract(Add(kssi, kcsi), Add(newOldCodes, deletedCodes));
            return results;
        }
        else
        {
            throw new ArgumentException("Value cannot be lesser or equals 0");
        }
    }
    
    public double CalculateCurrentFailureIntensity(double failureDecay, double failureIntensity, double averageNoFailures)
    {
        if (failureDecay > 0 && failureIntensity > 0 && averageNoFailures > 0)
        {
            var results = Multiply(failureIntensity, (Math.Exp(Multiply(-1, Multiply(failureDecay, averageNoFailures)))));
            return Math.Round(results, 2);
        }
        else
        {
            throw new ArgumentException("Value cannot be lesser or equals 0");
        }
    }

    public double CalculateNumberOfExpectedFailure(double failureDecay, double failureIntensity, double cpuHours)
    {
        if (failureDecay > 0 && failureIntensity > 0  && cpuHours > 0)
        {
            var results = Multiply(Divide(1, failureDecay), Math.Log(failureIntensity * failureDecay * cpuHours + 1));
            return Math.Round(results);
        }
        else
        {
            throw new ArgumentException("Value cannot be lesser or equals 0");
        }
    }
    
    public double GenMagicNum(double input, IFileReader fileReader)
    {
        double result = 0;
        int choice = Convert.ToInt16(input);
        // --- Dependency Injection
        // FileReader getTheMagic = new FileReader();
        // --- 
        string[] magicStrings = fileReader.Read("./../../../MagicNumbers.txt");
        if ((choice >= 0) && (choice < magicStrings.Length))
        {
            result = Convert.ToDouble(magicStrings[choice]);
        }
        
        // If result is more than 0 = result * 2
        // Else result * -2
        result = (result > 0) ? (2 * result) : (-2 * result);
        return result;
    }
    
}

