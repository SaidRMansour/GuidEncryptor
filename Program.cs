using System;
using System.Security.Cryptography;
using System.Text;


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a GUID: ");
        string userGuid = Console.ReadLine();

        if (Guid.TryParse(userGuid, out _))
        {
            string encryptedGuid = EncryptionHelper.EncryptUserGuid(userGuid);
            Console.WriteLine($"Encrypted GUID: {encryptedGuid}");
        }
        else
        {
            Console.WriteLine("Invalid GUID. Please try again.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

