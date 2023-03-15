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
    public void Then_survivor_canChangeItsName()
    {
        var newSut = Survivor.With("bar");
        newSut.Match(
            Some: survivor => Assert.Equal("bar", survivor.Name),
            None: () => Assert.Fail("failed test")
        );
        // Assert.Equal("bar", newSut.Name);
    }

    [Fact]
    public void Then_survivor_canChangeItsName_butCannotBeEmpty()
    {
        var newSut = Survivor.With("");

        newSut.IfSome( x => Assert.Fail("a name is mandatory"));
    }
}
