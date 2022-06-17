using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : Vehicle
{
    public override void Move()
    {
        maxMotorTorque = 3f;
        maxSteeringAngle = 5f;
        base.Move();
    }

    void FixedUpdate()
    {
        Move();
    }
}
