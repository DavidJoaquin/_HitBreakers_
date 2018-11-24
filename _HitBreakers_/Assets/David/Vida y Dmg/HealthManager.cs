using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour {

    public int maxHealth;
    private int currentHealth;

	// Use this for initialization
	void Start () {

        currentHealth = maxHealth;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (currentHealth <= 0)
        {
            Destroy(this.gameObject);
        }
		
	}


    public void RecibirDmg (int damage)
    {
        currentHealth -= damage;
    }

}
