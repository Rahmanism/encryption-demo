// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string key = "sdfwertdfghrthdsfwegdfh5645y7ftr";

Console.WriteLine("Please enter a string to encrypt");
string plainText = Console.ReadLine();
string cipherText = AesOperation.Encrypt(key, plainText);
Console.WriteLine(cipherText);

string decryptedText = AesOperation.Decrypt(key, cipherText);
Console.WriteLine($"decrypted text: {decryptedText}");

Console.ReadKey();
