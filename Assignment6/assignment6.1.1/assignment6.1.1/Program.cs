using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Dotnet
{
    class Book
    {
        string name;
       

        public Book(string bookname, string authorname)
        {
            this.name = bookname;
            this.name = authorname;
        }

        public void Display()
        {
            Console.WriteLine(name + " " + "is in :" + name +  "name");
        }
    }
    class BookShelf
    {
        Book[] bookobj = new Book[5];

        public Book this[float pos]
        {
            get { return bookobj[(int)pos]; }
            set { bookobj[(int)pos] = value; }
        }

        public Book this[double s]
        {
            get { return bookobj[(int)s]; }
            set { bookobj[(int)s] = value; }
        }

        static void Main()
        {
            BookShelf fv = new BookShelf();
            fv[0.0f] = new Book("The Christmas Pig", "J K Rowling");
            fv[1.0f] = new Book("Whereabouts", "Jhumpa Lahiri");
            fv[2.0f] = new Book("The Indian Story", "Bimal Jalal");
            fv[3.0f] = new Book("A Passage to India", "E M Foster");
            fv[4.0f] = new Book("A Revenue Stamp", "Amrita Pritam");
            for (int i = 0; i < 5; i++)
            {
                fv[i].Display();
            }
            BookShelf fv1 = new BookShelf();
            fv1[0.0] = new Book("Romeo and Juliet", "Shakesphere");
            fv1[1.0] = new Book("Ramayanam", "Valmiki");

            fv1[0].Display();
            fv1[1].Display();
            Console.Read();
        }
    }
}
