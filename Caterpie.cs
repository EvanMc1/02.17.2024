class Caterpie : Pokemon
{
    public Caterpie(int l) : base (l, 0.5)
    {

    }

    public override string ToString()
    {
        return "A level " + getLevel() + " Caterpie";
    }
}

