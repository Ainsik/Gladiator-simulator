﻿namespace Gladiator.Model.Gladiators;
public class Swordsman : BaseGladiator
{
    protected override double MultiplierHP => StatisticMultiplier.Medium;
    protected override double MultiplierSp => StatisticMultiplier.Medium;
    protected override double MultiplierDex => StatisticMultiplier.Medium;
    public override int LevelUp()
    {
        return Level++;
    }

    public override bool IsDeath()
    {
        if (Hp <= 0)
        {
            Console.WriteLine($"{FullName} die.");
            return true;
        }
        return false;
    }
}
