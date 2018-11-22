using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
namespace IoFileStreams
{
    class StringReaderExample
    {
        static void ReadCharacters()
        {
            StringBuilder stringToRead = new StringBuilder();
            stringToRead.AppendLine("Characters in 1st line to read");
            stringToRead.AppendLine("and 2nd line");
            stringToRead.AppendLine("and the end");


            //string str = "some text";
            //str = str + "some more text";
            //str = str + "some more more text";

            using (StringReader reader = new StringReader(stringToRead.ToString()))
            {
                //string readText = await reader.ReadToEndAsync();
                //Console.WriteLine(readText);
            }
        }
    }
}
