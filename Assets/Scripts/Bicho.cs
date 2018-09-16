using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bicho : MonoBehaviour {

    public Animator animador;
    public MiniBumper miniBumper;
    public int contador;
    public bool iniciador;
    public bool sacudida;


    void Awake()
    {

    }

    void Start ()
    {
		
	}
	
	void Update ()
    {


        if (miniBumper.golpeado)
        {
            iniciador=true;
        }

        if (iniciador) { contador++; }

        if (contador>100)
        {
            contador = 0;
            iniciador = false;
        }

        if (contador > 0)
        {
            sacudida = true;
        }
        else { sacudida = false; }
        animador.SetBool("Sacudida", sacudida);

	}

    void FixedUpdate()
    {

    }
}
