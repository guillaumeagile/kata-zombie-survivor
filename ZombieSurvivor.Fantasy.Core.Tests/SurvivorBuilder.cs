namespace ZombieSurvivor.Fantasy.Core.Tests;
using ZombieSurvivor.Fantasy.Core;

public  class SurvivorBuilder
{
    private string _name;

    public SurvivorBuilder(string name) => _name = name;

    internal static SurvivorBuilder WithName(string name) => new SurvivorBuilder(name);

    public ISurvivor Build() =>  string.IsNullOrEmpty(_name) ? new InvalidSurvivor() :  new Survivor(_name);
}