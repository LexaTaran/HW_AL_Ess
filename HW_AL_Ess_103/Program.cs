using HW_AL_Ess_103.Parts;
using HW_AL_Ess_103.Parts.Details;

namespace HW_AL_Ess_103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author stivens = new Author();
            stivens.AuthorName = "Stivens";
            Title stivensTitle = new Title();
            stivensTitle.TitleInfo = "Ocean";
            Content stivensContent = new Content();
            stivensContent.ContentInfo = "Live in ocean";

            Book stivensBook = new Book(stivens, stivensTitle, stivensContent);

            stivensBook.Show();    
        }
    }
}