using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fails : MonoBehaviour
{
	public int fails = 0;
	private Text fText;
    // Start is called before the first frame update
    void Start()
    {
        fText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        fText.text = "Fails:" + fails.ToString();
    }
}
