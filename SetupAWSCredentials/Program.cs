using AWSLibrary;

Console.Write("Enter the Profile Name: ");
string? profileName = Console.ReadLine();

Console.Write("Enter the AccesKeyID: ");
string? keyId = Console.ReadLine();

Console.Write("Enter the Secret AccesKey: ");
string? secret = Console.ReadLine();

CreateProfile.WriteProfile(profileName, keyId, secret);
Console.ReadLine();