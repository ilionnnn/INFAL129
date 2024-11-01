if (args.Length <3){
    WriteLine("You must ....");
    WriteLine("dotnet run purple yellow 50");
    return;
}
ForegroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[0], ignoreCase: true);
BackgroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[1], ignoreCase: true);
