using HW_AL_Ess_103.Parts.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AL_Ess_103.Parts
{
    class Book
    {
        Author author;
        Title title;
        Content content;

        public Book (Author author, Title title, Content content)
        {
            this.author = author;
            this.title = title;
            this.content = content;
        }

        public void Show()
        {
            author.Show();
            title.Show();
            content.Show();
        }

    }
}
