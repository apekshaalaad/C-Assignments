using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssign1
{
    internal class Book
    {
        struct book
        {
            public int bookId;
            public string title;
            public int price;
            public string bookType;

        }
        enum bookType
        {
            magazine,
            novel,
            referencebook,
            miscellaneous
        }
        public static void Main()
        {
            book b = new book();
            Console.Write("\n\nEnter the information of books  :\n");
            
            Console.Write("Enter  BookId  :");
            b.bookId = Int32.Parse(Console.ReadLine());
            Console.Write("Enter  Title :");
            b.title = Console.ReadLine();
            Console.Write("Enter price  :");
            b.price = Int32.Parse(Console.ReadLine());
            Console.Write("Book Type  :");
            b.bookType = Console.ReadLine();


            if (b.bookType == "Magazine")
            {
                bookType type1 = bookType.magazine;
                Console.WriteLine(type1);
            }
            else if (b.bookType == "Novel")
            {
                bookType type2 = bookType.novel;
                Console.WriteLine(type2);
            }
            else if (b.bookType == "ReferenceBook")
            {
                bookType type3 = bookType.referencebook;
                Console.WriteLine(type3);
            }
            else if (b.bookType == "Miscellaneous")
            {
                bookType type4 = bookType.miscellaneous;
                Console.WriteLine(type4);
            }
            else
            {
                Console.WriteLine("Selected Book Not In Book Type");
            }

            Console.ReadLine();
        }
    }
}
