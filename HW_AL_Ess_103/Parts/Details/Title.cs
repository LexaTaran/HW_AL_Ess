using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AL_Ess_103.Parts.Details
{
    public class Title
    {
        string titleInfo;
        public string TitleInfo
        {
            private get
            {
                if (titleInfo == null)
                {
                    return "No Title Information";
                }
                else
                    return titleInfo;
            }
            set => titleInfo = value;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(TitleInfo);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
