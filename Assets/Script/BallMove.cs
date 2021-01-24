using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour {

    private Rigidbody rb; // Rididbody
    float y;
    public float speed = 10.0f;
    public int num;
    public GameObject desk;

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "ball") {
            rb.velocity = rb.velocity.normalized * speed;
        }
        else if (other.gameObject.tag == "wall")
        {
            if (Mathf.Abs(rb.velocity.z) < 2.0f)
            {
                transform.Rotate(0.0f, rb.rotation.y + 90f, 0.0f);
                rb.AddForce(transform.forward * 1.5f, ForceMode.Impulse);
                rb.velocity = rb.velocity.normalized * speed;
            }
            if (Mathf.Abs(rb.velocity.x) < 2.0f)
            {
                transform.Rotate(0.0f, rb.rotation.y + 90f, 0.0f);
                rb.AddForce(transform.forward * 1.5f, ForceMode.Impulse);
                rb.velocity = rb.velocity.normalized * speed;
            }
        }
    }

    public void First()
    {
        // Rigidbody を取得
        rb = GetComponent<Rigidbody>();
        transform.Rotate(0.0f, y, 0.0f);
        rb.AddForce(transform.forward * speed, ForceMode.Impulse);
    }

    // Use this for initialization
    void Start () {
        y = Random.Range(0f, 359f);
    }

    public string layername;

    // Update is called once per frame
    void Update()
    {
        /*// マウスの左ボタンが押された瞬間の処理
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
                if (hit.collider.gameObject.GetComponent <BallMove>().num == d.color)
                {
                    d.ChangeColor();
                    GameObject.Find("Score").GetComponent<Score>().score++;
                }
                else if(hit.collider.gameObject.GetComponent<BallMove>().num != d.color)
                {
                    GameObject.Find("Timer").GetComponent<LimiteTimer>().timeCounter -= 1.0f;
                }
            }
        }*/
    }
}
