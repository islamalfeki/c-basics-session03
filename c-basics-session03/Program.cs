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

            StringBuilder str = new StringBuilder();

            str.Append("Book List");
            Console.WriteLine(str);

            str.Append(" - Updated");
            Console.WriteLine(str);

            #endregion

            #region Question04
            // Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". 
            //Print the result.


            str.Replace("Book List", "Library");
            Console.WriteLine(str);

            #endregion

        }
    }
}
