using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerakanball : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;

    public Rigidbody2D ball;

    void Start()
    {
        ball.velocity = new Vector2(1,-1) * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}