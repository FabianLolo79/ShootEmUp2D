using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehaviour : MonoBehaviour
{
    public Movement moverComponent;

    void Update()
    {
        Vector3 movement = new Vector3(UnityEngine.Random.Range(-1f,1f), 
                                       UnityEngine.Random.Range(-1f, 1f), 
                                       transform.position.z);
        
        moverComponent.DoMove(movement);
    }
}
