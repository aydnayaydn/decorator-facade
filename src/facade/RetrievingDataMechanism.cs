public class RetrievingDataMechanism
    {
        public void GetData(int[] indexes)
        {
            Console.Write("Downloading web pages with indexes: ");
            foreach (var index in indexes)
            {
                Console.Write(index + ", ");
            }

            Console.WriteLine();
        }
    }