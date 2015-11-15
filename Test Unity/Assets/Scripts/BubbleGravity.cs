using UnityEngine;
using System.Collections;

public class BubbleGravity : MonoBehaviour {

    public float gravity;

	// Use this for initialization
	void Start ()
    {
        gravity = Random.value * 4 + 1;
	}
	
	// Update is called once per frame
	void Update ()
    {
        this.transform.Translate(0, (float) (Time.deltaTime * gravity), 0);
	}
}
