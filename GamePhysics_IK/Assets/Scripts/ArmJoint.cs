using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmJoint : MonoBehaviour
{

    public float MinAngle = -float.MaxValue;
    public float MaxAngle = float.MaxValue;

    public Vector3 RotationAxis;
    public Vector3 StartOffset;

    public float angle
    {
        set {
            transform.localRotation = Quaternion.AngleAxis(value, RotationAxis);
            return;
        }
    }

    private void Awake()
    {
        StartOffset = transform.localPosition;
        RotationAxis = RotationAxis.normalized;
    }
}