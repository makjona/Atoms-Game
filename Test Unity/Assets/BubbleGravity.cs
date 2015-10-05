using UnityEngine;
using System.Collections;

public class BubbleGravity : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        this.transform.Translate(0, (float) (Time.deltaTime * 2), 0);
	}
}
