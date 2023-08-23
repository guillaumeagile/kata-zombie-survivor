
using LanguageExt;

namespace ZombieSurvivor.Fantasy.Core.Tests;
public class SurvivorBuilder
{

    private readonly string _name;

    public SurvivorBuilder(string name) => _name = name;

    internal static SurvivorBuilder WithName(string name) => new(name);

    public Option<Survivor> Build() =>  string.IsNullOrEmpty(_name) ? Option<Survivor>.None :  Option<Survivor>.Some (new Survivor(_name));
}