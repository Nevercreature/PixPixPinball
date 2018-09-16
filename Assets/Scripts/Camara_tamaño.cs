using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara_tamaño : MonoBehaviour {

  
    public Camera camara;
    // Use this for initialization
    void Awake()
    {

        camara = GetComponent<Camera>();
        camara.orthographicSize = 135;   //esto es para cambiar el tama�o de la camara al correcto.
    }

    void Start () {
        camara.orthographicSize = 135;   //esto es para cambiar el tama�o de la camara al correcto.
    }
	
	// Update is called once per frame
	void Update () {
        camara.orthographicSize = 135;   //esto es para cambiar el tama�o de la camara al correcto.
    }
}
