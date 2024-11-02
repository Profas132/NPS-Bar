using UnityEngine;

public class TableSpawner : MonoBehaviour
{
    //[SerializeField] private KarmanUI karmanUI;
    [SerializeField] private IngredPrefab ingredient;
    [SerializeField] private IngredPrefab ingradItem;
    public int indexOnTable;

    void Start()
    {
        IngredPrefab ingred;
        ingred = Instantiate(ingredient, transform);
        ingred.index = indexOnTable;
    }

    //public void TakeItem(Transform collition)
    //{   
    //    Inventary inventary = collition.GetComponentInChildren<Inventary>();
    //    for (int i = 0; i < inventary.karmani.Length; i++)
    //    {
    //        if (inventary.isFull[i] == false)
    //        {
    //            inventary.isFull[i] = true;
    //            IngredPrefab ingred = Instantiate(ingradItem, inventary.karmani[i].transform);
    //            inventary.ingredInInventory.Add(ingred);
    //            ingred.index = indexOnTable;
    //            break;
    //        }
    //        if (inventary.isFull[i] == true && inventary.ingredInInventory[i].index == indexOnTable)
    //        {
    //            inventary.karmani[i].DropItem();
    //            break;
    //        }
    //        //karmanUI.UpdateKarmani();
    //    }
    //    //IngredPrefab ingred;
    //    //ingred = Instantiate(ingradItem, player.transform) as IngredPrefab;
    //    //ingred.index = index;
    //}
}
