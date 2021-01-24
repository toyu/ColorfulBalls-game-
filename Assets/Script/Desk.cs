using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk : MonoBehaviour {
    public Material[] material;
    public int color = 0, prev = -1;

    public void ChangeColor()
    {
        do
        {
            color = Random.Range(0, 4);
            this.GetComponent<Renderer>().material = material[color];
        } while (prev == color);

        prev = color;
    }
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
