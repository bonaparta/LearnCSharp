// See https://aka.ms/new-console-template for more information

namespace learncsharp
{
    class ConsoleApp1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // I
            //  "love"
            //  you!

            // C# 1.0 Regular string literals
            string regular1_0 = "I\n \"love\"\n\tyou!";
            Console.WriteLine(regular1_0);
            // C# 1.0 Verbatim string literals
            // 你可以直接在字串中加入「斷行符號」且不需要用 \r\n 跳脫字元，但雙引號要改用 "" 才行！
            string verbatim1_0 = @"I
 ""love""
	you!";
            Console.WriteLine("{0}", verbatim1_0);

            // C# 6.0 Interpolated Strings
            // 透過 $"..." 可以做到「字串內插」的表達方式，字串中的 {name} 可以用來插入其他變數！
            string interpolated6_0 = $"I\n \"love\"\n\tyou!";
            Console.WriteLine($"{interpolated6_0}"); // {interpolated6_0} < 這個用法

            // C# 8.0 Interpolated Verbatim Strings
            // 你可以使用 @$"..." 或 $@"..." 語法，混合 Verbatim string literals 與 Interpolated Strings 的表達方式！
            string interpolatedVerbatim8_0 = $@"I
 ""love""
	you!";
            Console.WriteLine(@$"{interpolatedVerbatim8_0}"); // $@ == @$

            // C# 10.0 Constant interpolated strings
            // 你可以將字串設定為 const (常數) 時，也同時使用 $ 字串內插的表達方式！
            const string constInterpolated6_0 = "I\n \"love\"\n\tyou!";
            Console.WriteLine($"{constInterpolated6_0}");

            // C# 11.0 Row string literal
            // 終於可以在 C# 寫雙引號不用寫成 \" 或 "" 的樣子了，這樣蠻好的！
            string row6_0 = """
                I
                 "love"
                	you!
                """;
            Console.WriteLine($"{row6_0}");
        }
    }
}  // namespace learncsharp
