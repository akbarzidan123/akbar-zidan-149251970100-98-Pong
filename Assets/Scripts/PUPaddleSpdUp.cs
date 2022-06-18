using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleSpdUp : MonoBehaviour
{
    public Collider2D ball;
    public GameObject paddle;
    [HideInInspector]public int paddleIndex = 0;
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
            int spdTemp = paddle.transform.GetChild(paddleIndex).GetComponent<PaddleController>().getSpd();
            paddle.transform.GetChild(paddleIndex).GetComponent<PaddleController>().setSpd(spdTemp*2);
            manager.durationSpd(paddle.transform.GetChild(paddleIndex).gameObject);
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
