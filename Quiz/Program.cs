int points = 0;

Console.WriteLine("Hej välkommen till Kerems Harry Potter-frågesport!");
Console.WriteLine(" 1: Vem var det som dödade dumbledore?");
Console.WriteLine(" a) Snape  b) Lord Voldemord  c) Draco Malfoy  d) Harry Potter "); 
 
 string answer1 = Console.ReadLine();
  if (answer1 == "a")
  
  
  {
    points++;
    Console.WriteLine("CORRECT");
  }

  else
  {
    Console.WriteLine(" INCORRECT");
  }

Console.WriteLine("Var träffas Harry Potter och Ron Weasley för första gången?");
Console.WriteLine(" a) I en buss  b) I Hogwarts  c) I Tåget  d) I Diagongränd ");

string answer2 = Console.ReadLine(); 

if (answer2 == "c")

{
    points++;
    Console.WriteLine("CORRECT");
    
}

else
{
 Console.WriteLine("INCORRECT");
}

Console.WriteLine("Vem var det som dödade lord voldemord?");
Console.WriteLine(" a) Dumbledour  b) Harry Potter  c) Sirius Black  d)  Hagrid");

string answer3 = Console.ReadLine();
 if (answer3 == "b")

{
points++;
Console.WriteLine("CORRECT");

}

else

{
Console.WriteLine("INCORRECT");
}

Console.WriteLine($"Du fick { points } poäng.");
if (points == 0 )
{
Console.WriteLine( " du är sämst");

}

else if ( points  > 3)

{
 Console.WriteLine(" du har koll på Harry potter filmerna/böckerna");

}
//
else 
{
    Console.WriteLine(" GRATTIS du van");
}
 
 Console.WriteLine(" tryck på valfri knap för att avsluta spelet");
Console.ReadKey();

