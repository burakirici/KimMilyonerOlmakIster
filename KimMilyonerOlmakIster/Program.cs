int correctAns = 0; // Variables that counts correct answers
Console.WriteLine("Bilgi Yarismasina Hosgeldiniz!"); // First Question and taking answer
Console.WriteLine("Soru 1: C# dilinde, bir sınıfın diğer sınıflar tarafından miras alınmasını engellemek için hangi anahtar kelime kullanılır?");
Console.WriteLine($"A) sealed B) abstract ");
string answer1 = Console.ReadLine().ToLower();
if (answer1 == "a") // Control the answer and counting.
{
    correctAns++;
    Console.WriteLine("Correct Answer!");
}
else if (answer1 == "b")
{
    Console.WriteLine("Wrong Answer! But Don't give up, there are 2 more Questions!");
}
// Second question and taking answer after that controlling the answer
Console.WriteLine("C# dilinde, bir metodun aşırı yüklenmesi (overloading) ne anlama gelir?");
Console.WriteLine(" A) Aynı isimde birden fazla metodun, farklı parametrelerle tanımlanması");
Console.WriteLine(" B) Bir metodun, yalnızca türetilmiş sınıflar tarafından kullanılabilmesi");
string answer2 = Console.ReadLine().ToLower();
if (answer2 == "a")
{
    correctAns++;
    Console.WriteLine("Correct Answer!");

}
else 
{
    Console.WriteLine("Wrong Answer!");
}
if(correctAns < 2)
    {
        Console.WriteLine("Sorry, we have no chance of winning the grand prize.");
        Console.WriteLine($"Number of Correct Answers {correctAns}");
        return;
    }

Console.WriteLine("C# dilinde, bir sınıfın yalnızca bir kez örneklenmesini sağlamak için hangi tasarım deseni kullanılır?");
Console.WriteLine("A) Factory B) Singleton ");
string answer3 = Console.ReadLine().ToLower();
if(answer3 == "b")
{
    correctAns++;
    Console.WriteLine("Correct Answer!");
}
else
{
    Console.WriteLine("Wrong Answer!");
}
// Here we controlling the correct answer numbers and giving message about that
if (correctAns >= 2)
{
    Console.WriteLine("Congratulations, you won the 1 million TL prize!");
}
else 
    { 
    Console.WriteLine("Sorry you didn't win the grand prize"); 
    }
    Console.WriteLine($"Number of your correct answers {correctAns}");