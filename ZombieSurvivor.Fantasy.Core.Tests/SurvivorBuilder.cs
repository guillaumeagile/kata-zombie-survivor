namespace ZombieSurvivor.Fantasy.Core.Tests;

using LanguageExt;

using ZombieSurvivor.Fantasy.Core;

public  class SurvivorBuilder
{
    private string _name;

    public SurvivorBuilder(string name) => _name = name;

    internal static SurvivorBuilder WithName(string name) => new SurvivorBuilder(name);

    public Option<Survivor> Build() =>  string.IsNullOrEmpty(_name) ? Option<Survivor>.None :  Option<Survivor>.Some (new Survivor(_name));
}