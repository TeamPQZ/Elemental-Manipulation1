using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonScropt : MonoBehaviour {

    public GameObject Panel;

    public void LoadSceneNumber(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void QuitTheGame()
    {
        Application.Quit();
    }

    public void DenDerKnap()//Lol funny name
    {
        if(Panel.activeSelf == true)
        {
            Panel.SetActive(false);
        }
        else if(Panel.activeSelf == false)
        {
            Panel.SetActive(true);
        }
    }
}
