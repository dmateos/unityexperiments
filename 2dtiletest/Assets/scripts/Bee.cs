using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonoBehaviour {
    private Rigidbody2D rb;

    private float radius = 0.001f;
    private float speed = 5.0f;
    private float angle = 0.0f;

    void Start() {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void Update() {
        angle += speed * Time.deltaTime;

        var offset = new Vector3(Mathf.Sin(angle), Mathf.Cos(angle), 0.0f) * radius;
        transform.position += offset;
    }

    void OnCollisionEnter2D(Collision2D c) {
        Debug.Log("hit!");
        rb.gravityScale = 1.0f;
    }
}
