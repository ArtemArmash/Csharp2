
Console.WriteLine("Enter word:");
string inputString = Console.ReadLine();

Console.WriteLine("Enter number:");
int key = Convert.ToInt32(Console.ReadLine());

string encryptedString = EncryptCaesar(inputString, key);

Console.WriteLine($"New word: {encryptedString}");
static string EncryptCaesar(string input, int key)
{
    char[] result = input.ToCharArray();

    for (int i = 0; i < result.Length; i++)
    {
        if (char.IsLetter(result[i]))
        {
            char offset = char.IsUpper(result[i]) ? 'A' : 'a';
            result[i] = (char)((result[i] + key - offset) % 26 + offset);
        }
    }

    return new string(result);
}