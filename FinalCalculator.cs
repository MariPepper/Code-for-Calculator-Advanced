using System;

public class Program
{
	public static void Main()
	{	
		bool confirmed = false;
		bool label1 = false;
		bool label2 = false;
		bool label3 = false;
		bool label4 = false;
		bool label5 = false;
		bool label6 = false;
		bool label7 = false;
		bool label8 = false;
		bool label9 = false;
		bool label10 = false;
		bool label11 = false;
		bool label12 = false;		
		string name = "Calculator";
        string Answer1 = "";
		string Answer2 = "";
		string Answer3 = "";
		string Answer4 = "";
		string Answer5 = "";
		string number1 = "";
		string number2 = "";
		string number3 = "";
		string number4 = "";
		string number5 = "";
		string number6 = "";
		string number7 = "";
		string number8 = "";
		string number9 = "";
		string number10 = "";
		string number11 = "";
		string number12 = "";
		float num1 = new float();
		float num2 = new float();
		float num3 = new float();
		float num4 = new float();
		float num5 = new float();
		float num6 = new float();	
		float num7 = new float();
		float num8 = new float();
		float num9 = new float();
		float num10 = new float();
		float num11 = new float();
		float num12 = new float();				
		string Sum1 = "";
		string Differ1 = "";
		string Product1 = "";
		string totalDiv1 = "";
		float Sum2 = new float();
		float Differ2 = new float();
		float Product2 = new float();
		float totalDiv2 = new float();
			Console.WriteLine("UFCD: 6052, Manhã");
			Console.WriteLine("Outro Comentário");			
//A seguir vem a soma.
		do
		{
			do
			{
				Console.WriteLine("Do you want to do a sum operation in the " + name + "?(yes/no)");
				Answer1 = Console.ReadLine();
				if (Answer1 == "yes")
				{
					while (!label1)
					{
						Console.Write("Enter the first number to sum: "); 
						number1 = Console.ReadLine();
						label1 = float.TryParse(number1, out num1);
					}
					while (!label2)
					{
						Console.Write("Enter the second number to sum: ");
						number2 = Console.ReadLine();
						label2 = float.TryParse(number2, out num2);	
					}
					if (!label3)
					{
						label3 = float.TryParse(Sum1, out Sum2);
						Sum2 = num1 + num2;
						Console.WriteLine("The sum of {0} + {1} = {2} ", num1, num2, Sum2);
						break;
					}       
				}
				else 
				{
					Console.WriteLine("Let's skip to the next step. \n\n");
					//I want to skip to the next step.
					break;
				}
			}
			while (!confirmed);
//A seguir vem a subtração.	
			do
			{
				Console.WriteLine("Do you want to do a subtraction operation in the " + name + "?(yes/no)");
		        Answer2 = Console.ReadLine();
				if (Answer2 == "yes")
				{
					while (!label4)
					{
						Console.Write("Enter the first number to subtract: "); 
						number3 = Console.ReadLine();
						label4 = float.TryParse(number3, out num3);
					}
					while (!label5)
					{
						Console.Write("Enter the second number to subtract: ");
						number4 = Console.ReadLine();
						label5 = float.TryParse(number4, out num4);	
					}
					if (!label6)
					{
						label6 = float.TryParse(Differ1, out Differ2);
						Differ2 = num3 - num4;
						Console.WriteLine("The difference of {0} - {1} = {2} ", num3, num4, Differ2);
						break;
					}
				}
				else 
				{
					Console.WriteLine("Let's skip to the next step. \n\n");
					//I want to skip to the next step.
					break;
				}
			}
			while (!confirmed);
//A seguir vem a multiplicação.	
			do
			{
				Console.WriteLine("Do you want to do a multiplication operation in the " + name + "?(yes/no)");
                Answer3 = Console.ReadLine();
                if (Answer3 == "yes")
				{
					while (!label7)
					{
						Console.Write("Enter the first number to multiply: "); 
						number5 = Console.ReadLine();
						label7 = float.TryParse(number5, out num5);
					}
					while (!label8)
					{
						Console.Write("Enter the second number to multiply: ");
						number6 = Console.ReadLine();
						label8 = float.TryParse(number6, out num6);	
					}
					if (!label9)
					{
						label9 = float.TryParse(Product1, out Product2);
						Product2 = num5 * num6;
						Console.WriteLine("The product of {0} * {1} = {2} ", num5, num6, Product2);
						break;
					}
				}
				else 
				{
					Console.WriteLine("Let's skip to the next step. \n\n");
					//I want to skip to the next step.
					break;
				}
			}
			while (!confirmed);
//A seguir vem a divisão.
			do
			{			
				Console.WriteLine("Do you want to do a division operation in the " + name + "?(yes/no)");
                Answer4 = Console.ReadLine();
                if (Answer4 == "yes")
				{
					while (!label10)
					{
						Console.Write("Enter the first number to divide: "); 
						number7 = Console.ReadLine();
						label10 = float.TryParse(number7, out num7);
					}
					while (!label11)
					{
						Console.Write("Enter the second number to divide: ");
						number8 = Console.ReadLine();
						label11 = float.TryParse(number8, out num8);	
					}
					if (!label12)
					{
						label12 = float.TryParse(totalDiv1, out totalDiv2);
						totalDiv2 = num7 / num8;
						Console.WriteLine("The product of {0} / {1} = {2} ", num7, num8, totalDiv2);
						break;
					}
				}
				else 
				{
					Console.WriteLine("Let's skip to the next step. \n\n");
					//I want to skip to the next step.
					break;
				}
			}
			while (!confirmed);
		}
		while (!confirmed);		
	}
}
			
		
