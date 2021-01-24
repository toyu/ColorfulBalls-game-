using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public static float MAX_TIME = 4f; // カウントダウンの開始値
    float timeCounter = MAX_TIME;

    // Use this for initialization
    void Start () {
        GetComponent<UnityEngine.UI.Text>().text = MAX_TIME.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        if(timeCounter <= 1.0f && timeCounter >0.0f)
        {
            this.GetComponent<Text>().text = "Start!!";
        }
        else if(timeCounter <= 0.0f)
        {
            GameObject.Find("Desk").GetComponent<Desk>().ChangeColor();
            GameObject.Find("RedBall").GetComponent<BallMove>().First();
            GameObject.Find("BlueBall").GetComponent<BallMove>().First();
            GameObject.Find("GreenBall").GetComponent<BallMove>().First();
            GameObject.Find("YellowBall").GetComponent<BallMove>().First();
            GameObject.Find("BlackBall").GetComponent<BallMove>().First();
            GameObject.Find("Timer").GetComponent<LimiteTimer>().start = true;
            GameObject.Find("Desk").GetComponent<Mouse>().start = true;
            Destroy(gameObject);
        }
        else
        {
            GetComponent<UnityEngine.UI.Text>().text = ((int)timeCounter).ToString();
        }
        timeCounter -= Time.deltaTime;
    }
}
