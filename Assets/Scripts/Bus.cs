using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : Vehicle
{
    public override void Move()
    {
        maxMotorTorque = 4f;
        maxSteeringAngle = 6f;
        base.Move();
    }

    void FixedUpdate()
    {
        Move();
    }
}
