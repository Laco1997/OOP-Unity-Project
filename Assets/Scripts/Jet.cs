using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jet : Vehicle
{
    public override void Move()
    {
        maxMotorTorque = 8f;
        maxSteeringAngle = 15f;
    }

    void FixedUpdate()
    {
        Move();
    }
}
