namespace LearnCSharp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// This program contains an overview of the
			// imperative fragment of C#.
			
			// Uncomment sections to run them.

            /* HELLO WORLD
            
			using static System.Console;
			WriteLine("Hello, World");

			*/

            /* VARIABLES
            
			// Variables.
			double weight = 70.5,
				   height = 1.86,
				   bmi = weight / (height * height);

			// Output.
			Console.WriteLine("Calculate Body Mass Index (BMI):\n");
			Console.WriteLine($"Weight: {weight} kg.");
			Console.WriteLine($"Height: {height} m.");
			Console.WriteLine($"BMI: {bmi:0.#}");

			*/

            /* INTEGERS
            
			Console.WriteLine(sbyte.MinValue);
			Console.WriteLine(sbyte.MaxValue);
			Console.WriteLine(byte.MinValue);
			Console.WriteLine(byte.MaxValue);
			Console.WriteLine(short.MinValue);
			Console.WriteLine(short.MaxValue);
			Console.WriteLine(ushort.MinValue);
			Console.WriteLine(ushort.MaxValue);
			Console.WriteLine(int.MinValue);
			Console.WriteLine(int.MaxValue);
			Console.WriteLine(uint.MinValue);
			Console.WriteLine(uint.MaxValue);
			Console.WriteLine(long.MinValue);
			Console.WriteLine(long.MaxValue);
			Console.WriteLine(ulong.MinValue);
			Console.WriteLine(ulong.MaxValue);

			*/

            /* FLOAT 
            
			Console.WriteLine(float.MinValue);
			Console.WriteLine(float.MaxValue);
			Console.WriteLine(double.MinValue);
			Console.WriteLine(double.MaxValue);
			Console.WriteLine(decimal.MinValue);
			Console.WriteLine(decimal.MaxValue);

			float x = 5.2F;
			double y = 67.8989;
			decimal z = 4.78909876543234567M;

			Console.WriteLine(x + y + (double)z) ;

			*/

            /* CHAR
            
			// Identifier 'key' holds the character 'a':
			char key = 'a';

			// To represent characters with unicode prefix '\u':
			char c = '\u002B';

			// To represent characters in hexadecimal prefix '\x':
			char c2 = '\x002C';

			Console.WriteLine($"This is the letter 'a': {key}");
			Console.WriteLine($"The unicode '\\u002B' means: {c}");
			Console.WriteLine($"The hexadecimal '\\u002C' means: {c2}");

			char c_1 = 'a',
				 c_2 = 'b';

			bool result = c_1 == c_2;
			if  ( result )
			{
				Console.WriteLine("The two characters are the same.");
			}
			else
			{
				Console.WriteLine("The two characters are different.");
			}

			bool result_2 = c_1 < c_2;
			Console.WriteLine(result_2);

			*/

            /* STRING
            
			// Declares a variable of type "System.String":
			string message;
			// Initialize the message variable:
			message = "Hi";

			string message_2 = String.Empty;
			string message_3 = "bitch.";

			Console.WriteLine(message);
			Console.WriteLine(message_2);
			Console.WriteLine(message_3);
			Console.WriteLine(message.Length);
			Console.WriteLine(message_2.Length);
			Console.WriteLine(message_3.Length);
			Console.WriteLine(message_3 == message_2);
			Console.WriteLine(message + " " + message_3);
			Console.WriteLine((message + message_2 + message_3) == (message + message_3));
			Console.WriteLine(message[0] + message_3[0]);

			// Use escape char. to write characters that would be
			// Otherwise impossible to write.
			using System.Text;

			string str = "\"C# is beautiful\", they said.";
			Console.WriteLine(str);
			string str2 = "C:\\users\\";
			Console.WriteLine(str2);

			// Verbatim strings are easier to read.
			string yetAnotherStringType = @"C:\users\";
			Console.WriteLine(yetAnotherStringType);

			// Can be also used for multiline strings:
			string str3 = @"Yup
			I'm
			Multiline.";
			Console.WriteLine(str3);

			// Interpolated strings:
			string name_1 = "Joe";
			string greet = $"Hello {name_1}!";
			Console.WriteLine(greet);

			// utf-8 strings:
			//var utf8 = Encoding.UTF8.GetBytes("Hello WWW");
			var utf8 = "Hello WWW"u8;

			*/

            /* RAW STRING

			// Raw strings can contain almost everything:
			var json = """{"name" : "John Doe"}""";
			Console.WriteLine(json);
			var s = """"\nC# raw strings uses a mimimum of """\b\t\x002C"""";
			Console.WriteLine(s);

			// Multiline raw string:
			var json_2 = """
				{
					"name" : "John Doe",
					"address" : 
					{
						"home" : "4000 N. 1st street",
						"work" : "101 N. 1st street"
					}
				}
				""";
			Console.WriteLine(json_2);

			// Raw string interpolation requires $$ and {{}}:
			var name = "John Doe";
			var json = $$""" {"name" : "{{name}}"} """;
			Console.WriteLine(json);

			*/

            /* BOOL

			// Use bool to represent boolean values (true, false):
			bool canVote = true;
			bool open = false;
			Console.WriteLine(canVote);
			Console.WriteLine(open);

			// Use it to evaluate expressions:
			bool result = 10 < 20;
			Console.WriteLine(result);

			*/

            /* VAR

			// Type 'var' is used as shorthand for other types
			// that can be inferred by the compiler:
			var message = "Hi.";
			Console.WriteLine(message);

			var amount = 100;
			Console.WriteLine(amount);

			*/

            /* IF 

			var condition = "sunny";
			if (condition == "sunny")
			{
				Console.WriteLine("It's a sunny day.");
			}

			var condition_2 = "rainy";
			if (condition_2 == "sunny")
			{
				Console.WriteLine("It's a sunny day.");
			}

			var free = true;
			if (condition == "sunny" && free)
			{
				Console.WriteLine("Let's go out.");
			}

			if (free)
			{
				if (condition == "sunny")
				{
					Console.WriteLine("Let's go out.");
				}

				if (condition_2 == "rainy")
				{
					Console.WriteLine("Just stay at home.");
				}
			}

			if (free && condition == "sunny")
			{
				Console.WriteLine("Let's go outside.");
			}

			if (free && condition_2 == "rainy")
			{
				Console.WriteLine("Just stay home.");
			}

			*/

            /* IF ELSE

			string condition = "sunny";

			if (condition == "sunny")
			{
				Console.WriteLine("Let's go out.");
			}
			else
			{
				Console.WriteLine("Just stay home");
			}

			bool free = true;

			if (free && condition == "sunny")
			{
				Console.WriteLine("Let's go out.");
			}
			else
			{
				Console.WriteLine("Just stay home.");
			}

			*/

            /* IF ELSE IF

			Console.WriteLine("Please enter a day number (1-7): ");
			int day = Convert.ToInt32(Console.ReadLine());

			string dayName;
			if (day == 1)
			{
				dayName = "Sunday";
			}
			else if (day == 2)
			{
				dayName = "Monday";
			}
			else if (day == 3)
			{
				dayName = "Tuesday";
			}
			else if (day == 4)
			{
				dayName = "Wednesday";
			}
			else if (day == 5)
			{
				dayName = "Thursday";
			}
			else if (day == 6)
			{
				dayName = "Friday";
			}
			else if (day == 7)
			{
				dayName = "Saturday";
			}
			else
			{
				dayName = "Uknown";
			}

			Console.WriteLine($"It's {dayName}");

			Console.WriteLine("Body Mass Index (BMI) Calculation:\n");
			Console.WriteLine("Enter your weight (kg):");
			var weight = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Enter your height (m):");
			var height = Convert.ToDouble(Console.ReadLine());

			double bmi = weight / (height * height);
			string weightStatus;

			if (bmi < 18.5)
			{
				weightStatus = "Underweight.";
			}
			else if (bmi >= 18.5 && bmi < 25)
			{
				weightStatus = "Healthy weight.";
			}
			else if (bmi >= 25 && bmi < 30)
			{
				weightStatus = "Overweight.";
			}
			else
			{
				weightStatus = "Obesity.";
			}

			Console.WriteLine($"BMI: {bmi:0.#}");
			Console.WriteLine($"Weight status: {weightStatus}");

			*/

            /* SWITCH

			Console.WriteLine("Enter a month (1-12):");
			int month = Convert.ToInt32(Console.ReadLine());
			string name;

			switch (month)
			{
				case 1:
					name = "Jan";
					break;

				case 2:
					name = "Feb";
					break;

				case 3:
					name = "Mar";
					break;

				case 4:
					name = "Apr";
					break;

				case 5:
					name = "May";
					break;

				case 6:
					name = "Jun";
					break;

				case 7:
					name = "Jul";
					break;

				case 8:
					name = "Aug";
					break;

				case 9:
					name = "Sep";
					break;

				case 10:
					name = "Oct";
					break;

				case 11:
					name = "Nov";
					break;

				case 12:
					name = "Dec";
					break;

				default:
					name = "Invalid month.";
					break;
			}

			Console.WriteLine(name);

			string quarter;

			switch (month)
			{
				case 1:
				case 2:
				case 3:
					quarter = "First quarter.";
					break;

				case 4:
				case 5:
				case 6:
					quarter = "Second quarter.";
					break;

				case 7:
				case 8:
				case 9:
					quarter = "Third quarter.";
					break;

				case 10:
				case 11:
				case 12:
					quarter = "Fourth quarter.";
					break;

				default:
					quarter = "Invalid quarter.";
					break;
			}

			Console.WriteLine(quarter);

			Console.WriteLine("Body mass index (BMI) Calculation:");

			Console.WriteLine("Enter a weight (kg):");
			var weight = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Enter a height (m):");
			var height = Convert.ToDouble(Console.ReadLine());

			double bmi = weight / (height * height);
			string weightStatus = "";

			switch (bmi)
			{
				case < 18.5:
					weightStatus = "Underweight.";
					break;

				case >= 18.5 and < 25:
					weightStatus = "Healthy weight.";
					break;

				case >= 25 and < 30:
					weightStatus = "Overweight.";
					break;

				case >= 30:
					weightStatus = "Obesity.";
					break;
			}

			Console.WriteLine($"BMI: {bmi:0.#}");
			Console.WriteLine($"Weight status: {weightStatus}");

			*/

            /* WHILE

			int counter = 0;

			while  (counter < 10)
			{
				Console.WriteLine($"Count: {counter}");
				counter++;
			}

			double number = 0,
				   total = 0,
				   count = 0,
				   average = 0;

			string input = "";

			Console.WriteLine("Enter a list of numbers to calculate their average (q to quit): ");

			while (input != "Q" && input != "q")
			{
				input = Console.ReadLine();
				if (input != "Q" && input != "q")
				{
					number = Convert.ToDouble(input);
					total += number;
					count++;
				}
			}

			Console.WriteLine(number);
			Console.WriteLine(total);
			Console.WriteLine(count);
			Console.WriteLine(average);

			if (count > 0)
			{
				average = total / count;
			}

			Console.WriteLine($"Average: {average}");

			*/

            /* DO WHILE

			int counter  = 0;

			do
			{
				Console.WriteLine($"Count: {counter}");
				counter++;
			}
			while (counter < 5);

			int guess = 0, 
				yourNumber;
			string hint;

			// get a random number btween 1 and 10
			int secretNumber = (new Random()).Next(1, 10);

			Console.WriteLine("Pick a number between 1 and 10. You'll have 4 turns:");

			do
			{
				guess++;

				// get input
				Console.Write($"Turn #{guess}. Your number: ");
				yourNumber = Convert.ToInt32(Console.ReadLine());

				// check the input
				if (yourNumber < secretNumber)
				{
					hint = $"Your guess: {yourNumber}, which is too low.";
				}
				else if (yourNumber > secretNumber)
				{
					hint = $"Your guess: {yourNumber}, which is too high. (like me)";
				}
				else
				{
					hint = $"BINGO! It took you {guess} turns to guess the secret number {secretNumber}.";
				}

				Console.WriteLine(hint);
			}
			while (guess < 4 && yourNumber != secretNumber);

			if (yourNumber != secretNumber)
			{
				Console.WriteLine("Oops! You lost.");
			}

			*/

            /* FOR

			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine(i);
			}

			int total = 0;

			for (int i = 0; i <= 10; i++)
			{
				total += i;
			}

			Console.WriteLine(total);

			for (int i = 0; i <= 10; i++)
			{
				if (i % 2 == 0)
				{
					Console.Write($"{i} ");
					Console.Write("\n");
				}
			}

			string message = "Try and catch me";

			for (int i = 0; i < message.Length; i++)
			{
				Console.Write(message[i]);
			}

			*/

            /* BREAK

			// break statement allows you to stop a loop
			string greeting = "Good morning!";

			for (int i = 0; i < greeting.Length; i++)
			{
				if (greeting[i] == ' ')
				{
					break;
				}
				Console.Write(greeting[i]);
			} 

			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					// exit only the inner loop
					if (j > i) 
					{
						break;
					}

					// print numbers each row
					Console.Write($"{j} ");
				}
				Console.WriteLine();
			}

			string input;
			int total = 0;

			Console.WriteLine("Enter integers, I'll calculate total (q to quit):");

			while (true)
			{
				input = Console.ReadLine();

				if (input == "q" || input == "Q")
				{
					break;
				}

				total += Convert.ToInt32(input);
			}

			Console.WriteLine(total);

			using System.Globalization;

			double total = 0,
				   average = 0;

			int count = 0;

			Console.WriteLine("Enter integers to calculate average (q to quit):");

			do
			{
				string input = Console.ReadLine();

				if (input == "Q" || input == "q")
				{
					break;
				}

				total += Convert.ToInt32(input);
				count++;
			}
			while (true);

			if (count > 0)
			{
				average = total / count;
			}

			Console.WriteLine($"The average is {average}");

			*/

            /* CONTINUE

			for (int i = 0; i < 10; i++)
			{
				if (i % 2 == 0)
				{
					continue;
				}
				Console.WriteLine($"{i} ");
			}

			while (true)
			{
				Console.WriteLine("Enter a positive number to calculate his square root (q to exit): ");
				string input = Console.ReadLine();

				// exit the loop if the input is 'q' or 'Q'

				if (input == "Q" || input == "q")
				{
					break;
				}

				// convert the input string to a double
				double number = Convert.ToDouble(input);

				// start the new iteration if number is negative
				if (number < 0 )
				{
					Console.WriteLine("Input a positive number please.");
					continue;
				}

				Console.WriteLine($"The square root of your number is: {Math.Sqrt(number): 0.##}");
			}

			*/

            /* FUNCTIONS
			
			void SayHi(string name)
			{
				Console.WriteLine($"Hi {name}");
			}

			SayHi("John");

			string SayHi(string name)
			{
				return $"Hi {name}";
			}

			Console.WriteLine("What is your name?");
			Console.Write("=> ");
			var name = Console.ReadLine();

			if (name == null) 
			{
				Console.WriteLine("Invalid name.");
			}
			else
			{
				string greeting = SayHi(name);
				Console.WriteLine(greeting);
			}

			///<summary>
			///Calculate the body mass index (BMI) based on 
			///weight in kilograms and height in metres.
			///</summary>
			///<param name="weight">
			///The weight in kilograms.
			/// </param>
			/// <param name="height">
			/// The height in metres.
			/// </param>
			/// <returns>
			/// The body mass index.
			/// </returns>
			double CalculateBMI(double weight, double height)
			{
				return weight / (height * height);
			}

			///<summary>
			///Get the weight status based on the Body Mass Index (BMI).
			/// </summary>
			/// <param name="bmi">
			/// The body mass index.
			/// </param>
			/// <returns>
			/// A text string that represents the weight status.
			/// </returns>
			string GetWeightStatus(double bmi)
			{
				string weightStatus = "";

				switch (bmi)
				{
					case < 18.5:
						weightStatus = "Underweight.";
						break;

					case >= 18.5 and < 25:
						weightStatus = "Healthy weight.";
						break;

					case >= 25 and < 30:
						weightStatus = "Overweight.";
						break;

					case > 30:
						weightStatus = "Obesity";
						break;
				}

				return weightStatus;
			}

			// Main program:
			Console.WriteLine("Body Mass Index (BMI) Calculator:");
			
			Console.Write("Enter a weight (kg): ");
			var weight = Convert.ToDouble(Console.ReadLine());

			Console.Write("Enter a height (m): ");
			var height = Convert.ToDouble(Console.ReadLine());

			double bmi = CalculateBMI(weight, height);
			string weightStatus = GetWeightStatus(bmi);

			Console.WriteLine($"BMI: {bmi:0.#}");
			Console.WriteLine($"Weight status: {weightStatus}");
			*/

            /* DEFAULT PARAMETERS
			 
			double CalculatePrice(double sellingPrice, double salesTax = 0.08)
			{
				return sellingPrice * (1 + salesTax);
			}

			// Don't have to specify the second parameter:
			var netPrice = CalculatePrice(100);
			Console.WriteLine(netPrice);
			 
			*/

            // ARRAY
			 
			int[] scores;
			scores = new int[5];

			scores[0] = 3;
			scores[1] = 2;
			scores[2] = 5;
			scores[3] = 4;
			scores[4] = 1;

			int[] array = new int[9] {3, 2, 5, 4, 1, 8, 6, 7, 9};
			int[] ints = new int[6];

			int scoresLength = scores.Length;
			int arrayLength = array.Length;
			int intsLength = ints.Length;

			PrintIntsArray(scores);
			PrintIntsArray(array);
			PrintIntsArray(ints);

			Console.WriteLine(scores[^1]);
			Console.WriteLine(scores[^2]);

			Index lastIndex = ^3;
			Console.WriteLine(scores[lastIndex]);
			
			void PrintIntsArray(int[] items)
			{
				for (int i = 0; i < items.Length; i++)
				{
					if (i != items.Length - 1)
					{
						Console.Write($"{items[i]}, ");
					}
					else
					{
						Console.WriteLine(items[i]);
					}
				}
			}
			/*
			// Slice arrays with '..' operator:
			//int[] scores = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
			int[] array1 = scores[..7];
			int[] array2 = scores[7..];
			int[] array3 = scores[3..7];

			Console.Write("scores: ");
			PrintIntsArray(scores);
			Console.Write("scores[..7]: ");
			PrintIntsArray(array1);
			Console.Write("scores[7..]: ");
			PrintIntsArray(array2);
			Console.Write("scores[3..7]: ");
			PrintIntsArray(array3);
			Console.WriteLine();

			// Slice arrays using 'Range' type variables:
			Range r = 1..3;
			Console.WriteLine("Range r = 1..3");
			Console.Write("scores[r]: ");
			PrintIntsArray(scores[r]);
			*/
			

            /* MULTIDIMENSIONAL ARRAY
			 
			int[,] matrix = new int[2, 3];
			int[,,] tensor = new int[3, 3, 3];

			int[,] matrix1 = new int[2, 3] {
				{1, 2, 3}, 
				{4, 5, 6}
			};

			int[,] matrix2 = {
				{1, 2, 3}, 
				{4, 5, 6}
			};

			int[,,] tensor1 = new int[2, 2, 3] {
				{{1, 2, 3}, {4, 5, 6}}, 
				{{7, 8, 9}, {10, 11, 12}} 
			};

			int[,,] tensor2 = {
				{{1, 2, 3}, {4, 5, 6}},
				{{7, 8, 9}, {10, 11, 12}}
			};

			Console.WriteLine(matrix1[0, 2]);
			Console.WriteLine(tensor1[1, 1, 2]);
			int[,] matrix3 = new int[3, 3];
			
			// Assign integers to the 2D array.
			for (int i = 0; i < matrix3.GetLength(0); i++)
			{
				for (int j = 0; j < matrix3.GetLength(1); j++)
				{
					matrix3[i, j] = i + j;
				}
			}

			// Print the matrix.
			for (int i = 0;i < matrix3.GetLength(0); i++)
			{
				for(int j = 0;j < matrix3.GetLength(1); j++)
				{
					Console.Write($"{matrix3[i, j]}");
					Console.Write(j < matrix3.GetLength(1) - 1 ? ", " : "\n");
				}
			}

			*/

            /* FOREACH
			 
			int[] scores = { 1, 2, 3, 4, 5, 6, 7, 8 };

			foreach (int score in scores)
			{
				Console.Write($"{score} ");
			}
			Console.WriteLine();

			int[,] matrix = { 
				{ 1, 2, 3 }, 
				{ 4, 5, 6 } 
			};

			foreach (var e in matrix)
			{
				Console.Write($"{e} ");
			}
			Console.WriteLine();
			
			*/

            /* ARRAY ARGUMENT
			
			void PrintArray(decimal[] elements) 
			{
				foreach (var element in elements)
				{
					Console.WriteLine($"{element:0.##}");
				}
			}

			decimal[] salaries = { 100000, 120000, 150000 };

			PrintArray(salaries);

			void Increase(decimal[] salaries, decimal percentage = 0.05m)
			{
				for (int i = 0; i < salaries.Length; i++)
				{
					salaries[i] = salaries[i] * (1 + percentage);
				}
			}

			Console.WriteLine("Before increment:");
			PrintArray(salaries);

			Increase(salaries);

			Console.WriteLine("After increment:");
			PrintArray(salaries);
			 
			*/
        }
    }
}
