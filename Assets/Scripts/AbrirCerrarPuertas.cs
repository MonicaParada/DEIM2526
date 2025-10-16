using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirCerrarPuertas : MonoBehaviour
{
    
    private Animator _animador;
    private bool _abrir;
    
    // Start is called before the first frame update
    void Start()
    {
        
        _animador = GetComponent<Animator>();

    }

    
    void OnMouseDown(){

        _abrir =! _abrir;

        _animador.SetBool("Abrir", _abrir);


    }


}
