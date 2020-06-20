using System;
using System.Collections.Generic;

namespace GoogleInterviewQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasPairWithSum(new[] { 1, 2, 4, 4}, 8));
            Console.ReadLine();
        }

        static bool HasPairWithSum(int[] arr, int sum) //O(n)
        {
            HashSet<int> complimentSets = new HashSet<int>();

            //Loop through array passed in
            for(int i = 0; i < arr.Length; i++) { 
                //Check to see if current value exists in Hashset
                if (complimentSets.Contains(arr[i]))
                    return true; //If the value exists, it means that another number in the array exists that pairs with the value to equal the sum
                complimentSets.Add(sum - arr[i]); //Otherwise add the compliment (sum - value) and continue
            }

            return false; //We did not find a pair that equaled the sum
        }
    }
}
