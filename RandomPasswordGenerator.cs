using System;
using System.Text;

namespace GeradorSenhasAleatorias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Gerador de Senhas Aleatórias!");
            
            while (true)
            {
                Console.Write("\nComprimento da senha: ");
                int length = int.Parse(Console.ReadLine());
                
                Console.Write("Incluir letras maiúsculas? (S/N): ");
                bool includeUppercase = Console.ReadLine().Trim().ToLower() == "s";
                
                Console.Write("Incluir letras minúsculas? (S/N): ");
                bool includeLowercase = Console.ReadLine().Trim().ToLower() == "s";
                
                Console.Write("Incluir dígitos? (S/N): ");
                bool includeDigits = Console.ReadLine().Trim().ToLower() == "s";
                
                Console.Write("Incluir caracteres especiais? (S/N): ");
                bool includeSpecialChars = Console.ReadLine().Trim().ToLower() == "s";
                
                string generatedPassword = GenerateRandomPassword(length, includeUppercase, includeLowercase, includeDigits, includeSpecialChars);
                Console.WriteLine($"\nSenha gerada: {generatedPassword}\n");
                
                Console.Write("Deseja gerar outra senha? (S/N): ");
                if (Console.ReadLine().Trim().ToLower() != "s")
                    break;
            }
            
            Console.WriteLine("Obrigado por usar o Gerador de Senhas Aleatórias!");
        }
        
        static string GenerateRandomPassword(int length, bool includeUppercase, bool includeLowercase, bool includeDigits, bool includeSpecialChars)
        {
            const string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            const string digitChars = "0123456789";
            const string specialChars = "!@#$%^&*()_-+=<>?";

            StringBuilder validChars = new StringBuilder();
            if (includeUppercase)
                validChars.Append(uppercaseChars);
            if (includeLowercase)
                validChars.Append(lowercaseChars);
            if (includeDigits)
                validChars.Append(digitChars);
            if (includeSpecialChars)
                validChars.Append(specialChars);

            Random random = new Random();
            StringBuilder password = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int randomIndex = random.Next(0, validChars.Length);
                password.Append(validChars[randomIndex]);
            }

            return password.ToString();
        }
    }
}
