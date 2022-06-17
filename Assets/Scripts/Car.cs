using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    public override void Move()
    {
        maxMotorTorque = 5f;
        maxSteeringAngle = 10f;
        base.Move();
    }

    void FixedUpdate()
    {
        Move();
    }
}
