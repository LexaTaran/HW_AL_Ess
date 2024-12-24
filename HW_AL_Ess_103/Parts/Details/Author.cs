using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AL_Ess_103.Parts.Details
{
    public class Author
    {
        string authorName;
        public string AuthorName
        {
            private get
            {
                if (authorName == null)
                {
                    return "No Author name";
                }
                else
                    return authorName;
            }
            set => authorName = value;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(AuthorName);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
