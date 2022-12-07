namespace Tema1
{
    internal class Exercises
    {
        static void Main(String[] args)
        {

            //emailAndPasswordAttempts();
            //checkTheChar();
            //if(evenOrOdd() == true)
            //{
            //    Console.WriteLine("Numerele sunt pare sau impare");
            //}
            //else
            //{
            //    Console.WriteLine("Numerele nu sunt nici pare nici impare");
            //}
            isPalindrome();
        }
        static void emailAndPasswordAttempts()
        {
            int attempts = 3;
            int triedattempts = 3;
            
            
            for(int i = 1; i <= attempts; i++)
            {triedattempts--;
            Console.WriteLine("Introduceti emailul: ");
            string email = Console.ReadLine();
            Console.WriteLine("Introduceti parola: ");
            string password = Console.ReadLine();
         
               
                if (email == "Email" && password == "1234")
                {
                    Console.WriteLine("Te-ai logat cu succes.");
                    break;
                   
                }
                else if(i== attempts)
                {
                    Console.WriteLine("Nu mai ai incercari.");
                }
                else
                {
                    
                    Console.WriteLine("Mai incearca! Mai ai " + triedattempts);
                }
                
            }
            
        }


        static void checkTheChar()
        {
            char caracter;
            Console.WriteLine("Introduceti un caracter: ");
            caracter = Convert.ToChar(Console.ReadLine());

            if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u') 
                Console.WriteLine($"{caracter} este o vocala");
            else if (char.IsDigit(caracter))
            {
                Console.WriteLine($"{caracter} este o cifra");
            }
            else
            {
                Console.WriteLine($"{caracter} este un alt simbol");
            }

        }

        static bool evenOrOdd()
        {
            bool result;
            int n1,n2;
            Console.WriteLine("Introduceti nr 1: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti nr 2:");
            n2 = Convert.ToInt32(Console.ReadLine());

            if((n1%2 ==0 && n2 % 2 == 0)|| (n1%2 == 1 && n2 % 2 == 1))
            {
                return true;
            }else
                return false;
                
        }

    /*    static bool isPalindrome()
        {
            string[] words2;
            int x;
            Console.WriteLine("Introduceti nr de cuvintele: ");
            int lengthArray = Convert.ToInt32(Console.ReadLine());
            words2 = new string[lengthArray];
    
            Console.WriteLine("Introduceti cuvintele: ");
            for (int i = 0; i < lengthArray; i++)
            {
                Console.ReadLine();
            }

            return true;

        }*/

    }
    
}




