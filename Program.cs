namespace Arrays {
    class Arrays
    {
        static void Main(string[] args)
        {
            //Arrays Declaration(named location in the memory to stick staff i.e no arrays in it
            //int[] scores;

            //Creating a new array and place it in the variable. We use new keyword and specify the number of elements that you'll have in the array
            //int[] scores = new int[10]; //An array with a rooom for 10 items in it.


             //LENGTH OF ARRAY
            int[] scores = new[] { 100, 90, 80, 70, 60 };

            int totalLengthInArray = scores.Length;

            Console.WriteLine(totalLengthInArray);



        }
    }
}