using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzVerde : MonoBehaviour {

    public Animator animador;
    public GameObject bola;
    public bool iniciador;
    public int contador;

    void Awake()
    {

    }

    void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    void FixedUpdate()
    {
        if (iniciador == true)
        {
            contador++;
        }

        if (contador >= 36)
        {
            iniciador = false;
            contador = 0;
        }

     
            animador.SetBool("Encendida", iniciador);
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bola")

        {
            iniciador = true;
            contador = 0;

        }

    }

}
