using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class FlipperIzqFisico : MonoBehaviour {

    public Rigidbody2D rigidBody;
    public float anguloRotacion=13;
    public int queSpriteMostrar;
    public ObjetoGeneral objetoGeneral;
    public AudioSource flipper;

    void Awake()
    {

    }

    void Start()
    {

    }

	void Update ()
    {
		
	}

    void FixedUpdate()
    {
      if (CrossPlatformInputManager.GetButton("Fire1"))
        //{ anguloRotacion += 16f; } else { anguloRotacion -= 16f; }  
        { anguloRotacion += 52f; }    else { anguloRotacion -= 16f; }
        //{ anguloRotacion += 16f; } else { anguloRotacion -= 16f; }  

        if (CrossPlatformInputManager.GetButtonDown("Fire1"))

        { PlayFlipper(); }


        if (anguloRotacion >= 52) { anguloRotacion = 52; }
        if (anguloRotacion <= 0) { anguloRotacion = 0; }

        rigidBody.MoveRotation(anguloRotacion);

        if (anguloRotacion >= 52) { queSpriteMostrar = 5; }
        if (anguloRotacion < 52 && anguloRotacion >= 39) { queSpriteMostrar = 4; }
        if (anguloRotacion < 39 && anguloRotacion >= 26) { queSpriteMostrar = 3; }
        if (anguloRotacion < 26 && anguloRotacion >= 13) { queSpriteMostrar = 2; }
        if (anguloRotacion < 13) { queSpriteMostrar = 1; }

    }

    public void PlayFlipper()
    {
        flipper.Play();
    }

}
