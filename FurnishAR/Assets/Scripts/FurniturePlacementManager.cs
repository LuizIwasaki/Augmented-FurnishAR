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


    public void Start()
    {

        planeManager.enabled = true;
    }

    private void Update()
    {
        planeManager.enabled = true; //reativate the plane manager if it was deactivated by the ObjectRemovalManager

        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); 

            if(touch.phase == TouchPhase.Began)
            {
               bool collison = raycastManager.Raycast(touch.position, raycastHits, TrackableType.PlaneWithinPolygon); // get the position of the touch and check if it collides with a plane
               if(collison && !isButtonPressed())
               {
                    GameObject _object = Instantiate(SpawnableFurniture); 
                    _object.transform.position = raycastHits[0].pose.position; // set the position of the furniture object to the position of the raycast hit
                    _object.transform.rotation = raycastHits[0].pose.rotation; // set the rotation of the furniture object to the rotation of the raycast hit

                    removalManager.AddPlacedFurnitureObject(_object); // call the ObjectRemovalManager to add the placed furniture object to the list of placed furniture objects
                }

            }
        }
    }

    public bool isButtonPressed()
    {
        return EventSystem.current.currentSelectedGameObject?.GetComponent<Button>() != null;
    }

    public void SwitchFurniture(GameObject furniture)
    {
        SpawnableFurniture = furniture;
    }

    public void RemoveAllPlacedFurniture()
    {

        removalManager.RemoveAllPlacedFurniture();
    }

}
