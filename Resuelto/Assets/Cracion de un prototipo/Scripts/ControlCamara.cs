using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class ControlCamara : MonoBehaviour
{
    public Transform objetivo;
    public float suavizado;
    Vector3 desface;

    private void Start()
    {
        desface = transform.position - objetivo.position;
    }
    void FixedUpdate()
    {
        Vector3 posicionObjetivo = objetivo.position + desface;
        transform.position = Vector3.Lerp(transform.position, posicionObjetivo, suavizado * Time.deltaTime);
    }
}