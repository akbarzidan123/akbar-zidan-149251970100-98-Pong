using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUpController : MonoBehaviour
{   
    public Collider2D ball;
    public float magnitude;
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
            ball.GetComponent<BallController>().ActivateSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
