using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugify : MonoBehaviour
{
	public Transform t1;
	public Transform t2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(t1.position-t2.position);
    }
}
