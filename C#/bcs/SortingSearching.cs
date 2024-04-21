class SortingSearching
{
    public SortingSearching()
    {
        var names = new List<string>() { "Scott", "Ana", "Pelib" };
        names.Sort();
        foreach (var name in names)
        {
            System.Console.WriteLine(name);

        }

    }
}