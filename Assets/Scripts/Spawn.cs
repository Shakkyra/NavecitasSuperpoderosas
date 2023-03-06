using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    private Enemigo _enemigoOriginal;
    [SerializeField]
    private GameObject _self;

    // Start is called before the first frame update
    void Start()
    {
        Assert.IsNotNull(_enemigoOriginal, "SE NECESITA UN ENEMIGO");
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetButtonDown("Comienzo")){
            Instantiate(
                _enemigoOriginal,
                transform.position,
                transform.rotation
            );
        }*/
        if(Input.GetButtonDown("Comienzo")){
            Vector3 posicionRectangulo = _self.transform.position;
            //Dividimos la pared en dos
            float mitadRect = _self.transform.localScale.x / 2f;
            //Elegimos una parte aleatoria
            float posAleatoria = Random.Range(posicionRectangulo.x - mitadRect, posicionRectangulo.x + mitadRect);
            Vector3 posicionSpawn = new Vector3(posAleatoria,posicionRectangulo.y,posicionRectangulo.z);
            Instantiate(_enemigoOriginal,posicionSpawn,Quaternion.identity);
        }
        
    }
}
