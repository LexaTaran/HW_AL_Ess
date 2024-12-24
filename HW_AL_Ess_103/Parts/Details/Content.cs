using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AL_Ess_103.Parts.Details
{
    public class Content
    {
        string contentInfo;
        public string ContentInfo
        {
            private get
            {
                if (contentInfo == null)
                {
                    return "No Info in content";
                }
                else
                    return contentInfo;
            }
            set => contentInfo = value;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ContentInfo);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
