using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoverScript : MonoBehaviour{

    Rigidbody2D rb;
    float dirX;

    void Start () {
        rb = GetComponent<Rigidbody2D> ();
    }

    void Update(){
        dirX = Input.GetAxis ("Horizontal");
    }
    void FixedUpdate(){
        rb.velocity = new Vector2(dirX*5,0);
    }
}