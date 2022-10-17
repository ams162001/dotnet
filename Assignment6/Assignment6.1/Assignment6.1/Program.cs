using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_6_1_
{
    class BOOKS
    {
        static void Main(string[] args)
        {
            
            book = title book("MUKTHI FREEDOM");
            Console.WriteLine(book.title());
            book = Author("ATMAN RAVI");
            Console.WriteLine(author.Describe());
            Console.ReadLine();
        }
    }
    class books
    {
        private string title;
        public book(string title)
        {
            this.title = title;
        }
        public string Describe()
        {
            return "The name of this book is " + title;
        }
        public string Color
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
    }

