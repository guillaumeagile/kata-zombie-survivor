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
        

        // assert
       sut.Should().Be(otherSut);
    }

   [Fact]
    public void SurvivorMustHaveAName()
    {
        var sut = SurvivorBuilder.WithName("").Build();

        //assert
        sut.Should().Be(new InvalidSurvivor());
    }
  
     [Fact]
    public void ValidSurvivorMustNotBeInvalid()
    {
        var sut = SurvivorBuilder.WithName("foo").Build();

        //assert
        sut.Should().NotBe(new InvalidSurvivor());
    }
  
  [Fact]
    public void ValidSurvivorMustNotBeWoundedAtTheBegining()
    {
        var sut = SurvivorBuilder.WithName("foo").Build();

        //assert
        // sut.StateofWounds().Should().Be(Wounds.None);
    }


}
