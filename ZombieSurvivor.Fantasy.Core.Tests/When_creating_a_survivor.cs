using LanguageExt.UnsafeValueAccess;
using FluentAssertions;
using ZombieSurvivor.Fantasy.Core;

namespace ZombieSurvivor.Fantasy.Core.Tests;

public class When_creating_a_survivor
{


    [Fact]
    public void TwoSurvivorsOfSameNameAreEquals()
    {
        // arrange
        var sut = SurvivorBuilder.WithName("foo").Build();
        //new Survivor("foo");
        var otherSut = SurvivorBuilder.WithName("foo").Build();

        // naive monad use
        sut.IfSome(v => otherSut.IfSome(w => v.Should().Be(w)));
    }

    [Fact]
    public void MakeGoodUseOfTheMonad()
    {
        // arrange
        var sut = SurvivorBuilder.WithName("ok").Build();
        var otherSut = SurvivorBuilder.WithName("ok").Build();

        // better monad use
        sut.Match(
            Some: v =>
            {
                otherSut.Match(
                Some: w => w.Should().Be(v),
                None: () => throw new Exception("2nd survivor name should not be empty")
            );
            },
            None: () => throw new Exception("first survivor name should not be empty")
        );
    }

    [Fact]
    public void SurvivorMustHaveAName()
    {
        var sut = SurvivorBuilder.WithName("").Build();

        //assert
        sut.IsNone.Should().Be(true);

        // assert with match
        sut.Match(
                  v => throw new Exception(),
                  () => true.Should().BeTrue()
              );
    }

    [Fact]
    public void ValidSurvivorMustNotBeInvalid()
    {
        var sut = SurvivorBuilder.WithName("foo").Build();

        //assert
        sut.Match(
                   v => v.name.Should().Be("foo"),
                   () => throw new Exception()
               );
    }

    [Fact]
    public void ValidSurvivorMustNotBeWoundedAtTheBegining()
    {
        var sut = SurvivorBuilder.WithName("foo").Build();

        //assert
        // sut.StateofWounds().Should().Be(Wounds.None);
    }


}
