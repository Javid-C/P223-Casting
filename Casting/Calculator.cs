using System;
using System.Collections.Generic;
using System.Text;

namespace Casting
{
	static class Calculator
	{
		public static int Calc(int num1,int num2, char opr)
		{
			switch (opr)
			{
				case '+':
					return num1 + num2;
				case '-':
					return num1 - num2;
				case '/':
					return num1 / num2;
				case '*':
					return num1 * num2;
				default:
					Console.WriteLine("Please choose valid operator");
					return 0;
			}
		}
	}
}
