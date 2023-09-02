// See https://aka.ms/new-console-template for more information

namespace learncsharp
{
    class MyClass
    {
        private string ValueA { get; set; }
        public string ValueB { get; private set; }
        public MyClass(string valueA, string valueB)
        {
            ValueA = valueA;
            ValueB = valueB;
        }

        public void Deconstruct(out string valueA, out string valueB)
        {
            valueA = ValueA;
            valueB = ValueB;
        }
    }

    class ConsoleApp1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var instance = new MyClass("Yo~~", "Man~~~");
            var (one, two) = instance;

            Console.WriteLine("{0} {1}", one, two);

            // MSDN 推薦的使用場景，快速取得 (Key, Value)
            Dictionary<string, int> snapshotCommitMap = new(StringComparer.OrdinalIgnoreCase)
            {
                ["https://github.com/dotnet/docs"] = 16_465,
                ["https://github.com/dotnet/runtime"] = 114_223,
                ["https://github.com/dotnet/installer"] = 22_436,
                ["https://github.com/dotnet/roslyn"] = 79_484,
                ["https://github.com/dotnet/aspnetcore"] = 48_386
            };

            foreach (var (repo, commitCount) in snapshotCommitMap)
            {
                Console.WriteLine(
                    $"The {repo} repository had {commitCount:N0} commits as of November 10th, 2021.");
            }
        }
    }
}  // namespace learncsharp
