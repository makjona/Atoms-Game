using UnityEngine;
using System.Collections;

public class BubbleCreator : MonoBehaviour {
    public GameObject bubble;
    public float regenerationRate;
    public float regenerationTime;

    public float difficultyIncreaseRate;

    public float timePassedPerBubble;
    public float timePassedTotal;

    // Use this for initialization
    void Start () {
        regenerationRate = 1f;
        regenerationTime = (1 / regenerationRate);
        timePassedPerBubble = 0;
        timePassedTotal = 0;
        difficultyIncreaseRate = 0.04f;
        enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
        timePassedPerBubble += Time.deltaTime;
        timePassedTotal += Time.deltaTime;

        if (timePassedPerBubble >= regenerationTime)
        {
            timePassedPerBubble -= regenerationTime;
            Instantiate(bubble);
        }

        regenerationRate += Time.deltaTime * (difficultyIncreaseRate);
        regenerationTime = (1 / regenerationRate);

    }
}
