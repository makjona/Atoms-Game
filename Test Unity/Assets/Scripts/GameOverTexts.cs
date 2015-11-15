using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverTexts : MonoBehaviour {

    public Text gameOver;
    public Text start;
    public Text menu;
    public Text score;
    public Text bestScore;

    public Button start_b;
    public Button menu_b;

    // Use this for initialization
    void Start () {
        float ratio = Screen.height / 551;

        gameOver.fontSize = (int) (ratio * 35);
        start.fontSize = (int)(ratio * 25);
        menu.fontSize = (int)(ratio * 25);
        score.fontSize = (int)(ratio * 20);
        bestScore.fontSize = (int)(ratio * 20);

        start_b.GetComponent<RectTransform>().sizeDelta = new Vector2(ratio * 185, ratio * 30);
        menu_b.GetComponent<RectTransform>().sizeDelta = new Vector2(ratio * 185, ratio * 30);

        gameOver.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, ratio * 165);
        start_b.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, ratio * -60);
        menu_b.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, ratio * -105);
        score.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, ratio * 45);
        bestScore.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, ratio * 0);

        score.text = "Score: " + UpdateScore.bubblesHit;
        bestScore.text = "Best: " + PlayerPrefs.GetInt("BestScore");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
