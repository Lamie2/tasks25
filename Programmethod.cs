using System;

namespace taskmethod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task2

            string word = "Visual9";
            Console.WriteLine(CheckWord(word));
            #endregion

            #region task3

            //Console.WriteLine("zehmet olmasa metni daxil edin");
            //string words = Console.ReadLine();
            //Console.WriteLine(GetFirstWord(words));
            #endregion

            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int newArr = AddValueToArray(ref arr, 6);
            Console.WriteLine(newArr);


        }

        #region task2
        static bool CheckWord(string word)
        {
            bool containNumber = false;
            bool existUpperCase = false;
            bool existLowerCase = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    containNumber = true;
 }
                if (char.IsUpper(word[i]))
                {
                    existUpperCase = true;
                }
                if (char.IsLower(word[i]))
                {
                    existLowerCase = true;
                }
            }
            if (containNumber && existUpperCase && existLowerCase)
            {
                return true;
            }
            else
            {
                return false;
            }
         
        }
        #endregion


        #region task3 Method

        //static string GetFirstWord(string words)
        //{
        //    string firstName;
        //    firstName = words.Substring(0, words.IndexOf(" "));
        //    return firstName;
        //}

        #endregion

        #region task5
        static int AddValueToArray(ref int[] array, int val)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length] = val;
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

    }
}
