namespace EncapsulationAndInheritanceTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person(" Elvin Sarkarov  ", 20, 0553453434);
            //person.showAllData();



            string strVal = Console.ReadLine();
            Console.WriteLine(Capitalize2(strVal));

        }
         //first solution
        static string Capitalize1(string word)
        {
            string capitalWord = "";
            word = word.Trim();

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[0]))
                {
                    capitalWord = word;
                    break;
                }
                else
                {
                    capitalWord = char.ToUpper(word[0]) + word.Substring(1);
                }
            }
            return capitalWord;
        }
         //second solution
        static string Capitalize2(string word)
        {
            char firstChar = word[0];
            int asciiVal = (int)firstChar;

            if (asciiVal >= 97 && asciiVal <= 122)
            {
                char capitalizedChar = (char)(asciiVal - 32);
                word = capitalizedChar + word.Substring(1);
            }

            return word;
        }
    }
}
