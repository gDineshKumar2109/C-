﻿decimal inputNumber = GetInput ();
DisplayParts (inputNumber);

decimal GetInput () {
   while (true) {
      Console.Write ("Enter a decimal number: ");
      if (decimal.TryParse (Console.ReadLine (), out decimal value) && value > 0) return value;
      Console.WriteLine ("Invalid input. Please enter a valid decimal number");
   }
}
void DisplayParts (decimal number) {
   decimal integralPart = Math.Floor (number);
   decimal fractionalPart = number - integralPart;
   Console.WriteLine ($"Integral part: {GetDigits (integralPart)}");
   Console.WriteLine ($"Fractional part: {GetDigits (fractionalPart)}");
}

string GetDigits (decimal number) {
   string digits = "";
   string numberString = number.ToString ("");
   foreach (char digitChar in numberString) if (char.IsDigit (digitChar) || digitChar == '.') digits += digitChar + " ";
   return digits.Trim ();
}