using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class BotonRight : MonoBehaviour {

    public Animator botonRight;
    public bool botonRightPulsado;

    private void Awake()
    {
      
    }

    void Start () {
  
    }
	
	void FixedUpdate () {

    }

    void Update()
    {

        if (CrossPlatformInputManager.GetButtonDown("Fire3"))
        {

            botonRightPulsado = true;
        }

        if (CrossPlatformInputManager.GetButtonUp("Fire3"))
        {
            botonRightPulsado = false;


        }

        botonRight.SetBool("pulsado",botonRightPulsado);



    }
    }
