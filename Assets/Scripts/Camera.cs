﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
	public Transform followTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
	{
    }
	private void LateUpdate()
	{
		this.transform.position = new Vector3(followTransform.position.x, followTransform.position.y, this.transform.position.z);
	}
}