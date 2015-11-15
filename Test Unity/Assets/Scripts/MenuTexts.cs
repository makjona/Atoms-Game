using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuTexts : MonoBehaviour {

    public Text title;
    public Text start;
    public Text about;
    public Text back;
    public Text aboutInfo;

    public Button start_b;
    public Button about_b;
    public Button back_b;

    // Use this for initialization
    void Start () {
        float ratio = Screen.height / 551;
        
        title.fontSize = (int) (ratio * 40);
        start.fontSize = (int)(ratio * 25);
        about.fontSize = (int)(ratio * 25);
        back.fontSize = (int)(ratio * 25);
        aboutInfo.fontSize = (int)(ratio * 20);

        title.GetComponent<RectTransform>().sizeDelta = new Vector2(ratio * 300, ratio * 50);
        start_b.GetComponent<RectTransform>().sizeDelta = new Vector2(ratio * 160, ratio * 30);
        about_b.GetComponent<RectTransform>().sizeDelta = new Vector2(ratio * 160, ratio * 30);
        back_b.GetComponent<RectTransform>().sizeDelta = new Vector2(ratio * 160, ratio * 30);
        aboutInfo.GetComponent<RectTransform>().sizeDelta = new Vector2(ratio * 250, ratio * 200);

        title.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, ratio * 120);
        about_b.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, ratio * -45);
        back_b.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, ratio * -180);
        aboutInfo.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, ratio * 0);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
