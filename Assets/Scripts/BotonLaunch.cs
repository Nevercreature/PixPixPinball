using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class BotonLaunch : MonoBehaviour {

    public Animator botonLaunch;
    public bool botonLaunchPulsado;
    public BolaProvisional bola;
    public GameObject bolaObject;
    public Pop pop;

    private void Awake()
    {
      
    }

    void Start () {
  
    }
	
	void FixedUpdate () {

    }

    void Update()
    {

        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {

            botonLaunchPulsado = true;
        }

        if (CrossPlatformInputManager.GetButtonUp("Jump"))
        {
            botonLaunchPulsado = false;
            bola.Reposicionar();
            pop.pop = true;
         
           bolaObject.SetActive(true);
            this.gameObject.SetActive(false);

        }

        botonLaunch.SetBool("pulsado",botonLaunchPulsado);



    }
    }
