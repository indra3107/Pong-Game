using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gerakanball : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;

    public Rigidbody2D ball;
    public Animator FireBall;

    void Start()
    {
        ball.velocity = new Vector2(1,-1) * speed;
        FireBall.SetBool("ismoving", true);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(ball.velocity.x > 0){
        	ball.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
        	}else{
        		ball.GetComponent<Transform>().localScale = new Vector3(-1, 1, 1);
        	}
    }

    void OnCollisionEnter2D(Collision2D other){
    	if(other.collider.name=="wall kanan" || other.collider.name=="wall kiri"){
    		StartCoroutine(interval());
    	}
    }

    IEnumerator interval(){
    	ball.velocity = new Vector2(0,0);
    	FireBall.SetBool("ismoving", false);
    	ball.GetComponent<Transform>().position = new Vector2(0,0);
    	yield return new WaitForSeconds(1);
    	ball.velocity = new Vector2(-1,-1) * speed;
    	FireBall.SetBool("ismoving", true);
    }
}