using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    private const float bullet_speed = 3.0F;
    private Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>(); 
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        rb.velocity = new Vector2(mousePos.x, mousePos.y) * bullet_speed;
    }

    void Update() {
    }
}
