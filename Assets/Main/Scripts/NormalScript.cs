using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalScript : MonoBehaviour {

    void  OnCollisionEnter (){
        Destroy(gameObject);
    }

}