using System;
using UnityEngine;

[Serializable]
public enum IngredientType { none, RubinEl, MountaineCoffee, OldGrog, ShushkiNastoika, TwoHandedHoe};

[Serializable]
public class Ingredient
{
    public IngredientType ingredientType;
    public bool withIce;
}
