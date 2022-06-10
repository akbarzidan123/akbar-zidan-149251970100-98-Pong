using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 spd;
    public Vector2 resetPosition;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Transform>(); 
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = spd;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position; 
        transform.Translate(rb.velocity * Time.deltaTime); 
    }
    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }
}
