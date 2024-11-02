using System;
using UnityEngine;

[Serializable]
public class Ingredient
{
    //[]
    public Sprite PhotoOfIngerdient;
    public string NameOfIngerdient;
    //public int tagOfIngredient;
    public Category categoryOfIngredients;

    public enum Category {Myaso,Ovosh,Fruct};
}
