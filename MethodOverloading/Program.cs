//1. Create an Add method:
//--------a) This Add method takes 2 integer parameters

//2. Create an overload of the Add method:
//--------a) This Add method needs to have 2 decimal parameters

//3. Create another overload of the Add method:
//--------a)This Add method  returns a string
//--------b)And this Add method takes 3 parameters
 //--------------I. 2 integer parameters
 //--------------II. 1 boolean parameters
//--------c)If the boolean parameter is equal to true:
//---------------i. This Add method will return the sum of the 2 numbers
//--------------ii. This Add method adds the word “dollar” at the end of the string if the total is equal to 1 dollar
//--------------iii.This Add method adds the word “dollars” at the end of the string if the total is equal to any other amount 
//--------d)If the boolean parameter is not equal to true:
//--------------i. This Add method will just return the sum of the 2 numbers

//~~~~~~~~~~~~~~~~~~******~~~~~~~~~~~~:)
//DONE!! Push up to github
//~~~~~~~


//Remember
//You must also account for the appropriate grammar of the string - so it can’t be
//“1 dollars” For example:  
//“5 dollars”
//“1 dollar”
//“16 dollars”


namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)

        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isCheck)
        {
            var sum = num1 + num2;

            if (isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if(isCheck == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if(isCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }

        public static void Main(string[] args)
        {
            var x = 29;
            var y = 55;

                var answer = Add(x, y);

                var a = 32.0m;
                var b = 45.0m;

                var decimalAnswer = Add(a, b);

                var thirdAnswer = Add(0, 0, true);

                Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
                Console.WriteLine(thirdAnswer);
        }
    }
}
