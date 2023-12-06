using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}

public class PlayerController : MonoBehaviour
{
    public Movement moverComponent;
    public float speed;
    public Boundary boundary;

    
    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime,
                                          Input.GetAxis("Vertical") * speed * Time.deltaTime,
                                          transform.position.z);
        moverComponent.DoMove(movement);

        // 8.2 axis X
        // 4.5 axis Y
        float x = Mathf.Clamp(transform.position.x, boundary.xMin, boundary.xMax);
        float y = Mathf.Clamp(transform.position.y, boundary.yMin, boundary.yMax);
        transform.position = new Vector3(x, y);
    }
}
