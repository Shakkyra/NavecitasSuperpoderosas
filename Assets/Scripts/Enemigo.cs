using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Enemigo : MonoBehaviour
{
    [SerializeField]
    private float _velocidad = 1;

    [SerializeField]
    private float _tiempoDeDestruccion = 5;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, _tiempoDeDestruccion);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += -transform.up * Time.deltaTime * _velocidad;
        
    }

    void OnTriggerEnter(Collider c){
        Destroy(gameObject);
    }
}

