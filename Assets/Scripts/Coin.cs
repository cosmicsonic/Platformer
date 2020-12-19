using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
	private GameObject scoretext;
    // Start is called before the first frame update
    void Start()
    {
        scoretext = GameObject.Find("Score Text");
	}

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			Destroy(gameObject);
			scoretext.GetComponent<Score>().score++;
		}
	}
}
