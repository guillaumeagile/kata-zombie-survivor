using LanguageExt;

namespace ZombieSurvivor.Fantasy.Core;

public record Survivor(string Name) : ISurvivor
{
    public static Option<Survivor> With(string name) =>
        String.IsNullOrEmpty(name) ? Option<Survivor>.None : Option<Survivor>.Some(new Survivor(name));

    public int Wound { get; }

    public ISurvivor Wounded() => this;

    public bool Dead() => throw new NotImplementedException();
}
