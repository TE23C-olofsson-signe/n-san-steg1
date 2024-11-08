

using System.ComponentModel.DataAnnotations;

if (6 > 3)
{
    Console.WriteLine("Hello World");
}

// Console.ReadLine(); 

// Console.WriteLine("Skriv rätt användarnamn");
// string noname; 

// noname= Console.ReadLine();
// string användarnamn = "kalleanka"; 

// if(användarnamn == noname){
//     Console.WriteLine("Välkomen"); 
// }
// else{
//     Console.WriteLine("fel försök igen."); 
// }

// Console.ReadLine();

// string användarnamn = "kalleanka"; 
// string noname; 

// Console.WriteLine("Hej skriv rätt användarnamn");
// noname=Console.ReadLine(); 

// if(användarnamn == noname){
//     Console.WriteLine("Välkommen. Skriv rätt lösenord"); 
// }
// else{
//     Console.WriteLine("Fel. Försök igen.");
//  }

// string lösenord = "12345"; 
// string password;
// password = Console.ReadLine(); 

// if(lösenord== password) {
//     Console.WriteLine("Du kom in "); 
// }
// else{
//     Console.WriteLine("Fel skriv igen "); 
// }
// Console.ReadLine();

// int gånger = 0;
// while(gånger<32) {
//     Console.WriteLine("Hello world");
//     gånger++;
// } 

// for(int gånger=0; gånger<32; gånger++ ){
//      Console.WriteLine("Hello world");
// }

// Console.ReadLine();

// string password = "";
// while (password != "12345")
// {
// Console.WriteLine("Välkommen skriv in rätt lösenord");
//     password = Console.ReadLine();
//     if(password != "12345"){
//         Console.WriteLine("Fel försök igen"); 
//     }
// }
// Console.ReadLine();



// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine("skriv ett tal:");
//     int tal = 0;
//     string il = Console.ReadLine();

//     int.TryParse(il, out tal);

//     if (tal > 5)
//     {
//         Console.WriteLine("Högre än 5!");
//     }
// }

// Console.ReadLine();

// string test = Console.ReadLine();
// int test_tal = int.Parse(test);

// bool är_tal = false;
// string inmatning = "";

// while (är_tal == false)
// {
//     Console.Write("skriv ett tal: ");
//     inmatning = Console.ReadLine();

//     är_tal = inmatning.All(char.IsDigit);    
// }
// Console.WriteLine($"{inmatning}");

// int tal = int.Parse(inmatning); 

// Console.ReadLine();

// bool success = false;
// string input;
// int number = 0;  
// while(success == false) {
//     Console.Write("skriv ett tal: ");
//     input= Console.ReadLine();
//     success = int.TryParse(input, out number);

// }
// Console.WriteLine($"Talet är {number}");

// Console.ReadLine();



// // Experiment
// string korrekt_användarnamn = "kalleanka";
// string inmatat_anv_namn;
// bool done = false;


// while (!done)
// {
//     Console.WriteLine("Hej skriv rätt användarnamn");
//     inmatat_anv_namn = Console.ReadLine();

//     if (korrekt_användarnamn == inmatat_anv_namn)
//     {
//         Console.WriteLine("Välkommen. Skriv rätt lösenord");
//         done = true;
//     }
//     else
//     {
//         Console.WriteLine("Fel. Tryck return för att avsluta");
//     }
// }

// done = false;

// const string lösenord = "12345";
// while (! done)
// {
//     string password;
//     password = Console.ReadLine();

//     if (lösenord == password)
//     {
//         Console.WriteLine("Du kom in ");
//         done = true;
//     }
//     else
//     {
//         Console.WriteLine("Fel! Försök igen!");
//     }
// }

// Console.ReadLine();
