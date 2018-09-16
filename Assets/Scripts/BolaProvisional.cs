using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaProvisional : MonoBehaviour {

    public Vector3 posicion;
    public Rigidbody2D rigidBody2D;
    public GameObject botonLaunch;

    public Vector2 velocidad;
    public float velocidadX;
    public float velocidadY;

    void Awake()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        posicion = new Vector3(-38.9f, -2.1f, 90);
    }

    void Start()
    {

    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        if (transform.position.y <= -120)
        {
            botonLaunch.SetActive(true);
            rigidBody2D.velocity = new Vector2(0, 0);
            this.gameObject.SetActive(false);
        }

        //esto es para conocer la velocidad máxima que alcanza la bola para luego poder limitarla

        velocidad = rigidBody2D.velocity;

        if (velocidadX < rigidBody2D.velocity.x) { velocidadX = rigidBody2D.velocity.x; }
        if (velocidadY < rigidBody2D.velocity.y) { velocidadY = rigidBody2D.velocity.y; }

        //y esto la limita...

        if (rigidBody2D.velocity.x >= 300) { rigidBody2D.velocity = new Vector2(300, rigidBody2D.velocity.y); }
        if (rigidBody2D.velocity.y >= 300) { rigidBody2D.velocity = new Vector2(rigidBody2D.velocity.x, 300); }
    }
    

    public void Reposicionar()
    {
        this.transform.localPosition = new Vector3(-90, -95, 10);
    }
}

