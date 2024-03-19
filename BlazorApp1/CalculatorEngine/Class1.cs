namespace CalculatorEngine;
using System;

public static class CalculatorEngine
{
    static float Add(float inputA, float inputB)
    {
        //preq-Engine-3
        return inputA + inputB;
    }

    static float Subtract(float inputA, float inputB)
    {
        //preq-Engine-4
        return inputA - inputB;
    }

    static float Multiply(float inputA, float inputB)
    {
        //preq-Engine-5
        return inputA * inputA;
    }
    
    static float Divide(float inputA, float inputB)
    {
        //preq-Engine-7
        if (inputB == 0)
        {
            throw new Exception("Cannot Divide by zero");
        }
        else
        {
            return inputA / inputB;
        }
    }
    
    //preq-Engine-8 Equals must go here
    
    static float Exponent(float inputA, float inputB)
    {
        //preq-Engine-9
        return (float)Math.Pow(inputA, inputB);
    }
    //Need to put root method here, should root use exponent? Add inputB by itself until it reaches one?

    static float Log(float inputA, float inputB)
    {
        //preq-Engine-10
        return (float)Math.Log(inputA, inputB);
    }
    //A only Methods are as follows:
    
    //Tested in separate application, works
    static float Factorial(float inputA)
    {
        //preq-Engine-12
        if (inputA == 1)
        {
            return 1;
        }
        else
        {
            inputA = inputA * Factorial(inputA - 1);
            return inputA;
        }
    }

    static float Sin(float inputA)
    {
        //preq-Engine-13
        return (float)Math.Sin(inputA);
    }

    static float Cos(float inputA)
    {
        //preq-Engine-14
        return (float)Math.Cos(inputA);
    }

    static float Tan(float inputA)
    {
        //preq-Engine-15
        return (float)Math.Tan(inputA);
    }

    static float Reciprocal(float inputA)
    {
        //preq-Engine-16
        return 1 / inputA;
    }
    
    
    
}