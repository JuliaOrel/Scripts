using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenu : MonoBehaviour
{
// Start is called before the first frame update
public void PlayFirsTLevel()
{
    SceneManager.LoadScene("Scenes/Level_1");
}

public void AboutGame()
{
    SceneManager.LoadScene("Scenes/About");
}

public void Settings()
{
    SceneManager.LoadScene("menu");
}

public void Levels()
{
    SceneManager.LoadScene("menu");
}

public void Quit()
{
    UnityEditor.EditorApplication.isPlaying = false;
    Debug.Log("We are quit");
    //Application.Quit();
}
}