using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    * Test 2: 
    * 1. Check that the user enters an uneven number. 
    * 2. It must be greater than 1, but not larger than 30
    * 3. e.g. If user enters 9, it must draw a pyramid that looks like this:       

    *
   ***
  *****
 *******
*********

*/

namespace BraintreeCSharpTest
{
    internal class Test02
    {
        public static void Run()
        {
            string lengthAsText = "";

            while (lengthAsText != "0")
            {
                Console.Clear();
                Console.Write("Enter the base length of Pyramid (0 to exit): ");
                lengthAsText = Console.ReadLine();
                var length = int.Parse(lengthAsText);

                if (length < 0 || length > 30)
                {

                    continue;
                }

                if (length % 2 == 0)
                {
                    continue;
                }

                Console.Clear();
                if (length != 0)
                {
                    // Your solution goes here
                    int spaceCount = length / 2;

                    string spacer = new(' ', spaceCount);

                    for (int line = 1; line <= length; line++)
                    {
                        if (line % 2 == 1)
                        {
                            var space = spacer.Substring(0, spaceCount);
                            var stars = new String('*', line);
                            Console.WriteLine($"{space}{stars}");
                            spaceCount -= 1;
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Press enter");
                    Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
