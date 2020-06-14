using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPlataforma : MonoBehaviour
{
    public GameObject puntoDestruccionPlataforma;

    void Start()
    {
        puntoDestruccionPlataforma = GameObject.Find("PuntoDestruir");
        
    }

    
    void Update()
    {
        if(transform.position.x < puntoDestruccionPlataforma.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
