using Amazon.Runtime.CredentialManagement;

namespace AWSLibrary;

public class CreateProfile
{
    public static void WriteProfile(string profileName, string keyId, string secret)
    {
        Console.WriteLine($"Creating the [{profileName}] profile...!!");
        var options = new CredentialProfileOptions
        {
            AccessKey = keyId,
            SecretKey = secret
        };
        var profile = new CredentialProfile(profileName, options);
        var sharedFile = new SharedCredentialsFile();
        sharedFile.RegisterProfile(profile);
        Console.WriteLine($"Profile [{profileName}] has now been created");
        Console.ReadLine();
    }
}
