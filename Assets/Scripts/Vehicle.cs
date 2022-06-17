using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    protected float maxMotorTorque;
    protected float maxSteeringAngle;

    public virtual void Move()
    {
        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * maxMotorTorque * motor);
        transform.Rotate(Vector3.up, Time.deltaTime * maxSteeringAngle * steering);
    }

}
