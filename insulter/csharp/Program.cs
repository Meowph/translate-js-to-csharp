    using System;

    namespace Insult 
    {
    class Program
    {
      static void Insulter()
    {

    string[] insults = {
      "You look like what morning breath smells like.",
      "If you tried to give me cpr I would probably throw myself back under water",
      "I am not a fan of you",
      "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
      "I'd rather walk than be on the same plane as you",
      "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
      "Do you have to be so...like that?"
    };

    // This code ensures we don't end up with duplicate insults
    string indexes = "";
    Random rand = new Random(); // Random is used to generate random numbers (int).

    while (indexes.Length < 3) {
      int candidate = rand.Next(0, insults.Length); //generates a random integer within the coded range
        char candidateChar = (char)('0' + candidate);  //candidate is converted to a char by adding it to '0' ... this converts small integers to their corresponding char rep ('0'-'9')... LOOK UP ASCII for more info!

      if (!indexes.Contains(candidateChar)) {
          indexes += candidateChar;  // Appending the char to the string
      }
    }


    for (int i=0; i<indexes.Length; i++) 
    {
      int index = indexes[i] - '0'; //this converts char back into an integer 
        Console.Write(insults[index]);
    }
    Console.WriteLine(getRandomInt(1, 10));

    }

    // Remember getting a random integer in C# is different
    static int getRandomInt( int min, int max) { //the params here must be specified! INT for min and max
    Random rand = new Random(); //Math.Random() does not exist in C#, so Random must be used
    return rand.Next(min, max + 1); //Math.Ceiling returns double values, but integers are needed for min and max, so Next is used (Next() = Returns a non-negative random integer)
    }
    }
    }
    
