string[] words = {"мороз", "и", "солнце", "день", "чудесный"};

int wordSum(string[] words)
{
    int wordSum = 0;
    foreach (string e in words)
    {
        string word = e;
        int letterSum = 0;
        foreach (char i in word)
        {
            letterSum++;
        }
        if (letterSum <= 3)
        {
            wordSum++;
        }
    }
    return wordSum;
}

string[] goal = new string[wordSum(words)];

for (int i = 0; i < goal.Length; i++)
{

}

string word(string[] words)
{
    for (int i = 0; i < words.Length; i++)
    {
        string word = i;
        int sum = 0;
        foreach (char e in word)
        {
            sum++;
        }
        if (sum <= 3)
        {
            return word;
        }
        continue ;
    }
}