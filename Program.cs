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
            //int[] scores = new[] { 100, 90, 80, 70, 60 };

            //int totalLengthInArray = scores.Length;

            //Console.WriteLine(totalLengthInArray);

            //MINIMUM VALUE IN AN ARRAY
            //int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            //int currentMinimum = Int32.MaxValue; // We start high, so that any element in the array will be lower.
            //for (int index = 0; index < array.Length; index++)
            //{
            //if (array[index] < currentMinimum)
            //currentMinimum = array[index];                
            //}
            //Console.WriteLine(currentMinimum);

            //AVERAGE VALUE IN AN ARRAY
            /*   int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

               int total = 0;

               for (int index = 0; index < array.Length; index++)
               {
                   total += array[index];
                   //Console.WriteLine(total);
               }
               float average = (float)total / array.Length;
               Console.WriteLine(average);*/

            //ARRAY OF ARRAYS AND MULTI-DIMENTIONAL ARRAYS
            //array of arrays, or a jagged array(array within a larger array has a different lenght)
         /*   int[][] matrix = new int[4][];

            matrix[0] = new int[4];
            matrix[1] = new int[5];
            matrix[2] = new int[2];
            matrix[3] = new int[6];

            for (int row = 0; row < matrix.Length; row++)
            {
            for (int column = 0; column < matrix[row].Length; column++)
            //Console.Write(matrix[row][column] + " "); // Each item in the row separated by spaces

            Console.WriteLine(); // Rows separated by lines
            }*/

            //Multi-dimentional array
            //int[,] matrix = new int[4, 4];
            //Fill in contents for multi-dimensional array
            // Note: GetLength gives back the size of the multi-dimensional array for a specific index.
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //for (int column = 0; column < matrix.GetLength(1); column++)
            //Console.Write(matrix[row, column] + " ");
            //Console.WriteLine();
            //}

            //FOREACH LOOP
            //int[] scores = new int[] {75, 44, 34, 25,78, 89, 90, 69, 45, 36};
            /* note is that inside of the loop, you 
            /have no way of knowing what index you are currently at. (You don’t know if you are on scores[2] or
            scores[4].)
            If you need to know what index you’re at, your best bet is to use a FOR LOOP instead:*/
            //foreach (int score in scores)
            //Console.WriteLine("Someone had this score: " + score);

            //FOR LOOP(To know what index we are at unlike with FOREACH LOOP)
            /*  int[] scores = new [] { 75, 44, 34, 25, 78, 89, 90, 69, 45, 36 }; ;
              for (int index = 0; index < scores.Length; index++)
              {
                  int score = scores[index];
                  Console.WriteLine("Score #" + index + ": " + score);
              }*/


       

           /* int[,] arr = new int[2, 2 ] { {3,5 }, {9,6 } };

            Console.Out.WriteLine(arr[0,1])*/;

            //ITERATE OVER AN ARRAY
            //int[] arr = new[] { 1, 2, 3, 4, 5, 6 };

            /* for(int index = 0; index< arr.Length; index++)
             {
                 Console.WriteLine(arr[index]);
             }*/

            //using for loop
            /* foreach (int no in arr)
             {
                 Console.WriteLine(no);
             }*/

            //ARRAY DECLARATION
            //int[] arr; //not allocated to the memory

            //ARRAY INITIALIZATION
            //int[] arr = new int[5];//new keyword allocates the array to the memory with the specified size

            //int[] arr = new int[5] { 1, 2, 3, 4, 5 }; //Defining an array and assigning values at the same time
            //int[] arr = { 1, 2, 3, 4, 5 }; 
            //int[] arr = new[] { 1, 2, 3, 4, 5 };

            //INITIALIZATION OF AN ARRAY AFTER DECLARATION
            /*  int[] arr; //Decraration
              //arr =new int[5] { 1,2,3,4,5};
              //arr = new int[5];
              arr =new[] { 1,2,3,4,5};

              string[] s;
              s = new string[2] {"Mike", "Mathu"};*/


            //ACCESSING ARRAY ELEMENTS
            /*   int[] arr; //declaration

               arr = new int[5]; //Definition

               arr[0] = 10; //assignning 10 to index 0

               Console.WriteLine(arr[0]);*/


            //ACCESSING ARRAY ELEMENTS USING DIFFERENT LOOPS

            /*int[] intArray;

            intArray = new int[5]; //allocating memory for the 5 integers

            intArray[0] = 10;
            intArray[1] = 20;
            intArray[2] = 30;
            intArray[3] = 40;
            intArray[4] = 50;

            //accessing the elements using for loop
            Console.Write("For Loop :");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(" ");
                Console.Write(intArray[i]);
            }

            //using for-each loop
            Console.WriteLine(" ");
            Console.Write("ForEach Loop :");
            foreach (int i in intArray)
            {
                Console.Write(" " + i);
            }

            //using while loop
            Console.WriteLine(" ");
            Console.Write("While Loop :");

            int j = 0;
            while(j < intArray.Length)
            {
                Console.Write(" " + intArray[j]);
                j++;
            }

            //using do while loop
            Console.WriteLine(" ");
            Console.Write("Do While Loop :");

            int k = 0;
            do
            {
                Console.Write(" " + intArray[k]);
                k++;
            } while (k < intArray.Length);*/


            //MULTIDIMENTIONAL ARRAYS. To storing and accessing the values of the array, one require the nested loop.
            //int[,] arr = new int[2,2];
            //int[, ] arry = new int[ , ] { { 1, 2 }, { 1,2} };

            //Two-dimentional array
            int[, ] intarray = new int[,] { {1, 2}, {3,4 }, {5, 6 }, { 7, 8} };

            //same array with dimentions specified
            int[,] intarray_d = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            //similar array with string elements
            string[,] str = new string[4, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" }, { "seven", "eight" } };

            //Three-dimentional arrays
            int[,,] intarray3D = new int[,, ] { { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } } };

            //The same 3D array specified
            //int[,, ] intarrat3Dd = new int[2,2, 3] { { { 1, 2,3  }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } } };

            //Accesing array elements
            /*   Console.WriteLine("2DArray[0][0] : " + intarray[0, 0]);
               Console.WriteLine("2DArray[0][1] : " + intarray[0, 1]);
               Console.WriteLine("2DArray[1][1] : " + intarray[1, 1]);
               Console.WriteLine("2DArray[2][0] : " + intarray[2, 0]);

               Console.WriteLine("2DArray[1][1] (other) : " + intarray_d[1, 1]);

               Console.WriteLine("2DArray[1][0] (other) : " + intarray_d[1, 0]);*/

            //Console.WriteLine("3DArray[1][0][1] (other) : " + intarray3D[1, 0, 1]);
            //Console.WriteLine("3DArray[1][1][2] (other) : " + intarray3D[1, 1, 2]);
            //Console.WriteLine("3DArray[0][1][1] (other) : " + intarray3Dd[0, 1, 1]);
            //Console.WriteLine("3DArray[1][0][2] (other) : " + intarray3Dd[1, 0, 2]);

            //using nested loop to show string elements
            Console.WriteLine("To String element");
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 2; j++)
                    Console.WriteLine(str[i, j] + " ");
            
            























        }
    }
}