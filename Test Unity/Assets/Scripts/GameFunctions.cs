using UnityEngine;
using System.Collections;

public class GameFunctions : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("Menu");
        }

        if (UpdateScore.lives <= 0)
        {
            if (PlayerPrefs.HasKey("BestScore"))
            {
                if (PlayerPrefs.GetInt("BestScore") < UpdateScore.bubblesHit)
                    PlayerPrefs.SetInt("BestScore", UpdateScore.bubblesHit);
            }
            else
            {
                PlayerPrefs.SetInt("BestScore", UpdateScore.bubblesHit);
            }
            Application.LoadLevel("GameOver");
        }
    }
}
