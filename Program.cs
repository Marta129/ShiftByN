using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Text:");
        string text = Console.ReadLine();
        Console.WriteLine("Enter a number between 1 and 26");
        int nr = int.Parse(Console.ReadLine());
        while(nr<1 || nr>26)
        {
            Console.WriteLine("Enter a number between 1 and 26");
            nr = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("a.Encrypt");
        Console.WriteLine("b.Decrypt");
        Console.WriteLine("Select an option from a or b");
        string aux = Console.ReadLine();
        string option = aux.ToLower();
        switch (option)
        {
            case "a":
                Console.WriteLine($"Encrypted:{Encrypt(text,nr)}");
                break;
            case "b":
                Console.WriteLine($"Decrypted:{Decrypt(text,nr)}");
                break;
            default:
                Console.WriteLine("You need to select an option from a or b");
                break;
        }
    }
    static string Encrypt(string a,int n)
    {
        for (int i = 0; i < a.Length; i++)
        {
            int aux = (int)a[i];
            if (65 <= aux && aux <= 90)
            {
                char var = ' ';
                switch (aux + n > 90)
                {
                    case true:
                        var = (char)(aux + n - 26);
                        break;
                    case false:
                        var = (char)(aux + n);
                        break;
                }
                StringBuilder s = new StringBuilder(a);
                s[i] = var;
                a = s.ToString();
            }
            else
            {
                if (97 <= aux && aux <= 122)
                {
                    char var = ' ';
                    switch (aux + n > 122)
                    {
                        case true:
                            var = (char)(aux + n - 26);
                            break;
                        case false:
                            var = (char)(aux +n);
                            break;
                    }
                    StringBuilder s = new StringBuilder(a);
                    s[i] = var;
                    a = s.ToString();
                }
            }
        }
        return a;
    }
    static string Decrypt(string a,int n)
    {
        for (int i = 0; i < a.Length; i++)
        {
            int aux = (int)a[i];
            if (65 <= aux && aux <= 90)
            {
                char var = ' ';
                switch (aux - n< 65)
                {
                    case true:
                        var = (char)(aux - n + 26);
                        break;
                    case false:
                        var = (char)(aux -n);
                        break;
                }
                StringBuilder s = new StringBuilder(a);
                s[i] = var;
                a = s.ToString();
            }
            else
            {
                if (97 <= aux && aux <= 122)
                {
                    char var = ' ';
                    switch (aux - n < 97)
                    {
                        case true:
                            var = (char)(aux -n + 26);
                            break;
                        case false:
                            var = (char)(aux -n);
                            break;
                    }
                    StringBuilder s = new StringBuilder(a);
                    s[i] = var;
                    a = s.ToString();
                }
            }
        }
        return a;
    }
}