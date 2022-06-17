using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    protected float maxMotorTorque; // maximum torque the motor can apply to wheel
    protected float maxSteeringAngle; // maximum steer angle the wheel can have

    public virtual void Move()
    {
        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * maxMotorTorque * motor);
        transform.Rotate(Vector3.up, Time.deltaTime * maxSteeringAngle * steering);
    }

}
