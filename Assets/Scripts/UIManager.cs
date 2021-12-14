using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject optionsPanel;


    public void OptionsPanel() 
    {
        Time.timeScale = 0;
        optionsPanel.SetActive(true);
    }

    public void Return() 
    {
        Time.timeScale = 1;
        optionsPanel.SetActive(false);
    }

    public void Quit() 
    {
        Application.Quit();
    }

    public void Restart() 
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    void FixedUpdate() 
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (optionsPanel.activeInHierarchy) 
            {
                Return();
            }
            else 
            {
                OptionsPanel();
            }
        }
    }
}
