string[] words = {"мороз", "и", "солнце", "день", "чудесный"};

string[] goal = new string[wordSum(words)];

int count = 0;

foreach (string e in words)
{
    int letterSum = 0;
    foreach (char i in e)
    {
    letterSum++;
    }
    if (letterSum <= 3)
    {
        goal[count] = e;
        count++;
    }
}
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