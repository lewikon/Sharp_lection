string charsWords = "аисв";
int countCharsInWords = 3;
PrintAllWords(charsWords,countCharsInWords,"");

void PrintAllWords(string alphabet, int length, string prefix)
{
if (length == 0)
{
Console.Write(prefix + " ");
}
else
{
for (int i = 0; i < alphabet.Length; i++)
{
PrintAllWords(alphabet,length-1,prefix + alphabet[i]);
}
}
}