using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooty : MonoBehaviour
{
	public float startdelay;
	public float firedelay;
	public float projlife;
	public GameObject projectile;
	public enum Directions {Up, Down, Left, Right};
	public Directions direction;
    // Start is called before the first frame update
    void Start()
    {
		InvokeRepeating("Fire",startdelay,firedelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void Fire()
	{
		GameObject proj = Instantiate(projectile,transform.position,Quaternion.identity);
		projectile projscript = proj.GetComponent<projectile>();
		projscript.projlife = projlife;
		Rigidbody2D RB = proj.GetComponent<Rigidbody2D>();
		if (direction == Directions.Left) 
		{
		RB.velocity = new Vector2(-10,0);
		}
		else if (direction == Directions.Right) 
		{
		RB.velocity = new Vector2(10,0);
		}
		else if (direction == Directions.Up) 
		{
		RB.velocity = new Vector2(0,10);
		}
		else 
		{
		RB.velocity = new Vector2(0, -10);
		}
	}

}
