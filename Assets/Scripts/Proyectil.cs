using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Proyectil : MonoBehaviour
{


    [SerializeField]
    private float _speed = 5;

    [SerializeField]
    private float _tiempoDeAutodestruccion = 3;

    private GUIManager _gui;
    
    void Start(){
        // NOTA 
        // si se crea un objeto dinamicamente es importante tener al menos una estrategia de destrucción

        // destroy - destruye game objects completos o componentes 
        //Destroy (gameObject);
        Destroy(gameObject, _tiempoDeAutodestruccion);

        GameObject guiGo = GameObject.Find("GUIManager");
        Assert.IsNotNull(guiGo, "no hay GUIManager");

        _gui = guiGo.GetComponent<GUIManager>();
        Assert.IsNotNull(_gui,"GUIManager no tiene componente");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(
            0,
            0,
            _speed * Time.deltaTime
        );
    }

    // COLISIONES
    // Se necesita:
    //1. Todos los objetos involucrados necesitan collider
    //2. Necestitamos que al menos 1 tenga rigidbody
    //3. El rigidbody debe estar en un objeto que se mueva

    void OnCollisionEnter(Collision c){
        // objeto collision que recebimos 
        // contiene info de la collision

        //como saber que hacer
        //1. filtrar por tag
        //2. filtrar por layer

        print("Enter" + c.transform.name);
    }

    void OnCollisionStay(Collision c){
        print("Stay");
    }

    void OnCollisionExit(Collision c){
        print("Exit");
    }

    void OnTriggerEnter(Collider c){
        print("TRIGGER ENTER");
        float contadorPuntos = 0;
        contadorPuntos = contadorPuntos + 10;
        _gui._texto.text = contadorPuntos.ToString("0");
        Destroy(gameObject);
    }

    void OnTriggerStay(Collider c){
        print("TRIGGER STAY");
    }

    void OnTriggerExit(Collider c){
        print("TRIGGER EXIT");
        _gui._texto.text = "SALI" + transform.name;
    }
}
