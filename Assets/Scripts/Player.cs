using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	private GameObject scoretext;
	private bool grounded = false;
	public float JumpPower;
	public float speed;
	private Rigidbody2D rb;
	private Vector2 StartPosition;
	private bool justdied = false;
    // Start is called before the first frame update
    void Start()
    {
		scoretext = GameObject.Find("Score Text");
        rb = GetComponent<Rigidbody2D>();
		StartPosition = transform.position;
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
		{
			Vector2 JumpVec = new Vector2(0.0f,JumpPower);
			rb.AddForce(JumpVec, ForceMode2D.Impulse);
		}
    }
	
	void FixedUpdate() 
	{
		float horizontalInput = Input.GetAxis("Horizontal")*speed;
		Vector2 Vec = new Vector2(horizontalInput,0.0f);
		rb.AddForce(Vec);
		if (justdied)
		{
			justdied = false;
			rb.velocity = new Vector2();
			rb.angularVelocity = 0;
		}
	}
	
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Enemy"))
		{
			if (transform.position.y > collision.gameObject.transform.position.y) 
			{
				Destroy(collision.gameObject);
				scoretext.GetComponent<Score>().score++;
			}
			else
			{
				die();
			}
		
			
		}
	}
	
	void OnCollisionStay2D(Collision2D collision)
	{
		ContactPoint2D point = collision.GetContact(0);
		Vector2 normal = point.normal;
		if (normal.x == 0 && normal.y == 1)
		{
			grounded = true;
		}
		if (collision.gameObject.tag == "Moving Platform")
		{
			transform.parent = collision.transform.parent;
		}
		
	}
	void OnCollisionExit2D(Collision2D collision)
	{
		grounded = false;
		if (collision.gameObject.tag == "Moving Platform")
		{
			transform.parent = null;
		}
	}
	
	
	
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Enemy") || other.gameObject.tag == "Projectile")
		{
			die();
			
		}
		else if (other.gameObject.CompareTag("Void"))
		{
			die();
		}
	}
	void die()
	{
		transform.position = StartPosition;
		rb.velocity = new Vector2();
		rb.angularVelocity = 0;
		justdied = true;
	}
}
