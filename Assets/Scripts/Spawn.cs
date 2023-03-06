using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    private Enemigo _enemigoOriginal;

    // Start is called before the first frame update
    void Start()
    {
        Assert.IsNotNull(_enemigoOriginal, "SE NECESITA UN ENEMIGO");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Comienzo")){
            Instantiate(
                _enemigoOriginal,
                transform.position,
                transform.rotation
            );
        }
        
    }
}
