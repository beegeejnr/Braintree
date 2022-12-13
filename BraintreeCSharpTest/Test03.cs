using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
 *  Test 3: Use regex to extract the list of objects from the InputString and output them in the console window, sorted by object type, then by object id.
 *  Sample output:
 *  ObjectType= Codeunit, ID= 50000
 *  ObjectType= Codeunit, ID= 50001
 *  ...
 *  ObjectType= Table, ID= 770
 *  ObjectType= Table, ID= 50100
 */

namespace BraintreeCSharpTest
{
    internal class Test03
    {

        public static void Run()
        {
            Console.Clear();
            string InputString = "Table50100;Codeunit50000;Report50751;codeunit50002;codeunit50003;report50010;report50002;report50007;codeunit50001;table770;xmlport50000";

            // Your solution goes here

            var objects = (InputString.Split(';'));
            var objectStrings = new List<string>(objects);

            List<ObjectInput> objectInputs = new List<ObjectInput>();
        
            foreach (var obj in objectStrings)
            {
                var id = Regex.Match(obj, @"\d+").Value;
                var objectType = Regex.Replace(obj, @"[\d-]", string.Empty);
                objectInputs.Add(new ObjectInput { Id = int.Parse(id), ObjectType = objectType });
            }

            objectInputs.Sort(new SortComparer<ObjectInput>());
            foreach (var obj in objectInputs)
            {
                Console.WriteLine($"{obj}");
            }
          
            Console.WriteLine();
            Console.WriteLine("Enter to continue");
            Console.ReadLine();
        }
    }

    public class ObjectInput
    {
        public string? ObjectType { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return $"ObjectType= {ObjectType},  ID= {Id}";
        }
    }
    internal class SortComparer<T> : IComparer<T>
    {
        public int Compare(T? x, T? y)
        {
            var object1 = x as ObjectInput;
            var object2 = y as ObjectInput;

            var objectTypeCompareResult = string.Compare(object1.ObjectType, object2.ObjectType, true);
            if (objectTypeCompareResult == 0)
            {
                if ((object1.Id == object2.Id))
                {
                    return 0;
                }
                else if ((object1.Id < object2.Id))
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
          }

            return objectTypeCompareResult;
        }

    }
}
