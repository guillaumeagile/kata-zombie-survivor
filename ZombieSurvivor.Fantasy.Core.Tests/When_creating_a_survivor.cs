namespace ZombieSurvivor.Fantasy.Core.Tests;

public class When_creating_a_survivor
{
    private Survivor Survivor {get;}
    
    public When_creating_a_survivor() =>
        Survivor = new();

    [Fact]
    public void Then_survivor_has_a_non_empty_name()
    {
        Assert.NotEmpty(Survivor.Name);
    }
}
