using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Converter {
    class Program {
        static void Quotations(string[] lines) {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Reflective\Desktop\Hub Folder\Programming\AoC2020\output.txt")) {
                foreach (string line in lines) {
                    // If the line doesn't contain the word 'Second', write the line to the file.
                    file.WriteLine("\"" + line + "\",");
                }
            }
        }

        static void Main(string[] args) {
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Reflective\Desktop\Hub Folder\Programming\AoC2020\input.txt");

            Quotations(lines);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
