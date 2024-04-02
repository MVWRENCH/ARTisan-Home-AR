using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceManager : MonoBehaviour
{
    private PlacementIndicator placementIndicator;
    public GameObject objectToPlace;
    private GameObject newPlacedObject;

    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();
    }

    // Update is called once per frame
    public void ClickToPlace()
    {
        newPlacedObject = Instantiate(objectToPlace, placementIndicator.transform.position, placementIndicator.transform.rotation);
    }
}
