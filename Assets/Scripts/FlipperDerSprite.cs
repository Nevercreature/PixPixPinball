using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class FlipperDerSprite : MonoBehaviour {

   
   
    public FlipperDerFisico flipperFisico;
    public Animator animador;
    public int queSpriteMostrar;

    void Awake()
    {
        animador = GetComponent<Animator>();
    }

    void Start()
    {

    }

	void Update ()
    {
		
	}

    void FixedUpdate()
    {


        /* if (flipperFisico.anguloRotacion >= 52)      { queSpriteMostrar = 5; }
           else if (flipperFisico.anguloRotacion >= 39) { queSpriteMostrar = 4; }
           else if (flipperFisico.anguloRotacion >= 26) { queSpriteMostrar = 3; }
           else if (flipperFisico.anguloRotacion >= 13) { queSpriteMostrar = 2; }
           else { queSpriteMostrar = 1; }
        
        if (flipperFisico.anguloRotacion >= 52) { queSpriteMostrar = 5; }
        if (flipperFisico.anguloRotacion < 52 && flipperFisico.anguloRotacion >= 39) { queSpriteMostrar = 4; }
        if (flipperFisico.anguloRotacion < 39 && flipperFisico.anguloRotacion >= 26) { queSpriteMostrar = 3; }
        if (flipperFisico.anguloRotacion < 26 && flipperFisico.anguloRotacion >= 13) { queSpriteMostrar = 2; }
        if (flipperFisico.anguloRotacion < 13) { queSpriteMostrar = 1; }

    */
        animador.SetInteger("estadoAnimacion", flipperFisico.queSpriteMostrar);

       

    }
}
