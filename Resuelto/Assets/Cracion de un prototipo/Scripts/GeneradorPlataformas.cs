using System.Collections;
using System.Collections.Generic;
using UnityEditor.MemoryProfiler;
using UnityEngine;

public class GeneradorPlataformas : MonoBehaviour
{
    public GameObject plataforma;
    public Transform topeGenerado;
    public float distancia;

    private float anchoPlataforma;

    void Start()
    {
        anchoPlataforma = plataforma.GetComponent<BoxCollider2D>().size.x;

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < topeGenerado.position.x)
        {
            transform.position = new Vector3(transform.position.x + anchoPlataforma + distancia, transform.position.y, transform.position.z);

            Instantiate(plataforma, transform.position, transform.rotation);
        }
    }
}
