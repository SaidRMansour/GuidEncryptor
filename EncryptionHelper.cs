using System;
using System.Security.Cryptography;
using System.Text;
using System.Linq;

public static class EncryptionHelper
{
    // Example of a fixed salt. In a real system, consider making it user-specific or per-use.
    private const string Salt = "a8104f14209704cf8761a877c27a87e88dcbbb83699a5e6b681df5345324b0aa";

    public static string EncryptUserGuid(string userGuid)
    {
        using var sha256 = SHA256.Create();
        var combinedValue = $"{userGuid}{Salt}";
        var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(combinedValue));

        // Return first 16 bytes as a new GUID string
        return new Guid(hashedBytes.Take(16).ToArray()).ToString();
    }
}
