using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour
{
    [SerializeField] GameObject vehicle;
    Transform specificVehicle;
    [SerializeField] Vector3 offset;
    Vector3 viewPoinOffset;
    Vector3 targetPosition;
    float translateSpeed = 10;
    float rotationSpeed = 20;
    bool initialized = false;

    float mouseRotationSpeed = 2f;

    public void Initialize()
    {
        specificVehicle = vehicle.transform.GetChild(0);
        float vehicleLength = specificVehicle.GetComponent<BoxCollider>().size.z;
        float vehicleHeight = specificVehicle.GetComponent<BoxCollider>().size.y;
        offset = new Vector3(0, vehicleHeight * 1.5f, -(vehicleLength + 1));
        viewPoinOffset = new Vector3(0, 1.5f, 0);
        initialized = true;
        Debug.Log(initialized);
    }

    void FixedUpdate()
    {
        if(initialized)
        {
            AutomaticRotation();
        }
    }

    void AutomaticRotation()
    {
        targetPosition = specificVehicle.transform.TransformPoint(offset);
        transform.position = Vector3.Lerp(transform.position, targetPosition, translateSpeed * Time.deltaTime);
        Vector3 direction = (specificVehicle.transform.position + viewPoinOffset) - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }

    // Alternative camera movement
    void MouseRotation()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * mouseRotationSpeed, Vector3.up) * offset;
        transform.position = specificVehicle.transform.position + offset;
        transform.LookAt(specificVehicle.transform.position);
    }
}
