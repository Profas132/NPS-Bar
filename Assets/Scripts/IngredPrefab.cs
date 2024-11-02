using UnityEngine;

public class IngredPrefab : MonoBehaviour
{
    [SerializeField] private IngredientGen ingredientGen;
    private Ingredient currentIngredient;
    public Sprite imageOfIngred;
    public string nameOfIngerdient;
    public int index;

    private void Start()
    {
        currentIngredient = ingredientGen.Generate(index);
        SpriteRenderer spriteOfIngred = GetComponent<SpriteRenderer>();
        //Debug.Log($"{gameObject.name} {index}");

        nameOfIngerdient = currentIngredient.NameOfIngerdient;
        imageOfIngred = currentIngredient.PhotoOfIngerdient;
        spriteOfIngred.sprite = currentIngredient.PhotoOfIngerdient;
    }
}
