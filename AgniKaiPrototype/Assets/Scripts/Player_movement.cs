using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    private Rigidbody2D body;
    private Animator anim;

	// Use this for initialization
	void Start ()
	{
	    body = GetComponent<Rigidbody2D>();
	    anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
	    Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

	    if (movement_vector != Vector2.zero)
	    {
	        anim.SetBool("is_walking", true);
	        anim.SetFloat("input_x", movement_vector.x);
	        anim.SetFloat("input_y", movement_vector.y);

	    }
	    else
	    {
	        anim.SetBool("is_walking", false);
	    }

	    body.MovePosition(body.position + movement_vector * Time.deltaTime * 2);

	}
}
