string word = GenerateRandomWord();

string hidWord = HideTheWord(word);
Console.WriteLine(hidWord);



int countBall = 0; // баллы 


string[] sektora = ["Б", "П", "Х2", "0", "50", "100", "150", "200", "250", "300","350","400"];
    
while (word != hidWord)
{
    int ball = new Random().Next(1, 10);
    Console.WriteLine("Баллы если угадаешь: " + ball);
    char var = Console.ReadLine()[0];
    if (ball == 6)
    {
        Console.WriteLine("тебе выпал сектор банкрот(((");
        Console.WriteLine("ТЫ БАНКРОТ БРАТИШКА, САЛАМАЛЕКУМ");

        break;
    }

    string tempWord = OpenLetter(word, var, hidWord);




    if (tempWord != hidWord)
    {
        countBall = countBall + ball;
        Console.WriteLine("+" + ball + " баллов");
        Console.WriteLine("текущий балл = " + countBall);
    }

    hidWord = tempWord;
    Console.WriteLine(hidWord);
    Console.WriteLine();

}

if (hidWord == word) // если мы не обонкротились и угадали 
{
    Console.WriteLine("молорик, баллов на твоем счету: " + countBall);
}

static string GenerateRandomWord()
{
    string[] wordsBank = ["дерево", "стол", "агъдау"];
    int index = new Random().Next(0, wordsBank.Length);
    string word = wordsBank[index];

    return word;
}

static string HideTheWord(string word)
{
    string hidWord = "";
    for (int i = 0; i < word.Length; i++) // шифруем слово
    {
        hidWord = hidWord + "*";
    }
    

    return hidWord;
}

static string OpenLetter(string word, char letter, string hidWord)
{
    string tempWord = "";
    for (int i = 0; i < word.Length; i++)
    {

        if (word[i] == letter)
        {
            tempWord = tempWord + word[i];

        }
        else
        {
            tempWord = tempWord + hidWord[i];
        }

        
    }
    return tempWord;
}