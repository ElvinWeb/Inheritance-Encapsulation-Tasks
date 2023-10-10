namespace EncapsulationAndInheritanceTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person(" Elvin Sarkarov  ", 20, 0553453434);
            //person.showAllData();



            string strVal = Console.ReadLine();
            Console.WriteLine(Capitalize(strVal));

        }

        static string Capitalize(string word)
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
    }
}