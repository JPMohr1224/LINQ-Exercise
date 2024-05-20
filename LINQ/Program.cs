namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Alice", "Bob", "Charlie", "Danny", "Edward", "Franklin", "Greg", "Hampton" };
            IEnumerable<string> namesByLength = names.OrderBy(name => name.Length);
            foreach( string name in namesByLength)
            Console.WriteLine(name);
        }

        
    }
}
