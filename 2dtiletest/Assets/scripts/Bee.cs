using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonoBehaviour {
    private Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void Update() {
        
    }

    void OnCollisionEnter2D(Collision2D c) {
        Debug.Log("hit!");
        rb.gravityScale = 1.0f;
    }
}
