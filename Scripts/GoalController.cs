using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider2D ball;
    public bool isRight;
    public ScoreManager manager;
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
            if(isRight)
            {
                manager.AddRightScore(1);
            }
            else{
                manager.AddLeftScore(1);
            }
        }
    }
}
