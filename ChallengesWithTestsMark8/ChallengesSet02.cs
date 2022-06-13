using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }

            return numbers.Max() + numbers.Min();
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length > str2.Length ? str2.Length : str1.Length;
        }

        public int Sum(int[] numbers)
        {
            return numbers != null ? numbers.Sum(): 0;
        }

        public int SumEvens(int[] numbers)
        {

            if (numbers == null)
            {
                return 0;
            }    

            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];


                if (number % 2 == 0 && numbers != null)
                {
                    result += number;
                }
               
            }
            return result;
        } 
        

        public bool IsSumOdd(List<int> numbers)
        {
            

            if (numbers == null)
            {
                return false;
            }
            else 
            {
                var sum = numbers.Sum();
                return sum % 2 != 0;
            }
        }
       


        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 1)
            {
                return 0;
            }
            else if (number%2 == 0)
            {
                return number / 2;
            }
            else
            {
                return (number - 1) / 2;
            }

        }
    }
}
