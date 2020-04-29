using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassController : MonoBehaviour
{

    public float speed = 10f;
    private Rigidbody2D glass;

    void Awake()
    {
        glass = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 vel = glass.velocity;
        vel.x = Input.GetAxis("Horizontal") * speed;
        glass.velocity = vel;

    }
}
