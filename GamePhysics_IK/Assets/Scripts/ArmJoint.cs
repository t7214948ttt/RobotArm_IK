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

    public float angle
    {
        get {

            if (_rotationAxis == 'x')
            {
                return transform.localRotation.eulerAngles.x;
            }
            else if (_rotationAxis == 'y')
            {
                return transform.localRotation.eulerAngles.y;
            }
            else if (_rotationAxis == 'z')
            {
                return transform.localRotation.eulerAngles.z;
            }
            return 0;
        }
        set {
            switch (_rotationAxis)
            {
                case 'x':
                    transform.localEulerAngles = new Vector3(value, 0, 0);
                    break;
                case 'y':
                    transform.localEulerAngles = new Vector3(0, value, 0);
                    break;
                case 'z':
                    transform.localEulerAngles = new Vector3(0, 0, value);
                    break;
            }
        }
    }

    private void Awake()
    {
        StartOffset = transform.localPosition;
        RotationAxis = RotationAxis.normalized;
    }
}