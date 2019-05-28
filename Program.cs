using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Teme
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            somestring();
            RemoveOdd();
            UpperAndLower();
            ReverseString();
            ConvertUpper();
            RemoveNewLine();
            DisplayChar();
            Percentage();
            ToLower();
            Characters();
            CensorEmail();
            LongestWord();
            CheckStartWord();
            CountOccurrences();
            SwpaComma();
            RemoveSpace();
            Palindrome();
            SingleString();
            GetBeforeChar();
            */


            //1.Write a method that to remove the nth index character from a nonempty string.
            static void somestring()
            {
                string somestring = "bogdan incearca sa faca temele";
                StringBuilder bb = new StringBuilder(somestring);
                bb.Remove(7, 9);
                somestring = bb.ToString();
                Console.WriteLine(somestring);
            }


            //2.Write a method that to remove the characters which have odd index values of a given string
            static void RemoveOdd()
            {
                string s = "teleenciclopedia";
                StringBuilder ss = new StringBuilder(s);
                for (int i = 0; i <= s.Length; i++)
                {
                    if (IsOdd(i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            static bool IsOdd(int value)
            {
                return value % 2 != 1;
            }


            //3.Write a method that takes input from the user and displays that input back in upper and lower cases
            static void UpperAndLower()
            {
                string uperlower;
                Console.Write("enter enter some words ---");
                uperlower = Console.ReadLine();
                Console.WriteLine(uperlower.ToLower());
                Console.WriteLine(uperlower.ToUpper());
            }


            //4.Write a method that reverses a string if it's length is a multiple of 4
            static void ReverseString()
            {
                string str = "", reverse = "";
                int Length = 0;
                Console.WriteLine("Enter the string");
                str = Console.ReadLine();
                Length = str.Length - 1;
                while (Length >= 0)
                    if (str.Length % 4 == 0)
                    {
                        reverse = reverse + str[Length];
                        Length--;
                    }
                    else
                    {
                        return;
                    }

                Console.WriteLine("Reverse word is {0}", reverse);
            }



            //5.Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters
            static void ConvertUpper()
            {
                Console.Write("Please enter the text: ");
                string brb = Console.ReadLine();
                for (int i = 0; i < brb.Length; i++)
                {
                    if (brb.Length < 4)

                        Console.WriteLine(brb.Substring(0, 4).ToUpper() + brb.Substring(2, brb.Length - 4));
                }


                Console.WriteLine(brb.ToLower());
            }



            //6.Write a method that to remove a newline
            static void RemoveNewLine()
            {
                string x = "First line \r\n Second Line \r\n Third Line \r\n Forth Line";
                x = x.Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty);
                Console.WriteLine(x);
            }


            //7.Write a method to display formatted text (width=50) as output. For example:
            //If I have a text that's 134 characters long, the formatted string should have maximum of 50 characters per line
            //In this case we will have 3 lines of text
            static void DisplayChar()
            {
                string test = "Georgiana a fost in stransa legatura cu voluntarii care le ofereau in fiecare saptamana copiilor din centre bucuria unei noi ore de engleza prin joc";
                int nInterval = 50;
                string res = String.Concat(test.Select((c, i) => i > 0 && (i % nInterval) == 0 ? c.ToString() + Environment.NewLine : c.ToString()));
                Console.WriteLine(res);
            }


            //8.Write a method that formats a number with a percentage
            static void Percentage()
            {
                double val = .975746;
                Console.WriteLine(val.ToString("P", CultureInfo.InvariantCulture));
            }


            //9.Write a method that transforms to lowercase first n characters in a string
            static void ToLower()
            {
                string myString = "BaRBOloGIE";
                int n = 8;
                string firstPart = myString.Substring(0, n).ToLower();
                string restOfString = myString.Substring(n);
                string finalString = firstPart + restOfString;
                Console.WriteLine($"Output: {finalString}");
            }


            //10.Write a method that strips a set of characters from a string



            /*
            //11.Write a method to capitalize first and last letters of each word of a given string

            string r = "capitala romaniei este bucuresti";
            r = Regex.Replace(r, @"(^\w)|(\s\w)", m => m.Value.ToUpper());
            Console.WriteLine(r);
            */


            //12.Write a method to compute sum of digits of a given string(if any)

            string o = "bar445ule872scu";
            int sum = 0;
            var bog = o.ToCharArray();
            Console.WriteLine(o);
            for (int i = 0; i <= o.Length - 1; i++)
            {
                if (o[i] > '0' && o[i] <= '9')
                {
                    sum += o[i] - '0';
                }
            }
            Console.WriteLine(sum);


            //13.You will get a text from where you will need to clean the text because it contains a lot of strange characters that don’t belong there ( ^ <, > &+ @%$)
            //Hi ^> there << I’m + telling %% you, you & need % to$ do &your $homeworks.@Hate ^ me ^ % now % and % thank % me & later.
            //Hi there I’m telling you, you need to do your homeworks. Hate me now and thank me later.
            static void Characters()
            {
                string x = "Hi ^> there << I’m + telling %% you, you & need % to$ do &your $homeworks.@Hate ^ me ^ % now % and % thank % me & later";
                string modifiedString = x.Replace("^", "").Replace("<", "").Replace(",", "").Replace(">", "").Replace("&", "").Replace("+", "").Replace("@", " ").Replace("%", "").Replace("$", "");
                Console.WriteLine(modifiedString);
            }


            //14.Write a method to add 'ing' at the end of a given string (length should be at least 3). 
            //If the given string already ends with 'ing' then add 'ly' instead. If the string length of the given string is less than 3, leave it unchanged.



            // 15.You have some text that contains your email address.And you want to hide that. You decide to censor your email:
            //to replace all characters in it with asterisks('*') except the domain.Assume your email address will always be in format[username]@[domain]. 
            //You need to replace the username with asterisks of equal number of letters and keep the domain unchanged.You will get as input the email address you need to obfuscate
            static void CensorEmail()
            {
                string email = "awesome @dotnet.com";
                string hiddenEmail = email.Substring(0, email.IndexOf('@'));
                string domain = email.Substring(email.IndexOf('@'));
                var hidden = new string('*', email.IndexOf('@'));
                Console.WriteLine($"Output: {hidden + domain}");
            }

            //16.Write a method to get a string made of the first 2 and the last 2 chars from a given a string. 
            //If the string length is less than 2, return instead of the empty string



            //17.Write a method to get a string from a given string where all occurrences of its first char have been changed to '$', except the first char itself
            


            //18.Write a method to get a single string from two given strings, separated by a space and swap the first two characters of each string
            static void SingleString()
            {
                string str = "super exemple of string key : text I want to keep - end of my string";
                int startIndex = str.IndexOf("key") + "key".Length;
                int endIndex = str.IndexOf("-");
                string newString = str.Substring(startIndex, endIndex - startIndex);
                Console.WriteLine(newString);
            }

            //19.Write a method to find the first appearance of the substring 'not' and 'poor' from a given string, 
            //if 'not' follows the 'poor', replace the whole 'not'...'poor' substring with 'good'. Return the resulting string




            //20.Write a method that takes a list of words and returns the length of the longest one
            static void LongestWord()
            {
                string line = "Oare de ce trebuie sa avem teme de facut in vacanta ?";
                string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
                string word = "";
                int ctr = 0;
                foreach (String s in words)
                {
                    if (s.Length > ctr)
                    {
                        word = s;
                        ctr = s.Length;
                    }
                }

                Console.WriteLine(word);
            }


            //21.Write a method to get the last part of a string before a specified character
            static void GetBeforeChar()
            {
                string authors = "Vasile Alecsandri - Nicolae Iorga - Emil Cioran, Mihai Eminescu, Octavian Blaga";
                string stringBeforeChar = authors.Substring(0, authors.IndexOf(","));
                Console.WriteLine(stringBeforeChar);
            }

            //22.Write a method to check whether a string starts with specified characters
            static void CheckStartWord()
            {
                string str;
                Console.Write("Input a string : ");
                str = Console.ReadLine();
                Console.WriteLine((str.Length < 2 && str.Equals("b")) || (str.StartsWith("b") && str[1] == ' '));
            }


            //23.Write a method to count occurrences of a substring in a string
            static void CountOccurrences()
            {
                string text = "Gates este membru al Consiliului de Administraţie al fondului de investitii Berkshire Hathaway, detinut de un alt miliardar, Warren Buffett, cu care este bun prieten," +
                    " si care a donat miliarde de dolari fundatiei pe care cofondatorul Microsoft o conduce alaturi de sotia sa, Melinda";
                string searchTerm = "de";
                string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var matchQuery = from word in source
                                 where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
                                 select word;
                int wordCount = matchQuery.Count();
                Console.WriteLine("{0} aparitii  \"{1}\" au fost gasite", wordCount, searchTerm);
            }


            //24.Write a method to swap comma and dot in a string
            static void SwpaComma()
            {
                var s = "5,345,433,963";
                s = s.Replace(",", ".");
                Console.WriteLine(s);
            }



            //25.Write a method to remove spaces from a given string
            static void RemoveSpace()
            {
                string space = "Din aceasta propozitie trebuie sa dispara spatiul";
                space = space.Replace(" ", String.Empty);
                Console.WriteLine(space);
            }


            //26.Check if a string is palindrome (same value read from left to right and right to left) Ex: alabala -> True
            static void Palindrome()
            {
                string palindrome, rev;
                Console.Write("Input a string: ");
                palindrome = Console.ReadLine();
                char[] ch = palindrome.ToCharArray();

                Array.Reverse(ch);
                rev = new string(ch);

                bool b = palindrome.Equals(rev, StringComparison.OrdinalIgnoreCase);
                if (b == true)
                {
                    Console.WriteLine("" + palindrome + " is a Palindrome!");
                }
                else
                {
                    Console.WriteLine("" + palindrome + " is not a Palindrome!");
                }
                Console.Read();
            }
        }
    }
}

