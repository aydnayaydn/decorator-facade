public class DataIndexers
{
    public int[] GetIndexesOfStoredData(string query)
    {
        Console.WriteLine($"{query} can be found at indexes: 1, 5, 8");
        return new[] {1, 5, 8};
    }
}