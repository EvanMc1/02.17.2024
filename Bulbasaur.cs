class Bulbasaur : Pokemon
{ 

    public Bulbasaur(int l):base(l,0.2)
    {

        
    }

    public override string ToString()
    {
        return "A level " + getLevel() + " Bulbasaur";
    }
}

