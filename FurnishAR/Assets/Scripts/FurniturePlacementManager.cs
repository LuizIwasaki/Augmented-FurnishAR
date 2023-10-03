using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FurniturePlacementManager : MonoBehaviour
{
    public GameObject SpawnableFurniture;
    public ARSessionOrigin arOrigin;
    public ARRaycastManager raycastManager; 
    public ARPlaneManager planeManager;
    public ObjectRemovalManager removalManager;

    private List<ARRaycastHit> raycastHits = new List<ARRaycastHit>(); 


    private void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
               bool collison = raycastManager.Raycast(Input.GetTouch(0).position, raycastHits, TrackableType.PlaneWithinPolygon);
               if(collison && !isButtonPressed())
               {
                    GameObject _object = Instantiate(SpawnableFurniture);
                    _object.transform.position = raycastHits[0].pose.position;
                    _object.transform.rotation = raycastHits[0].pose.rotation;

                    removalManager.AddPlacedFurnitureObject(_object);
                }

               foreach(var plane in planeManager.trackables)
                {
                    plane.gameObject.SetActive(false);
               }

               planeManager.enabled = false;

            }
        }
    }

    public bool isButtonPressed()
    {
        if(EventSystem.current.currentSelectedGameObject?.GetComponents<Button>() == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void SwitchFurniture(GameObject furniture)
    {
        SpawnableFurniture = furniture;
    }

    public void RemoveAllPlacedFurniture()
    {
        // Call the ObjectRemovalManager to remove all placed furniture
        removalManager.RemoveAllPlacedFurniture();
    }

}
