using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject winUI;
    public GameObject failUI;
    public void gameOver()
    {
        Player.gameover = true;
        winUI.SetActive(true);
    }

    public void fail()
    {
        Player.gameover = true;
        failUI.SetActive(true);
    }
    public void restart()
    {
        Player.gameover = false;
        SceneManager.LoadScene("Main");
    }
}
