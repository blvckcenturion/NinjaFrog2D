using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{
    public Text levelCleared;

    public void Update()
    {
        AllFruitsCollected();
    }


    public void AllFruitsCollected()
    {
        if(transform.childCount == 0)
        {
            Debug.Log("All fruits collected");
            levelCleared.gameObject.SetActive(true);
            Invoke("ChangeScene", 2f);
        }
    }

    void ChangeScene()
    {
        if(SceneManager.GetActiveScene().buildIndex != 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } else {
            Time.timeScale = 0;
        }
    }
}
