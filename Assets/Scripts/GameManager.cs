using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    public bool isGamePaused = false;

    public GameObject loseScreenUI;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        loseScreenUI.SetActive(false);
        PauseGame(true);
    }


    public void SetupEndUI()
    {
        loseScreenUI.SetActive(true);
        PauseGame(true);

    }

    public void PauseGame(bool isPaused)
    {
        if (isPaused)
        {
            isGamePaused = true;
            Time.timeScale = 0;
        }
        else
        {
            isGamePaused = false;
            Time.timeScale = 1;
        }
       
    }

    public void RestartRun()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
