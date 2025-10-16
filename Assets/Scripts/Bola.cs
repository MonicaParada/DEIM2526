using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    
    //Zona de propiedades
    private Vector3 _posicionInicial;
    
    
    // Start is called before the first frame update
    void Start()
    {

        _posicionInicial = transform.localPosition;
        
    }

    public void MoverEsfera(){


        transform.localPosition = _posicionInicial;
        gameObject.GetComponent<Rigidbody>().useGravity = true;


    }
    
    public void PararEsfera(){

        gameObject.GetComponent<Rigidbody>().useGravity = false;
        _posicionInicial = transform.localPosition;

    }


}
