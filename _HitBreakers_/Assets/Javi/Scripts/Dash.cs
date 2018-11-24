using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour {

    // public float tiempoDeVida;
    public GameObject posicionDestino;

    public void ejecuta(GameObject player) {
        
        PlayerController playerCont = player.GetComponent<PlayerController>();
        Vector3 apunta = playerCont.getApuntar();
     //   tiempoDeVida -= Time.deltaTime;
        player.transform.Translate(posicionDestino.GetComponent<Transform>().position);
        
  //      if (tiempoDeVida <= 0) {
  //          Destroy(this.gameObject);
  //      }
        
    }
}
