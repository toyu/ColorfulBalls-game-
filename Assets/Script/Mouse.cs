using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour {
    public bool start = false;
    Desk d;
    AudioSource audioSource;
    public AudioClip maru, batu;
    
    //Use this for initialization
	void Start () {
        d = GetComponent<Desk>();
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (start == true) {
            if (Input.GetMouseButtonDown(0))
            {
                // カメラからマウスクリック点に向けて Ray（光線）を放つ
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                // RayCastHit 構造体のインスタンスを作成
                RaycastHit hit = new RaycastHit();
                // Ray に当たるコライダーがあれば
                if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.tag == "ball")
                {
                    //hit.collider.gameObject
                    if (hit.collider.gameObject.GetComponent<BallMove>().num == d.color)
                    {
                        audioSource.clip = maru;
                        audioSource.Play();
                        d.ChangeColor();
                        GameObject.Find("Score").GetComponent<Score>().score++;
                    }
                    else
                    {
                        audioSource.clip = batu;
                        audioSource.Play();
                        GameObject.Find("Timer").GetComponent<LimiteTimer>().timeCounter -= 3.0f;
                    }
                }
            }
        }
    }
}
