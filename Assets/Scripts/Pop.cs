using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pop : MonoBehaviour {

    public bool pop;
    public Animator animador;
    public int contador;

    // Use this for initialization
    void Awake()
    {
        pop = false;
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        animador.SetBool("Pop", pop);

        if (pop == true) {
            contador++;
        }

        if (contador > 40) {
            pop = false;
            contador = 0;
        }
       
    }

}
