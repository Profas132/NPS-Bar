using System;
using UnityEngine;

[Serializable]
public enum IngredientType { none, napitok1, napitok2, napitok3, napitok4, napitok5, napitok6};

[Serializable]
public class Ingredient
{

    public IngredientType ingredientType;
    public bool withIce;
    
}
