using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 direction;
    public float speed;

    //public Vector3 rotation;
    //public float speedRotation;

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        //transform.rotation 
    }
}
