using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
	public float speed;
	private Rigidbody2D rb;
	private float direction = -1.0f;
	private int calls = 0;
	public int turn = 200;
    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
		if (calls >= turn) 
		{
		
			if (direction == 1.0f) 
			{
				direction = -1.0f;
			}
			else 
			{
				direction = 1.0f;
			}
			calls = 0;
		}
		float horizontalInput = direction*speed;
        Vector2 Vec = new Vector2(horizontalInput,0.0f);
		rb.AddForce(Vec);
		calls += 1;
		
    }
}
