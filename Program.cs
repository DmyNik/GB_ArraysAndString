
// Тема: Массивыи строки.
// --- Начало программы ----------------/\---/\------------------------------------------------
// --------------------------------------*---*-------------------------------------------------
// ---------------------------------------\*/--------------------------------------------------


static string deleteAllSpaceInString(string str) // Удаление всех пробелов из строки
{
    string result  = "";
    
    for ( int i = 0; i < str.Length; i++ )
    {
        if ( !str[i].Equals(' ') )
        {
            result += str[i];
        }         
    }

    return result;

}

static string collapseSpaceInString(string str) // Сжатие лишних пробелов в строке
{
    int strLng = str.Length; 
    
    string result  = "";
    
    if ( strLng > 0 )
    {
        if ( !(str[0].Equals(' ')) ) { result += str[0]; }

        for ( int i = 1; i < strLng; i++ )
        {
            if ( !(str[i-1].Equals(' ') && str[i].Equals(' ')) )
            {
                result += str[i];
            }  

        }

    }
    
    return result;

}

static string stringThisOnlyLatterAndSpace(string str) // Формирует строку только с буквами, пробелами и апострофом
{
    string lettersAndSpace = " 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

    string strNew = "";

    for ( int i = 0; i < str.Length; i++ ) 
    {
        
        foreach ( char latter in lettersAndSpace )
        {
            if ( str[i] == latter )
            {
                strNew += str[i];
                break;
            }
        }

    }   

    return strNew;

}

static string reversString(string str) // Разворот строки
{
    string result  = "";
    
    for ( int i = str.Length - 1; i >= 0 ; i-- )
    {
        if ( !str[i].Equals(' ') )
        {
            result += str[i];
        }         
    }

    return result;
    
}

// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

Console.WriteLine("\n> Задача 1.\n");

char[,] halloWorld = new char[,] {
    {'П', 'р', 'и', 'в', 'е', 'т'},
    {',', ' ', 'М', 'и', 'р', '!'}
};

string str = "";

foreach (var latter in halloWorld) 
{
    str+=latter;
}

Console.WriteLine("> " + str);

// Задача 2: Задайте строку, содержащую латинские буквы в 
// обоих регистрах. Сформируйте строку, в которой все заглавные
// буквы заменены на строчные.

Console.WriteLine("\n> Задача 2.\n");

string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string lower = "abcdefghijklmnopqrstuvwxyz";

str = "Hello, World!";
string strNew = "";

bool flag;
int counter;

for ( int i = 0; i < str.Length; i++ ) 
{
    flag = false;
    
    foreach ( char latter in upper )
    {
        if ( str[i] == latter )
        {
            flag = true;
            break;
        }
    }

    if ( flag ) 
    { 
        counter = -1;

        foreach ( char latter in upper )
        {     
            counter++;
            if ( str[i] == latter ) { break; }
        }
        
        strNew += lower[counter];
        
    } 
    else 
    {        
        strNew += str[i];
    }

}

Console.WriteLine("> " + strNew);

// Задача 3: Задайте произвольную строку. 
// Выясните, является ли она палиндромом.

Console.WriteLine("\n> Задача 3.\n");

string palindrom = "А роза упала на лапу Азора";

palindrom = deleteAllSpaceInString(palindrom);
palindrom = palindrom.ToLower();

string newPalindrom = reversString(palindrom);

if ( palindrom.Equals(newPalindrom) ) 
{
    Console.WriteLine("> Эта строка - палиндром!");
} 
else 
{
    Console.WriteLine("> Эта строка не палиндром!");
}

// Задача 4*(не обязательная): Задайте строку, состоящую из слов, 
// разделенных пробелами. Сформировать строку, в которой слова 
// расположены в обратном порядке. В полученной строке слова 
// должны быть также разделены пробелами.

Console.WriteLine("\n> Задача 4.\n");

string stringThisSpace = "    I'm #floating away   %and time&&&     is %   carrying me from edge to edge.";

stringThisSpace = stringThisOnlyLatterAndSpace(stringThisSpace);

stringThisSpace = collapseSpaceInString(stringThisSpace);

string[] arrayThisSpaceRevers = stringThisSpace.Split(' ');

string stringThisSpaceRevers = "";

for ( int i = 0; i < arrayThisSpaceRevers.Length; i++ ) 
{
    stringThisSpaceRevers += arrayThisSpaceRevers[arrayThisSpaceRevers.Length - i - 1];

    if ( i < arrayThisSpaceRevers.Length - 1 ) { stringThisSpaceRevers += ' '; }
}

Console.WriteLine("> " + stringThisSpaceRevers + "\n");

