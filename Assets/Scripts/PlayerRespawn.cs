using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    private float checkPointPositionX, checkPointPositionY;
    // Update is called once per frame

    public Animator animator;

    void Start()
    {
        if(PlayerPrefs.GetFloat("checkPointX") != 0)
        {
            transform.position = new Vector2(PlayerPrefs.GetFloat("checkPointX"), PlayerPrefs.GetFloat("checkPointY"));
        }
    }


    public void ReachedCheckPoint(float x, float y)
    {
        PlayerPrefs.SetFloat("checkPointX", x);
        PlayerPrefs.SetFloat("checkPointY", y);

    }

    public void PlayerDamaged()
    {
        animator.Play("Hit");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
