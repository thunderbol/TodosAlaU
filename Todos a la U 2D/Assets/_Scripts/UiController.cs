using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiController : MonoBehaviour
{
    
    public void PlayGame()
    {
        SceneManager.LoadScene("PinguinosGame");
    }

    public void Levels()
    {
        SceneManager.LoadScene("SelectLevels");
    }


    public void Menuinitial()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
