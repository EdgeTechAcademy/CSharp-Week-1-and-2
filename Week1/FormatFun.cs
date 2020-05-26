using System;
using System.Collections.Generic;
using System.Text;

namespace Week1
{
    partial class FormatFun
    {
        static void Main(string[] args)
        {
            FunWithFormats();
            string[] Names = { "Rick Sanchez", "Morty Smith", "Jerry Smith", "Beth Smith", "Summer Smith" };
            string[] Phone = { "817-555,1334", "817-555-3882", "972-555-8211", "469-555-1617", "817-555-2803" };
            string strSearch;

            strSearch = Utils.GetInput("Type a name to search for in the phone book: ");
            for (int i = 0; i < Names.Length; i++)
            {
                if (Names[i].IndexOf(strSearch) >= 0)
                {
                    Console.WriteLine($"{Names[i]} = {Phone[i]}");
                }
            }
        }

        private static void FunWithFormats()
        {
            DateTime thisDate = DateTime.Now;
            Console.Clear();

            // Format a negative integer or floating-point number in various ways.
            Console.WriteLine("Standard Numeric Format Specifiers");
            Console.WriteLine(
                "(C) Currency: . . . . . . . . {0:C}\n" +
                "(D) Decimal:. . . . . . . . . {0:D}\n" +
                "(E) Scientific: . . . . . . . {1:E}\n" +
                "(F) Fixed point:. . . . . . . {1:F}\n" +
                "(G) General:. . . . . . . . . {0:G}\n" +
                " (default):. . . . . . . . {0} (default = 'G')\n" +
                "(N) Number: . . . . . . . . . {0:N}\n" +
                "(P) Percent:. . . . . . . . . {1:P}\n" +
                "(R) Round-trip: . . . . . . . {1:R}\n" +
                "(X) Hexadecimal:. . . . . . . {0:X}\n",
                       -123, -123.45f);

            // Format the current date in various ways.
            Console.WriteLine("Standard DateTime Format Specifiers");
            Console.WriteLine(
                "(d) Short date: . . . . . . . {0:d}\n" +
                "(D) Long date:. . . . . . . . {0:D}\n" +
                "(t) Short time: . . . . . . . {0:t}\n" +
                "(T) Long time:. . . . . . . . {0:T}\n" +
                 "(f) Full date/short time: . . {0:f}\n" +
                 "(F) Full date/long time:. . . {0:F}\n" +
                  "(g) General date/short time:. {0:g}\n" +
                  "(G) General date/long time: . {0:G}\n" +
                  " (default):. . . . . . . . {0} (default = 'G')\n" +
                  "(M) Month:. . . . . . . . . . {0:M}\n" +
                  "(R) RFC1123:. . . . . . . . . {0:R}\n" +
                  "(s) Sortable: . . . . . . . . {0:s}\n" +
                  "(u) Universal sortable: . . . {0:u} (invariant)\n" +
                  "(U) Universal full date/time: {0:U}\n" +
                  "(Y) Year: . . . . . . . . . . {0:Y}\n",
                         thisDate);

            // Format a Color enumeration value in various ways.
            Console.WriteLine("Standard Enumeration Format Specifiers");
            Console.WriteLine(
                "(G) General:. . . . . . . . . {0:G}\n" +
                " (default):. . . . . . . . {0} (default = 'G')\n" +
                "(F) Flags:. . . . . . . . . . {0:F} (flags or integer)\n" +
                "(D) Decimal number: . . . . . {0:D}\n" +
                "(X) Hexadecimal:. . . . . . . {0:X}\n",
                      127);
        }
    }
}
