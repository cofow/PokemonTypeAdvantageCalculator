using static ImprovedPokemonTypeChart.PokemonData; // allows us to do PokemonTypes instead of PokemonData.PokemonTypes

namespace ImprovedPokemonTypeChart;

public class TypeCalculations
{
    public double[] PopulateArray(double[] arrData)
    {
        // set all values to 1 (neutral)
        for (int i = 0; i < arrData.Length; i++)
        {
            arrData[i] = 1;
        }

        return arrData;
    }

    public double[] GetStrengthsAndWeaknesses(double[] rawArrayData, string textBoxData)
    {
        // set all values to 1
        double[] populatedArray = PopulateArray(rawArrayData);

        // assign type strenghts and weaknesses
        foreach (var type in Enum.GetValues<PokemonData.PokemonTypes>())
        {
            if (type.ToString() == textBoxData)
            {
                switch (type)
                {
                    case PokemonTypes.Normal:
                    {
                        populatedArray[(int)PokemonTypes.Fighting] = 2;
                        populatedArray[(int)PokemonTypes.Ghost] = 0;
                        break;
                    }
                    case PokemonTypes.Fighting:
                    {
                        populatedArray[(int)PokemonTypes.Psychic] = 2;
                        populatedArray[(int)PokemonTypes.Flying] = 2;
                        populatedArray[(int)PokemonTypes.Fairy] = 2;
                        populatedArray[(int)PokemonTypes.Bug] = 0.5;
                        populatedArray[(int)PokemonTypes.Rock] = 0.5;
                        populatedArray[(int)PokemonTypes.Dark] = 0.5;
                        break;
                    }
                    case PokemonTypes.Flying:
                    {
                        populatedArray[(int)PokemonTypes.Electric] = 2;
                        populatedArray[(int)PokemonTypes.Ice] = 2;
                        populatedArray[(int)PokemonTypes.Rock] = 2;
                        populatedArray[(int)PokemonTypes.Grass] = 0.5;
                        populatedArray[(int)PokemonTypes.Fighting] = 0.5;
                        populatedArray[(int)PokemonTypes.Bug] = 0.5;
                        populatedArray[(int)PokemonTypes.Ground] = 0;
                        break;
                    }
                    case PokemonTypes.Poison:
                    {
                        populatedArray[(int)PokemonTypes.Ground] = 2;
                        populatedArray[(int)PokemonTypes.Psychic] = 2;
                        populatedArray[(int)PokemonTypes.Grass] = 0.5;
                        populatedArray[(int)PokemonTypes.Fighting] = 0.5;
                        populatedArray[(int)PokemonTypes.Poison] = 0.5;
                        populatedArray[(int)PokemonTypes.Bug] = 0.5;
                        populatedArray[(int)PokemonTypes.Fairy] = 0.5;
                        break;
                    }
                    case PokemonTypes.Ground:
                    {
                        populatedArray[(int)PokemonTypes.Water] = 2;
                        populatedArray[(int)PokemonTypes.Grass] = 2;
                        populatedArray[(int)PokemonTypes.Ice] = 2;
                        populatedArray[(int)PokemonTypes.Poison] = 0.5;
                        populatedArray[(int)PokemonTypes.Rock] = 0.5;
                        populatedArray[(int)PokemonTypes.Electric] = 0;
                        break;
                    }
                    case PokemonTypes.Rock:
                    {
                        populatedArray[(int)PokemonTypes.Water] = 2;
                        populatedArray[(int)PokemonTypes.Grass] = 2;
                        populatedArray[(int)PokemonTypes.Fighting] = 2;
                        populatedArray[(int)PokemonTypes.Ground] = 2;
                        populatedArray[(int)PokemonTypes.Steel] = 2;
                        populatedArray[(int)PokemonTypes.Normal] = 0.5;
                        populatedArray[(int)PokemonTypes.Fire] = 0.5;
                        populatedArray[(int)PokemonTypes.Poison] = 0.5;
                        populatedArray[(int)PokemonTypes.Flying] = 0.5;
                        break;
                    }
                    case PokemonTypes.Bug:
                    {
                        populatedArray[(int)PokemonTypes.Fire] = 2;
                        populatedArray[(int)PokemonTypes.Flying] = 2;
                        populatedArray[(int)PokemonTypes.Rock] = 2;
                        populatedArray[(int)PokemonTypes.Grass] = 0.5;
                        populatedArray[(int)PokemonTypes.Fighting] = 0.5;
                        populatedArray[(int)PokemonTypes.Ground] = 0.5;
                        break;
                    }
                    case PokemonTypes.Ghost:
                    {
                        populatedArray[(int)PokemonTypes.Dark] = 2;
                        populatedArray[(int)PokemonTypes.Ghost] = 2;
                        populatedArray[(int)PokemonTypes.Poison] = 0.5;
                        populatedArray[(int)PokemonTypes.Bug] = 0.5;
                        populatedArray[(int)PokemonTypes.Fighting] = 0;
                        populatedArray[(int)PokemonTypes.Normal] = 0;
                        break;
                    }
                    case PokemonTypes.Steel:
                    {
                        populatedArray[(int)PokemonTypes.Fire] = 2;
                        populatedArray[(int)PokemonTypes.Fighting] = 2;
                        populatedArray[(int)PokemonTypes.Ground] = 2;
                        populatedArray[(int)PokemonTypes.Normal] = 0.5;
                        populatedArray[(int)PokemonTypes.Grass] = 0.5;
                        populatedArray[(int)PokemonTypes.Ice] = 0.5;
                        populatedArray[(int)PokemonTypes.Flying] = 0.5;
                        populatedArray[(int)PokemonTypes.Psychic] = 0.5;
                        populatedArray[(int)PokemonTypes.Bug] = 0.5;
                        populatedArray[(int)PokemonTypes.Rock] = 0.5;
                        populatedArray[(int)PokemonTypes.Dragon] = 0.5;
                        populatedArray[(int)PokemonTypes.Steel] = 0.5;
                        populatedArray[(int)PokemonTypes.Fairy] = 0.5;
                        populatedArray[(int)PokemonTypes.Poison] = 0;
                        break;
                    }
                    case PokemonTypes.Fire:
                    {
                        populatedArray[(int)PokemonTypes.Water] = 2;
                        populatedArray[(int)PokemonTypes.Ground] = 2;
                        populatedArray[(int)PokemonTypes.Rock] = 2;
                        populatedArray[(int)PokemonTypes.Bug] = 0.5;
                        populatedArray[(int)PokemonTypes.Grass] = 0.5;
                        populatedArray[(int)PokemonTypes.Fire] = 0.5;
                        populatedArray[(int)PokemonTypes.Ice] = 0.5;
                        break;
                    }
                    case PokemonTypes.Water:
                    {
                        populatedArray[(int)PokemonTypes.Electric] = 2;
                        populatedArray[(int)PokemonTypes.Grass] = 2;
                        populatedArray[(int)PokemonTypes.Fire] = 0.5;
                        populatedArray[(int)PokemonTypes.Water] = 0.5;
                        populatedArray[(int)PokemonTypes.Ice] = 0.5;
                        populatedArray[(int)PokemonTypes.Steel] = 0.5;
                        break;
                    }
                    case PokemonTypes.Grass:
                    {
                        populatedArray[(int)PokemonTypes.Fire] = 2;
                        populatedArray[(int)PokemonTypes.Ice] = 2;
                        populatedArray[(int)PokemonTypes.Poison] = 2;
                        populatedArray[(int)PokemonTypes.Flying] = 2;
                        populatedArray[(int)PokemonTypes.Bug] = 2;
                        populatedArray[(int)PokemonTypes.Water] = 0.5;
                        populatedArray[(int)PokemonTypes.Electric] = 0.5;
                        populatedArray[(int)PokemonTypes.Grass] = 0.5;
                        populatedArray[(int)PokemonTypes.Ground] = 0.5;
                        break;
                    }
                    case PokemonTypes.Electric:
                        populatedArray[(int)PokemonTypes.Ground] = 2;
                        populatedArray[(int)PokemonTypes.Flying] = 0.5;
                        populatedArray[(int)PokemonTypes.Steel] = 0.5;
                        populatedArray[(int)PokemonTypes.Electric] = 0.5;
                        break;
                    case PokemonTypes.Psychic:
                    {
                        populatedArray[(int)PokemonTypes.Bug] = 2;
                        populatedArray[(int)PokemonTypes.Ghost] = 2;
                        populatedArray[(int)PokemonTypes.Dark] = 2;
                        populatedArray[(int)PokemonTypes.Psychic] = 0.5;
                        populatedArray[(int)PokemonTypes.Fighting] = 0.5;
                        break;
                    }
                    case PokemonTypes.Ice:
                    {
                        populatedArray[(int)PokemonTypes.Steel] = 2;
                        populatedArray[(int)PokemonTypes.Rock] = 2;
                        populatedArray[(int)PokemonTypes.Fire] = 2;
                        populatedArray[(int)PokemonTypes.Fighting] = 2;
                        populatedArray[(int)PokemonTypes.Ice] = 0.5;
                        break;
                    }
                    case PokemonTypes.Dragon:
                    {
                        populatedArray[(int)PokemonTypes.Dragon] = 2;
                        populatedArray[(int)PokemonTypes.Fairy] = 2;
                        populatedArray[(int)PokemonTypes.Ice] = 2;
                        populatedArray[(int)PokemonTypes.Fire] = 0.5;
                        populatedArray[(int)PokemonTypes.Water] = 0.5;
                        populatedArray[(int)PokemonTypes.Grass] = 0.5;
                        populatedArray[(int)PokemonTypes.Electric] = 0.5;
                        break;
                    }
                    case PokemonTypes.Dark:
                    {
                        populatedArray[(int)PokemonTypes.Fighting] = 2;
                        populatedArray[(int)PokemonTypes.Fairy] = 2;
                        populatedArray[(int)PokemonTypes.Bug] = 2;
                        populatedArray[(int)PokemonTypes.Ghost] = 0.5;
                        populatedArray[(int)PokemonTypes.Dark] = 0.5;
                        populatedArray[(int)PokemonTypes.Psychic] = 0;
                        break;
                    }
                    case PokemonTypes.Fairy:
                    {
                        populatedArray[(int)PokemonTypes.Poison] = 2;
                        populatedArray[(int)PokemonTypes.Steel] = 2;
                        populatedArray[(int)PokemonTypes.Fighting] = 0.5;
                        populatedArray[(int)PokemonTypes.Bug] = 0.5;
                        populatedArray[(int)PokemonTypes.Dark] = 0.5;
                        populatedArray[(int)PokemonTypes.Dragon] = 0;
                        break;
                    }
                    default:
                        break;
                }
            }
        }
        // return updated array
        return populatedArray;
    }
}
