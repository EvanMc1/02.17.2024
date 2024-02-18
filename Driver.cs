class Driver
{
    //Spawn Method
    public Pokemon spawn()
    {
        //Random for Generating Level
        Random rnd = new Random();
        Console.WriteLine(rnd.Next(0, 20));
        int level = rnd.Next();

        //Random for Spawning Pokemon
        Random rand = new Random();
        Console.WriteLine(rand.Next(0, 3));
        int spawn = rand.Next();

        if (spawn == 1)
        {
            Pokemon bulbasaur = new Bulbasaur(level);
            Console.WriteLine("You'll encounter " + bulbasaur.ToString());
            return bulbasaur;
        }
        else if (spawn == 2)
        {
            Pokemon charmander = new Charmander(level);
            Console.WriteLine("You'll encounter " + charmander.ToString());
            return charmander;
        }
        else
        {
            Pokemon caterpie = new Caterpie(level);
            Console.WriteLine("You'll encounter " + caterpie.ToString());
            return caterpie;
        }
    }

    //Throw Ball Method
    public void throwBall()
    {

    }

    //Main Method
    public static void Main(string[] args)
    {
        Pokedex myDex = new Pokedex();
        Pokemon b = new Bulbasaur(b.getLevel());
        b.spawn();

    }
}

