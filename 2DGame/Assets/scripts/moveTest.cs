using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTest : MonoBehaviour {
    public Rigidbody2D rb;
    public float forca;
    // Use this for initialization
    void FixedUpdate() {
        float input = Input.GetAxis("Horizontal");
        if(Mathf.Abs(rb.velocity.x) <= 4f)
            rb.AddForce(Vector2.right * input * forca);
    }
}
