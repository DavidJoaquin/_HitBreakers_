using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Habilidad : MonoBehaviour {

    // Use this for initialization
    [HideInInspector]
    public abstract void ejecuta(GameObject player);

}

