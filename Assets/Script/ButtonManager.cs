using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject gamePaused;

    // Update is called once per frame
    void Update()
    {
        inGameMenu();
    }

        public void selectlevel()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ExitApps()
    {
        Application.Quit();
        Debug.Log("Aplikasi dihentikan");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void socmed1()
    {
        Application.OpenURL("www.facebook.com/zidhan yanotama");
    }

    public void levelReset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void unPaused()
    {
        Time.timeScale = 1;
        gamePaused.SetActive(false);

    }

    public void inGameMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            gamePaused.SetActive(true);

        }
    }

}
