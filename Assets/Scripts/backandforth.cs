using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backandforth : MonoBehaviour
{
	private Vector2 pos1;
	private float xdif = 0.0f;
	private float ydif = 0.0f;
	public float duration;
    // Start is called before the first frame update
    void Start()
    {
		pos1 = new Vector2(transform.position.x,transform.position.y);
		Transform GoTo = transform.Find("Go To");
		xdif = GoTo.position.x - pos1.x;
		ydif = GoTo.position.y - pos1.y;
    }

    // Update is called once per frame
    void Update()
    {
		float xpos;
		float ypos;
		float progress = (Time.time%(duration*2));
		if (progress > duration) 
		{
			progress = duration*2 - progress;
		}
		progress = progress/duration;
		xpos = (progress)*xdif + pos1.x;
		ypos = (progress)*ydif + pos1.y;
		transform.position = new Vector2(xpos,ypos); 
	}
}
