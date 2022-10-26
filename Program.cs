bool playAgain = true;
bool validResponse = true;
string UAnswer;
while(playAgain == true) 
{
// start
string name1;
Console.WriteLine("What is your name?!");
name1 = Console.ReadLine();
Console.WriteLine($"Hello {name1}");
// end
validResponse = true;
while(validResponse == true) 
    {
        Console.Write("Do you want to play again? (Y/N): "); 
        UAnswer = Console.ReadLine().ToUpper();
        if (UAnswer == "Y")
        {
            playAgain = true;
            validResponse = false; 
        }
        else if (UAnswer == "N") 
        {
            playAgain = false; 
            validResponse = false; 
        }
        else 
        {
            validResponse = true; 
            playAgain = false; 
            Console.WriteLine(UAnswer + " is not a valid response. Enter a response again");
        }
    }
Console.WriteLine("Thank you for playing!"); 
}

