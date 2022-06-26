using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMover : MonoBehaviour {
    private const float movement_speed = 5.0F;

    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Animator animator;

    public GameObject bullet;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }


    void Update() {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float horizontal = Input.GetAxisRaw("Horizontal");
        bool fire = Input.GetMouseButtonDown(0);
        bool jump = Input.GetKeyDown("space");

        if (horizontal == -1) {
            sr.flipX = false;
        } else if (horizontal == 1) {
            sr.flipX = true;
        }

        if (jump) {
            transform.position += new Vector3(0.0f, 1.0f, 0.0f);
            animator.Play("Base Layer.FrogAnimation", 0, 0.0f);
        }
        rb.velocity = new Vector2(horizontal * movement_speed, rb.velocity.y);

        if (fire) {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
}
