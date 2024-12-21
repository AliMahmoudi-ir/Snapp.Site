namespace Snapp.Core.Generators
{
    public static class CodeGenerators
    {
        static Random random = new Random();
        public static string GetActiveCode()
        {
            return random.Next(100000, 990000).ToString();
        }

        public static Guid GetId()
        {
            return Guid.NewGuid();
        }

        public static string GetFileName()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }

        public static string GetOrderCode()
        {
            return random.Next(1000000, 9900000).ToString();
        }
    }
}
