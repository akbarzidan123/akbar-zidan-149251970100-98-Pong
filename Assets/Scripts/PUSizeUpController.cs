using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSizeUpController : MonoBehaviour
{
    public Collider2D ball;
    public GameObject paddle;
    [HideInInspector]public int paddleIndex;
    public PowerUpManager manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D col) 
    {
        if(col == ball)
        {
            paddle.transform.GetChild(paddleIndex).localScale = 
            new Vector3(paddle.transform.GetChild(paddleIndex).localScale.x , paddle.transform.GetChild(paddleIndex).localScale.y * 2);
            manager.durationScale(paddle.transform.GetChild(paddleIndex).gameObject);
            manager.RemovePowerUp(gameObject);    
        }
    }
    public int getPaddleIndex()
    {
        return paddleIndex;
    }
    public void setPaddleIndex(int paddleIndex)
    {
        this.paddleIndex = paddleIndex;
    }
}
