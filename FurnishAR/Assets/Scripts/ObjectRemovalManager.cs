using System.Collections.Generic;
using UnityEngine;

public class ObjectRemovalManager : MonoBehaviour
{
    private List<GameObject> placedFurnitureObjects = new List<GameObject>();


    /* this method is called from the FurniturePlacementManager script when a new furniture object is placed in the scene
     * 
     */
    public void AddPlacedFurnitureObject(GameObject furnitureObject)
    {
        placedFurnitureObjects.Add(furnitureObject);
    }

    public void RemoveAllPlacedFurniture()
    {
        foreach (var furnitureObject in placedFurnitureObjects)
        {
            Destroy(furnitureObject);
        }

        placedFurnitureObjects.Clear();
    }
}
