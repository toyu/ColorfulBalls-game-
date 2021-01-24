using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LimiteTimer : MonoBehaviour {
    public static float MAX_TIME = 30f; // カウントダウンの開始値
    public float timeCounter = MAX_TIME;
    public bool start = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (start == true)
        {
            if (timeCounter <= 1.0f)
            {
                GameObject.Find("Score").GetComponent<Score>().SetScore();
                SceneManager.LoadScene("Result");
            }
            GetComponent<UnityEngine.UI.Text>().text = ((int)timeCounter).ToString();
            timeCounter -= Time.deltaTime;
        }
    }
}