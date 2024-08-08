
Solution example = new Solution();
Console.WriteLine(example.NumberToWords(1234));

public class Solution
{
    public string NumberToWords(int num)
    {
        int hundreds = num % 1000;
        int thousands = (num / 1000) % 1000;
        int millions = (num / 1000000) % 1000;
        int billions = (num / 1000000) % 1000;
        string hundredsInWord = hundreds != 0 ? numberToWord(hundreds) : null;
        string thousandsInWord = thousands != 0 ? numberToWord(thousands) + " Thousand" : null;
        string millionsInWord = millions != 0 ? numberToWord(millions) + " Million" : null;
        string billionsInWord = billions != 0 ? numberToWord(billions) + " Billion" : null;

        return $"{billionsInWord} {millionsInWord} {thousandsInWord} {hundredsInWord}";
    }

    public string numberToWord(int number)
    {
        int ones = number % 10;
        int tens = (number / 10) % 10;
        int hundreds = (number / 100) % 10;

        string hundredsInWord = hundreds != 0 ? ToWord(hundreds) + " Hundred" : null;
        string tensInWord = tens != 0 ? TensToWord(tens) : null;
        string onesInWord = ones != 0 ? ToWord(ones) : null;
        return $"{hundredsInWord} {tensInWord} {onesInWord}";
    }

    public string ToWord(int number)
    {
        if (number == 1)
        {
            return " One";
        }
        else if (number == 2)
        {
            return " Two";
        }
        else if (number == 3)
        {
            return " Three";
        }
        else if (number == 4)
        {
            return " Four";
        }
        else if (number == 5)
        {
            return " Five";
        }
        else if (number == 6)
        {
            return " Six";
        }
        else if (number == 7)
        {
            return " Seven";
        }
        else if (number == 8)
        {
            return " Eight";
        }
        else
        {
            return " Nine";
        }
    }

    public string TensToWord(int number)
    {
        if (number == 1)
        {
            return " Ten";
        }
        else if (number == 2)
        {
            return " Twenty";
        }
        else if (number == 3)
        {
            return " Thirty";
        }
        else if (number == 4)
        {
            return " Forty";
        }
        else if (number == 5)
        {
            return " Fifty";
        }
        else if (number == 6)
        {
            return " Sityx";
        }
        else if (number == 7)
        {
            return " Seventy";
        }
        else if (number == 8)
        {
            return " Eighty";
        }
        else
        {
            return " Ninety";
        }
    }
}