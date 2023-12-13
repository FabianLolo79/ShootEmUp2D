using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationQuaternion : MonoBehaviour
{
    // The object whose rotation we want to match.
    [SerializeField] 
    Transform target;

    // Angular speed in degrees per sec.
    [SerializeField]
    float speed;

    void Update()
    {
        // The step size is equal to speed times frame time.
        var step = speed * Time.deltaTime;

        // Rotate our transform a step closer to the target's.
        transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, step);
    }
}
