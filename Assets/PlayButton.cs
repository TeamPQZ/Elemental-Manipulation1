using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

    public Slider Slideren;
    public Text PlayText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame, faggot
	void Update () {
        PlayText.text = "Play level " + Slideren.value;
	
	}

    public void OnMagicClick()
    {
        SceneManager.LoadScene(Mathf.RoundToInt(Slideren.value));
    }
}
