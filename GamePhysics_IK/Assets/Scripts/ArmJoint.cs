using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmJoint : MonoBehaviour
{

    public float MinAngle = -360;
    public float MaxAngle = 360;

    public Vector3 RotationAxis;
    public Vector3 StartOffset;
    public char _rotationAxis
    {
        get
        {
            if (RotationAxis == Vector3.forward)
                return 'z';
            if (RotationAxis == Vector3.right)
                return 'x';
            if (RotationAxis == Vector3.up)
                return 'y';
            return 'z';
        }
    }

    private void Awake()
    {
        StartOffset = transform.localPosition;
    }
}