using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {
    public int score = 0;
    public static int resultScore;
    public bool result; 

    public void AddScore() {
        score++;
    }

    public void SetScore()
    {
        resultScore = score;
    }

    // Use this for initialization
    void Start () {
        if (result == true)
        {
            score = resultScore;
            GetComponent<Text>().text = "Your Score\n" + score.ToString();
        }
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<UnityEngine.UI.Text>().text = "Your Score\n" + score.ToString();
    }
}
