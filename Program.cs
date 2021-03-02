using System;

namespace FindTheLeaderOfArray
{
    class Program
    {
        static int solution(int[] A)
        {
            int length = A.Length;
            int leader = A[length / 2];
            
            int numberOfRepeat = 0;
            
            for (int i = 0; i < length; i++)
            {
                if(A[i] == leader)
                {
                    numberOfRepeat++;
                }    
            }
            if (numberOfRepeat > length/2)
               return leader;


            return -1;
        }

        static void Main(string[] args)
        {
            int[] A1 = new int[] { 2, 2, 2, 2, 2, 3, 4, 4, 4, 6 };
            int[] A2 = new int[] { 1, 1, 1, 1, 50 };

            Console.WriteLine("Leader of array nr. 1 is: " + solution(A1));
            Console.WriteLine("Leader of array nr. 2 is: " + solution(A2));
        }
    }
}
