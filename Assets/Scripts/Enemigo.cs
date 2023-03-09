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

    private GUIManager _gui;

    private float contadorAumento = 10;
    private float puntuacion;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, _tiempoDeDestruccion);
        GameObject guiGo = GameObject.Find("GUIManager");
        _gui = guiGo.GetComponent<GUIManager>();
        
        
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

    void OnTriggerEnter(Collider c){
        Destroy(gameObject);
        FindObjectOfType<Enemigo>().AddPuntuation(contadorAumento);
        
    }

    public void AddPuntuation(float puntuationValue){
        puntuacion += puntuationValue;
        _gui._texto.text ="Score: " + puntuacion.ToString("0");
        
    }
}

