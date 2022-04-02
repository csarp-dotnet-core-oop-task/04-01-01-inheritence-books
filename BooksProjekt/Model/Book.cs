using System;
using System.Collections.Generic;
using System.Text;

namespace Konyvek.model
{
    public abstract class Book
    {
        /// <summary>
        /// könyv címe
        /// </summary>
        protected string title;
        /// <summary>
        /// könyv oldalszáma
        /// </summary>
        protected int pageNumber;
        /// <summary>
        /// könyv szerzője
        /// </summary>
        protected string author;
        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="title">könyv címe</param>
        /// <param name="pageNumber">könyv oldalszáma</param>
        /// <param name="author">könyv szerzője</param>
        protected Book(string author, string title, int pageNumber)
        {
            this.title = title;
            this.pageNumber = pageNumber;
            this.author = author;
        }

        public override string ToString()
        {
            return "Könyv szerzője: " + author + "\nKönyv címe: " + title + "\nKönyv oldalszáma: " + pageNumber;
        }

    }
}
