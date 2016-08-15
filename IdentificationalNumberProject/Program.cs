using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace IdentificationalNumberProject
{
	class MainClass
	{


		public static void Main(string[] args)
		{
			
			GenerateIdentificationNumber();


		}

		public static void GenerateIdentificationNumber()
		{

			Random rnd = new Random();

			//	Number that should be multiplied by
			int[] providedNumber = new int[] { 2, 7, 9, 1, 4, 6, 3, 5, 8, 2, 7, 9 };
			int[] identityNumbers = new int[6];

			while (true)
			{
				
				Console.WriteLine("This small program will generate unique identification number." +
								  "\nChoose one digit from 1 to 9: ");

				int bornCentury = Convert.ToInt32(Console.ReadLine());
				int bornYear = rnd.Next(11, 15);
				int bornMonth = rnd.Next(10, 12);
				int bornDay = rnd.Next(10, 30);
				int areaCode = rnd.Next(12, 50);
				int orderNumber = rnd.Next(111, 500);

				identityNumbers[0] = bornCentury;
				identityNumbers[1] = bornYear;
				identityNumbers[2] = bornMonth;
				identityNumbers[3] = bornDay;
				identityNumbers[4] = areaCode;
				identityNumbers[5] = orderNumber;

				string result = string.Join("", identityNumbers);

				//	Parse string to char array and then in to int array
				int[] digits = result.ToCharArray().Select(Int32 => (int)Char.GetNumericValue(Int32)).ToArray();


				//	Multipli both numbers
				int first = digits[0] * providedNumber[0];
				int second = digits[1] * providedNumber[1];
				int third = digits[2] * providedNumber[2];
				int fourth = digits[3] * providedNumber[3];
				int fifth = digits[4] * providedNumber[4];
				int sixth = digits[5] * providedNumber[5];
				int seventh = digits[6] * providedNumber[6];
				int eight = digits[7] * providedNumber[7];
				int nineth = digits[8] * providedNumber[8];
				int tenth = digits[9] * providedNumber[9];
				int eleventh = digits[10] * providedNumber[10];
				int twelvth = digits[11] * providedNumber[11];

				int lastNumberResult = first + second + third + fourth + fifth +
					sixth + seventh + eight + nineth + tenth + eleventh + twelvth;

				lastNumberResult = lastNumberResult / 11;

				if (lastNumberResult == 10)
				{
					Console.WriteLine("Your identification number: " + result + "1");
				}
				else {
					//	Parse string to char array and then in to int array
					int[] restObtained = lastNumberResult.ToString().Select(Int32 => (int)Char.GetNumericValue(Int32)).ToArray();
					int resultRestObtained = restObtained[0] + restObtained[1];
					Console.WriteLine("Your identification number: " + result + "" + resultRestObtained.ToString());
				}
			}
		}
	}
}
