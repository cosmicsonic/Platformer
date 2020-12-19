using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
	public float projlife; 
	
	private float starttime;
    // Start is called before the first frame update
    void Start()
    {
        starttime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float timepassed = Time.time - starttime;
		if (timepassed > projlife) 
		{
			Destroy(gameObject);	
		}
    }
}
