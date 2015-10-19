using UnityEngine;
using System.Collections;

public class BubbleDelete : MonoBehaviour {

    public const float xRange = (float)(18 - 0.64);

    public Animator anim;

    private bool destroyBubble;

    // Use this for initialization
    void Start ()
    {
        this.gameObject.transform.Translate(Random.value * xRange - xRange / 2, 0, 0);
        //anim.AddClip(new AnimationClip(), "destroy");
        anim = GetComponent<Animator>();
        destroyBubble = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(this.transform.position.y > 5.34)
        {
            Destroy(this.gameObject);
            UpdateScore.bubblesMissed++;
        }
        if(destroyBubble && (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > anim.GetCurrentAnimatorStateInfo(0).length))
        {
            print(anim.GetCurrentAnimatorStateInfo(0).normalizedTime + " | " + anim.GetCurrentAnimatorStateInfo(0).length);
            Destroy(this.gameObject);
        }
	}

    void OnMouseDown()
    {
        anim.Play("Destroy", 0);
        destroyBubble = true;
        //Destroy(this.gameObject);
        UpdateScore.bubblesHit++;
    }
}
