using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            prefix("hello");
            prefix("");
            prefix("what   ...  did you say??  ");  
        }

        static void prefix(string input)
        {
            int charz;
            int words = 0;

            //count char length
            charz = input.Length;

            //string text = input.Trim();
            string text = input;
            int cnt = 0;

            while (cnt < text.Length)
            {
                // check if char belongs to word
                while (cnt < text.Length && !char.IsWhiteSpace(text[cnt]))
                {
                    cnt++;
                } 
                words++;
                // skip dat whitespace 
                while (cnt < text.Length && char.IsWhiteSpace(text[cnt]))
                {
                    cnt++;
                }
            }

            //fringe cases
            if(input == "")
            {
                Console.WriteLine("0,0");
            }
            else if(input == null)
            {
                Console.WriteLine("null");
            }
            else
            {
                Console.WriteLine(charz + "," + words + ":" + input);
            }
            
        }
    }
}
