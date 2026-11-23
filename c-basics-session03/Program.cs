using System.Text;

namespace c_basics_session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print 
            //both title and upperTitle to show that title did not change.


            //string title = "clean code";
            //string upperTitle = title.ToUpper();

            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);

            #endregion

            #region Question02
            // Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() 
            //to check if they point to the same object in memory.


            //string str1 = "Clean Code";
            //string str2 = "Clean Code";

            //Console.WriteLine(object.ReferenceEquals(str1, str2));

            #endregion

            #region Question03
            // Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same 
            //object.Print the final result.

            //StringBuilder str = new StringBuilder();

            //str.Append("Book List");
            //Console.WriteLine(str);

            //str.Append(" - Updated");
            //Console.WriteLine(str);

            #endregion

            #region Question04
            // Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". 
            //Print the result.


            //str.Replace("Book List", "Library");
            //Console.WriteLine(str);

            #endregion

            #region Question05
            // Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, 
            // Pages: 464" using the + operator.

            //string title = "Clean Code";
            //int pages = 464;

            //Console.WriteLine("Book: " + title + " , Pages: " + pages);

            #endregion

            #region Question06
            // Build the same sentence as above, but using string interpolation ($"..."). 

            //string title = "Clean Code";
            //int pages = 464;

            //Console.WriteLine($"Book: {title} , Pages: {pages}");
            #endregion

            #region Question07
            // Build the same sentence again, but using string.Format(). 

            //string title = "Clean Code";
            //int pages = 464;

            //Console.WriteLine(string.Format("Book: {0} , Pages: {1}", title , pages));
            #endregion

            #region Question08
            // Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 
            ////300, otherwise prints "Short Book".

            //int pages = 464;

            //if (pages > 300)
            //    Console.WriteLine("Long Book");
            //else
            //    Console.WriteLine("Short Book");
            #endregion

            #region Question09
            // Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is 
            //greater than 300 and isAvailable is true.Use the && operator. 

            //int pages = 464;
            //bool isAvailable = true;

            //if (pages > 300 && isAvailable)
            //    Console.WriteLine("You can borrow this book");
            //else
            //    Console.WriteLine("You cannot borrow this book");
            #endregion

            #region Question10
            // Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is 
            //"Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.

            //string title = "Refactoring";
            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great Choice");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;
            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}
            #endregion

            #region Question11
            // Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a 
            //variable sizeLabel(same rule as question 8: long if pages > 300).

            //int pages = 464;
            //string sizedLabel = pages > 300 ? "Long Book" : "Short Book";
            //Console.WriteLine(sizedLabel);
            #endregion

            #region Question12
            // Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop 
            // to print each book with its position number, like 1.Clean Code.

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}.{books[i]}");
            //}
            #endregion

            #region Question13
            // Using the same books array, use a while loop to print every book title.

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int i = 0;
            //while (i < books.Length)
            //{
            //    Console.WriteLine($"{i + 1}.{books[i]}");
            //    i++;
            //}
            #endregion

            #region Question14
            // Write a do-while loop that prints "Checking book..." exactly 3 times.


            //int i = 0;

            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    i++;
            //}
            //while (i < 3);

            #endregion

            #region Question15
            // Using the same books array, use a foreach loop to print every book title.

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //foreach (string book in books)
            //{
            //    Console.WriteLine(book);
            //}

            #endregion

            #region Question16
            // Using the same books array, loop through it and print each title, but stop completely (break) once 
            // you reach "Refactoring".

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //foreach (string book in books)
            //{
            //    if (book == "Refactoring") break;               // Exit
            //    Console.WriteLine(book);
            //}
            #endregion

            #region Question17
            // Using the same books array, print every title except "The Pragmatic Programmer" (skip it with 
            // continue, don't stop the loop).

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer") continue;     // Skip 
                Console.WriteLine(book);
            }
            #endregion

        }
    }
}
