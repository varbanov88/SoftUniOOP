using NUnit.Framework;
using System;

[TestFixture]
public class AxeTests
{
    [Test]
    public void AxeLosesDurabilityAfterAttack()
    {
        //Arange
        Axe axe = new Axe(10, 10);
        Dummy dummy = new Dummy(10, 10);

        //Act
        axe.Attack(dummy);

        //Assert
        Assert.AreEqual(9, axe.DurabilityPoints);
    }

    [Test]
    public void AttackWithBrokenAxe()
    {
        //Arange
        Axe axe = new Axe(1, 1);
        Dummy dummy = new Dummy(20, 20);

        //Act
        axe.Attack(dummy);

        //Assert
        var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        Assert.AreEqual("Axe is broken.", ex.Message);
    }
}

