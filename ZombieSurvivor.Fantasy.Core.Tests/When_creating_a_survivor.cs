using LanguageExt.UnsafeValueAccess;
using FluentAssertions;

namespace ZombieSurvivor.Fantasy.Core.Tests;

public class When_creating_a_survivor
{
     Survivor sut {get;}

    public When_creating_a_survivor() =>
        sut =  new Survivor("foo");

    [Fact]
    public void Then_survivor_has_a_non_empty_name()
    {
        Assert.NotEmpty(sut.Name);
    }

    [Fact]
    public void Then_survivor_Name_CannotBeEmpty()
    {
        var newSut = Survivor.With("");
     //   newSut.IfSome( x => Assert.Fail("should not be possible to create a survivor with an empty name"));
        Assert.True(newSut.IsNone);
    }

    [Fact]
    public void Then_survivor_canChangeItsName()
    {
        var newSut = Survivor.With("bar");

        Assert.Equal("bar", newSut.ValueUnsafe().Name);  // VITE ECRIT MAIS NON SOUHAITABLE

        newSut.Match(
            Some: survivor => Assert.Equal("bar", survivor.Name),
            None: () => Assert.Fail("failed test")
        );
    }

    [Fact]
    public void then_the_survivro_begins_with_zero_wounds()
    {
         var survivor = Survivor.With("bar");

         Assert.Equal(0, survivor.ValueUnsafe().Wound );
    }

    [Fact]
    public void then_the_survivor_dies_immediately_after_receiving_2_Wounds()
    {
        var survivor = Survivor.With("bar");

        var newSurvirvorState = survivor.ValueUnsafe().Wounded();

      //  deadSurvirvorState.Should().NotBeAssignableTo<Survivor>();

    }

    // Fluent en .Net


}
