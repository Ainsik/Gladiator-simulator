﻿namespace Gladiator;
public static class Program
{
    public static void Main()
    {
        var consoleView = new ConsoleView();
        var numberBetween = consoleView.GetNumberBetween(1, 50);

        var factory = new GladiatorFactory();
        factory.DisplayGladiators(numberBetween.Item2);
    }
}