using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    //FLOAT - La velocidad de la bala
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Movemos la bala hacia delante con la velocidad speed multiplicada por Time.deltaTime
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

		
	}
}
