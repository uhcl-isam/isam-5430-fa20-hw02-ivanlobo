using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Schema;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Create an app that lets you enter a bunc hof integers until the
    /// end of line with a CTRL-Z. We will say that a "clump" of these numbers
    /// is a series of 2 or more adjacent elements of the same value. The app will
    /// simply print out the number that is the count of these clumps.
    /// </summary>
    public class CountClumps
    {
        public static void Main()
        {
            // Write your codes here
            String input;
            int clumps = 0;
            List<Int32> lst = new List<Int32>();
            //Read integers an store into array list
            while ((input = Console.ReadLine()) != null && input != "")
            {
                lst.Add(Convert.ToInt32(input));
            }
            // Traverse the list
            for (int i = 0; i < lst.Count - 1; i++)
            {
                int flag = 0;
                //condition check
                while (i < lst.Count - 1)
                {
                    if (lst[i] == lst[i + 1])
                    {
                        flag = 1;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                //If condition satisfy
                if (flag == 1)
                    clumps += 1;
            }
            //Display result
            Console.WriteLine("\nClumps count = " + clumps);
        }


        }
    }

