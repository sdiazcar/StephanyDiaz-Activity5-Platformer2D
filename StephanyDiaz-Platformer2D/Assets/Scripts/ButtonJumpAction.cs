using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonJumpAction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TapEnElBotonJump(){
        Debug.Log("El Boton Jump Ha Sido Presionado");

        GameObject.Find("Mario").GetComponent<MarioCharacterController>().EjecuteElSaltoDeMario();
    }
}
