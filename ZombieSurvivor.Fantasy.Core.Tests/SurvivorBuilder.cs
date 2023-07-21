namespace ZombieSurvivor.Fantasy.Core.Tests;

using NCommons.Monads;

using ZombieSurvivor.Fantasy.Core;

public  class SurvivorBuilder
{
    private string _name;

    public SurvivorBuilder(string name) => _name = name;

    internal static SurvivorBuilder WithName(string name) => new SurvivorBuilder(name);

    public Optional<Survivor> Build() =>  string.IsNullOrEmpty(_name) ? Optional<Survivor>.Empty :  new Optional<Survivor> (new Survivor(_name));
}