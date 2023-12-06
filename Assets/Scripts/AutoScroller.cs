using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScroller : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    [SerializeField] private MeshRenderer _meshRenderer;


    // Update is called once per frame
    void Update()
    {
        Vector2 offSet = new Vector2(0, Time.time * scrollSpeed);
        _meshRenderer.material.mainTextureOffset = offSet;
    }
}
