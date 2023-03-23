using LanguageExt;

namespace ZombieSurvivor.Fantasy.Core;

public record Survivor(string Name)
{
    public static Option<Survivor> With(string name) =>
        String.IsNullOrEmpty(name) ? Option<Survivor>.None : Option<Survivor>.Some(new Survivor(name));

    public int Wound { get; }

    public void Wounded()
    {
        throw new NotImplementedException();
    }

    public bool Dead()
    {
        throw new NotImplementedException();
    }
}
