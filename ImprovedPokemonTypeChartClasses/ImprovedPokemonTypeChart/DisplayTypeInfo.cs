using System.Transactions;
using static ImprovedPokemonTypeChart.PokemonData;

namespace ImprovedPokemonTypeChart;

public class DisplayTypeInfo
{
    /// <summary>
    /// amount of times a string has been concatinated (for comma seperation)
    /// </summary>
    public int concatCount { get; set; }

    /// <summary>
    /// Types this type is immune to
    /// </summary>
    public string Immunity { get; set; } = "This type is immune to: ";

    /// <summary>
    /// Types this type resists
    /// </summary>
    public string Resistance { get; set; } = "This type resists: ";

    /// <summary>
    /// Types this type is weak to
    /// </summary>
    public string Weakness { get; set; } = "This type is weak to: ";

    /// <summary>
    /// types this type is neutral to
    /// </summary>
    public string Neutrality { get; set; } = "This type takes neutral damage from: ";

    /// <summary>
    /// Amount of types this type is immune to
    /// </summary>
    public int ImmunityCount { get; set; } = 0;

    /// <summary>
    /// Amount of types this type resists
    /// </summary>
    public int ResistanceCount { get; set; } = 0;

    /// <summary>
    /// Method to add the strengths and weaknesses to the category they belong to
    /// </summary>
    public List<string> DisplayInfo(double[] primaryArrayData, double[] secondaryArrayData)
    {
        // loop through all the pokemon types (length of the array)
        // looping throught the primary array, since they are the same length it doesnt matter which one you choose
        for (int i = 0; i < primaryArrayData.Length; i++)
        {
            // to calcualte dual type strenghts and weakenss, we must multiple the output of the primary and secondary array together
            primaryArrayData[i] *= secondaryArrayData[i];

            switch (primaryArrayData[i])
            {
                case 0:
                {
                    Immunity += $" {(PokemonTypes)i}, ";
                    ImmunityCount++;
                    break;
                }
                case 0.25:
                {
                    Resistance += $" {(PokemonTypes)i}, ";
                    ResistanceCount++;
                    break;
                }
                case 0.5:
                {
                    Resistance += $" {(PokemonTypes)i}, ";
                    ResistanceCount++;
                    break;
                }  
                case 1:
                {
                    Neutrality += $" {(PokemonTypes)i}, ";
                    break;
                }
                case 2:
                {
                    Weakness += $" {(PokemonTypes)i}, ";
                    break;
                }
                case 4:
                {
                    Weakness += $" {(PokemonTypes)i}(4x Weakness), ";
                    break;
                }
                default:
                    break;
            }
        }
        // trimming the comma off the end of the strings
        Immunity = Immunity.Substring(0, Immunity.Length - 2);
        Resistance = Resistance.Substring(0, Resistance.Length - 2);
        Neutrality = Neutrality.Substring(0, Neutrality.Length - 2);
        Weakness = Weakness.Substring(0, Weakness.Length - 2);

        if (ImmunityCount == 0)
        {
            Immunity += " None";
        }

        if (ResistanceCount == 0)
        {
            Resistance += " None";
        }

        // create a list of string to return for the textbox output
        List<string> list = new List<string>
        {
            $"{Immunity}\n",
            $"{Resistance}\n",
            $"{Neutrality}\n",
            $"{Weakness}"
        };

        return list;
        
        // OLD IMPLEMENTATION using a giant concatinated string - return $"{Immunity}\n{Resistance}\n{Neutrality}\n{Weakness}";
    }
}
