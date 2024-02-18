class Charmander : Pokemon
{
    public Charmander(int l) : base (l, 0.2)
    {

    }

    public override string ToString()
    {
        return "A string " + getLevel() + " Charmander";
    }
}
