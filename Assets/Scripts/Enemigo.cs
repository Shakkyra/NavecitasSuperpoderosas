using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Enemigo : MonoBehaviour
{
    [SerializeField]
    private float _velocidad = -1;

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
        transform.Translate(
            0,
            -(_velocidad * Time.deltaTime),
            0
        );
        
    }

    void OnCollisionEnter(Collision c){
        void OnTriggerEnter(Collider c){
            Destroy(gameObject);
        }
    }
}

