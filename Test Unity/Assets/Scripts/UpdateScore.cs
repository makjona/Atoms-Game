using UnityEngine;
using System.Collections;

public class UpdateScore : MonoBehaviour {

    public static int lives;
    public static int bubblesHit;
    public Font font;

    // Use this for initialization
    void Start () {
        lives = 3;
        bubblesHit = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {

	}

    void OnGUI()
    {
        float ratio = Screen.height / 551;
        GUIStyle style = new GUIStyle();
        style.fontSize = (int)ratio*18;
        style.normal.textColor = Color.white;
        style.font = font;
        GUI.Label(new Rect(ratio*10, ratio*10, ratio*100, ratio*20), "Lives: " + lives, style);
        GUI.Label(new Rect(ratio*200, ratio*10, ratio*100, ratio*20), "Hit: " + bubblesHit, style);
    }
}
