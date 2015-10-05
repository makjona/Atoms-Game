using UnityEngine;
using System.Collections;

public class BubbleDelete : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.y > 2){
            GameObject bubble = (GameObject)Instantiate(Resources.Load("Bubble"));
            Destroy(this.gameObject);
        }
	}
}
