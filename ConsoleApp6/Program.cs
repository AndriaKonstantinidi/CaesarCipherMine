static string Encrypt(string input, int key)
{
    string encrypted = string.Empty;
        for(int i = 0; i < input.Length; i++) {

        if (input[i] == ' ')
            encrypted += " ";
        else
            encrypted += (char)((int)input[i] + key);
    }
        return encrypted;
}


Console.WriteLine(Encrypt("abc cde", 2));

static string Decrypt(string input, int key)
{
    string decrypted = string.Empty;
    for(int i = 0; i < input.Length; i++){
        if(input[i] == ' ')
            decrypted += " ";
           else 
                decrypted += (char)((int)input[i] - key);
        }
    return decrypted;
}
string enc = Encrypt("abc cde", 2);

Console.WriteLine(Decrypt(enc,2));