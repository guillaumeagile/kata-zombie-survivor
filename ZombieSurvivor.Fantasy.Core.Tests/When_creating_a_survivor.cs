using LanguageExt.UnsafeValueAccess;

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

        newSut.IfSome( x => Assert.Fail("should not be possible to create a survivor with an empty name"));
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
}
