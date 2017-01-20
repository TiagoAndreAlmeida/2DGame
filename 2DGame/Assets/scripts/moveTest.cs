using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTest : MonoBehaviour {
    public Rigidbody2D rb;
    public bool grab;
    public Transform pos;
    public float power;
    // Use this for initialization
   /* void Update() {
            //print("TESTE");
            Vector2.MoveTowards(this.transform.position, pos.position, 1f);
    }*/
    void FixedUpdate() {
        float input = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
        }

        if (Mathf.Abs(rb.velocity.x) <= 4f)
            rb.AddForce(Vector2.right * input * power);
    }

    void OnTriggerEnter2D(Collider2D hit) {
        rb.Sleep();
        rb.gravityScale = 0;
        grab = true;
    }

    void OnTriggerExit2D(Collider2D hit) {
        rb.WakeUp();
        rb.gravityScale = 1;
        grab = false;
    }
}
