using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int spd;
    public KeyCode uPKey;
    public KeyCode downKey;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveBall(GetInput()); 
    }

    private Vector2 GetInput()
    {
        if(Input.GetKey(uPKey))
        {
            return  Vector2.up * spd;
        }
        if(Input.GetKey(downKey))
        {
            return Vector2.down * spd;
        }
        return Vector2.zero;
    }
    private void MoveBall(Vector2 move)
    {
        rb.velocity = move;
        transform.Translate(rb.velocity * Time.deltaTime);
    }
}
