using UnityEngine;

[CreateAssetMenu]
public class IngredientGen : ScriptableObject
{
    public Ingredient[] ingredients;
    public int ind = 0;

    public Ingredient Generate(int index)
    {
        return ingredients[index++ % ingredients.Length];
    }
}
