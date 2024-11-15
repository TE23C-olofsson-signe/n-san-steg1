
// hello world  uppgiften. 
// if (6 > 3)
// {
//     Console.WriteLine("Hello World");
// }

// Console.ReadLine(); 

// andvändarnamn .
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

//  användarnamn+lösenord. 
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

// while loop som går tills Hello world har skrivits 32 gånger.  
// int gånger = 0;
// while(gånger<32) {
//     Console.WriteLine("Hello world");
//     gånger++;
// } 

// Console.ReadLine();

// While loop som går tills lösenordet är rätt.
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

// for loop som frågar användaren skriva ett tal fem gånger sen om talet är mer än 5 skriver högre än fem. 
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

// while loop går tills man skriver en string i loopen. 
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

// Gissa Talet. 
// int gissatalet = 0; 
// int rätttal= 50; 
// while( gissatalet != rätttal )
// {
//     Console.WriteLine("Gissa rätt tal");
//     string vilkettal=Console.ReadLine(); 
//     int.TryParse(vilkettal,out gissatalet);

//     if(gissatalet !=rätttal)
//     {
//         Console.WriteLine("Fel försök igen"); 
//     }
// }

// Console.ReadLine(); 