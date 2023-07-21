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
       sut.GetValueOrDefault().Should().Be(otherSut.GetValueOrDefault());
    }

   [Fact]
    public void SurvivorMustHaveAName()
    {
        var sut = SurvivorBuilder.WithName("").Build();

        //assert
        sut.HasValue.Should().Be(false);

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
                    v => v.Should().Be( SurvivorBuilder.WithName("foo").Build().GetValueOrDefault()) ,
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
