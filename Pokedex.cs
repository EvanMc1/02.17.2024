class Pokedex
{
    //MyPokedex List
    List<Pokemon> myPokedex = new List<Pokemon>();

    //Add To Dex Method
    public void addToDex(Pokemon p)
    {
        Pokemon addp = new Pokemon();
    }

    //Override To String Method that returns ONE POKEMON PER LINE
    public override string ToString()
    {
        foreach (Pokemon p in myPokedex)
        {
            Console.WriteLine(p.ToString());
        }
        return myPokedex.ToString();
    }
}

