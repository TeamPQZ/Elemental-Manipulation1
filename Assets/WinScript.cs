using UnityEngine;
using System.Collections;

public class WinScript : MonoBehaviour {

    public Vector2 WinPosition;
    public GameObject WinScreen;

    private bool TouchedIt;
	// Use this for initialization
	void Start () {
        TouchedIt = false;
	}
	
	// Update is called once per frame
	void Update () {
	
        if(new Vector2(transform.position.x,transform.position.y) == WinPosition && TouchedIt == false)
        {
            TouchedIt = true;
            WinScreen.gameObject.SetActive(true);
        }
	}
}
