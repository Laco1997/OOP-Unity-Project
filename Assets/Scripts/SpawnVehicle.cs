using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVehicle : MonoBehaviour
{
    string vehicleTag = "Car";
    [SerializeField] GameObject[] vehicles;
    CameraView cameraView;

    // Start is called before the first frame update
    void Start()
    {
        cameraView = GameObject.Find("Main Camera").GetComponent<CameraView>();
        if (MainManager.Instance != null)
        {
            vehicleTag = MainManager.Instance.pickedVehicle;
        }

        Spawn(vehicleTag);
    }

    void Spawn(string vehicleTag)
    {
        foreach(GameObject vehicle in vehicles)
        {
            if(vehicle.CompareTag(vehicleTag))
            {
                GameObject parent = GameObject.Find("Vehicle");
                GameObject vehiclePrefab = Instantiate(vehicle, parent.transform);
                vehiclePrefab.name = vehicleTag;
                cameraView.Initialize();
            }
        }
    }
}
