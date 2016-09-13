using UnityEngine;
using System.Collections;

public class WinScript : MonoBehaviour {

    public Vector2 WinPosition;
    public GameObject WinScreen;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        if(new Vector2(transform.position.x,transform.position.y) == WinPosition)
        {
            WinScreen.gameObject.SetActive(true);
        }
	}
}
