// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

// C# 1.0 Properties
var fred = new learncsharp.Properties1_0("Fred", 1);
Console.WriteLine(fred.ToString());

// C# 3.0 default constructor with initialize list Properties
var fred3 = new learncsharp.DefaultConstructorProperties3_0
{
    Name = "Fred",
    Age = 3
};
Console.WriteLine(fred3.ToString());

// C# 9.0 init Properties
var fred9 = new learncsharp.InitProperties9_0
{
    Name = "Fred",
    Age = 9
    // Age = 9
};
Console.WriteLine(fred9.ToString());

// C# 11.0 required Properties
var fred11 = new learncsharp.RequiredProperties11_0
{
    Name = "Fred",
    Age = 11
};
// fred11.Age = 10;
Console.WriteLine(fred11.ToString());

namespace learncsharp
{
    // C# 1.0 Properties
    class Properties1_0
    {
        public string Name;
        public int Age;
        public Properties1_0(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"{Name} ({Age})";
        }
    }

    // C# 3.0 default constructor with properties
    class DefaultConstructorProperties3_0
    {
        // 3.1 因為沒有 constructor, 要給 nullable(Warning)
        public string? Name;
        // 3.2 希望增加封閉性, getter、setter, private set
        public int Age { get; /*private*/ set; }
        public override string ToString()
        {
            return $"{Name} ({Age})";
        }
    }

    // C# 9.0 init constructor with properties
    class InitProperties9_0
    {
        public string? Name;
        // 9.1 因為可以不給, 會跑預設值 Age = 0
        public int Age { get; init; }
        public override string ToString()
        {
            return $"{Name} ({Age})";
        }
    }

    // C# 11.0 init constructor with properties
    class RequiredProperties11_0
    {
        // 還可以順便拿掉 ?
        public required string Name { get; init; }
        public required int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} ({Age})";
        }
    }
}  // namespace learncsharp
