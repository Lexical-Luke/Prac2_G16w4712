using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(prefix("hello"));
            Console.WriteLine(prefix(""));
            Console.WriteLine(prefix("what   ...  did you say??  "));  
            Console.WriteLine(prefix(null));
        }

        static public string prefix(string input)
        {
            int charz;
            int words = 0;

            //fringe cases
            if(input == "")
            {
                return "0,0:";
            }
            if(input == null)
            {
                return null;
            }
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

            
        
            return charz + "," + words + ":" + input;
            
            
        }
    }
}
