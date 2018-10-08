using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Knight_Move : MonoBehaviour {
    public Animator animator;
    public int playerSpeed = 5;
    private bool facingRight = true;
    public int jumpPower = 1200;
    public float moveX;



    void Move_Player(){
        moveX = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(moveX*playerSpeed));
        if (Input.GetButtonDown("Jump")){
            jump();
        }
        if(moveX < 0.0f && facingRight==true){
            flipPlayer();
        }
        else if(moveX > 0.0f && facingRight==false){
            flipPlayer();
        }
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }
    void flipPlayer(){
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
    void jump(){
        GetComponent<Rigidbody2D>().AddForce (Vector2.up * jumpPower);
    }
	// Update is called once per frame
	void Update () {
        Move_Player();
    }
}
