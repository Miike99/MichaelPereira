using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoMovimiento : MonoBehaviour
{
    public float speed = 1.5f;
    Vector2 fondoPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fondoPos.x += speed / 100000;
        fondoPos.x %= 1;
        GetComponent<Renderer>().material.mainTextureOffset = fondoPos;
    }
}
