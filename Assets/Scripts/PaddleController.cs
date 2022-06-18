using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public PUPaddleSpdUp paddleSpdUp;
    public PUSizeUpController paddleSizeUp;
    public int spd;
    public KeyCode uPKey;
    public KeyCode downKey;
    private Rigidbody2D rb;
    public Collider2D ball;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePaddle(GetInput()); 
        Debug.Log(spd);
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
    private void MovePaddle(Vector2 move)
    {
        // Debug.Log("Test: " + move);
        rb.velocity = move;
        transform.Translate(rb.velocity * Time.deltaTime);
    }
    public void setSpd(int spd)
    {
        this.spd = spd;
    }
    public int getSpd()
    {
        return spd;
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        paddleSpdUp.setPaddleIndex(gameObject.transform.GetSiblingIndex());
        paddleSizeUp.setPaddleIndex(gameObject.transform.GetSiblingIndex());
    }
}
