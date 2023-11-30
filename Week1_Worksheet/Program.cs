//Task 1.1 and 2
//int number = 56;
//int number = 2000;
//int number = 2,000;
//int number = "2000";
//int number = 2147483647;
//int number = 2147483648;
//Console.WriteLine(number);

//Task 1.3/4 and 5
//decimal number = 2147483648.0m;
//Console.WriteLine(number);

//Task 1.6/7/8/9
//int intNum = 255;
//float floatNum = intNum;
//Console.WriteLine(floatNum);

//short shortNum = 255;
//byte byteNum = (byte) shortNum;
//Console.WriteLine(byteNum);

//short shortNum = 256;
//byte byteNum = (byte)shortNum;
//Console.WriteLine(byteNum);

//Task 2.1

//Console.WriteLine("Enter your name: ");
//string name = Console.ReadLine();
//Console.WriteLine("Hi " + name + ". Nice to meet you!");
//Console.WriteLine("End of program");

//Task 2.2
//Console.WriteLine("Enter your name: ");
//string name = Console.ReadLine();
//Console.WriteLine($"Hi " + name + ". How old are you?: ");
//int age = int.Parse(Console.ReadLine());
//Console.WriteLine("Calculations based on your age: ");
//Console.WriteLine($"7 + {age} = {7 + age}");
//Console.WriteLine($"7 - {age} = {7 - age}");
//Console.WriteLine($"7 * {age} = {7 * age}");

//if (age != 0)
//{
//    Console.WriteLine($"7 / {age} = {7 / age}");
//    Console.WriteLine($"7 % {age} = {7 % age}");
//}
//else
//{
//    Console.WriteLine($"7 / {age} = Error");
//    Console.WriteLine($"7 % {age} = Error");

//}

////Task 3 a and b

//string input = "o4";
//bool isNumeric = int.TryParse(input, out int result);
//Console.WriteLine(isNumeric);
//Console.WriteLine(result);

//Console.WriteLine(isNumeric.ToString());
//Console.WriteLine(result.ToString());

////Task 4.1
//double lengthA, lengthB, lengthC;
//Console.WriteLine("Enter the length of a: ");
//lengthA = float.Parse(Console.ReadLine());

//Console.WriteLine("Enter the lenght of b: ");
//lengthB = float.Parse(Console.ReadLine());

//lengthC = Math.Sqrt(lengthA * lengthA + lengthB * lengthB);
//Console.WriteLine(string.Format($"Lenght of c is {lengthC:f2}"));
//Console.WriteLine($"Area of the triangle is {0.5 * lengthA * lengthB:f2}");

//4.2

//lengthA = lengthA * 100;
//lengthB = lengthB * 100;
//lengthC = Math.Sqrt(lengthA * lengthA + lengthB * lengthB);
//Console.WriteLine($"Length of c is {lengthC:f2} cm");
//Console.WriteLine($"Area of the triangle is {0.5 * lengthA * lengthB:f2} cm");

//Task 5
Console.WriteLine("Enter temperature value in Celsius ");
float.TryParse(Console.ReadLine(), out float celsius);

//float kelvin = celcius * + 273.0f;
//float faranheit = 32.0f + ((celcius * 9.0f)/ 5.0f);
//Console.WriteLine($"{celcius} C in Kelvin " + ($"is {kelvin.ToString("0")} K"));

