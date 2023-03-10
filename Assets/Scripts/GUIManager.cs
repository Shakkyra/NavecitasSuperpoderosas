using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Assertions;

public class GUIManager : MonoBehaviour
{
    [SerializeField]
    public TMP_Text _texto;

    private float contadorAumento = 10;
    private float puntuacion = 0;

    // Start is called before the first frame update
    void Start()
    {
        Assert.IsNotNull(_texto, "TEXTO NO PUEDE SER NULO");
        _texto.text = "Presione E para comenzar";
    }

    public void ActualizarMarcador() 
    {
        puntuacion += contadorAumento;
        _texto.text = "Score: " + puntuacion; 
    }
}
