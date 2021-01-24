using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class HighScore : MonoBehaviour {
    private int highScore; //ハイスコア用変数
    private int score;
    private string key = "HIGH SCORE"; //ハイスコアの保存先キー
    GameObject scoreText;

    // Use this for initialization
    void Start () {
        
        scoreText = GameObject.Find("ResultScore");
        highScore = PlayerPrefs.GetInt(key, 0);
        score = scoreText.GetComponent<Score>().score;

        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt(key, highScore);
            PlayerPrefs.Save();
        }

        GetComponent<Text>().text = "High Score\n" + highScore.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
