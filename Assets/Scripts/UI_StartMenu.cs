using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        gameObject.SetActive(false);
        GameManager.instance.PauseGame(false);
    }
}
