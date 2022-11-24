namespace ImprovedPokemonTypeChart;

public class PokemonData
{
    /// <summary>
    /// list of all pokemon types
    /// </summary>
    public enum PokemonTypes
    {
        Normal, Fighting, Flying, Poison,
        Ground, Rock, Bug, Ghost,
        Steel, Fire, Water, Grass,
        Electric, Psychic, Ice, Dragon,
        Dark, Fairy
    }

    /// <summary>
    /// the first array of all pokemon types
    /// </summary>
    public double[] PrimaryTypeArray = new double[18];

    /// <summary>
    /// the second array of all pokemon types
    /// </summary>
    public double[] SecondaryTypeArray = new double[18];
}
