using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public GameObject gameOver;
    public GameObject winTela;
    public GameObject pauseTela;
   

    public static GameController instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void RestartGame(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
        Time.timeScale = 1;
    }

    public void ShowWinTela()
    {
        winTela.SetActive(true);
    }

    public void ShowPauseTela()
    {
        
        pauseTela.SetActive(true);

        Time.timeScale = 0;
    }

    public void Resume()
    {
        pauseTela.SetActive(false);
        Time.timeScale = 1;
    }
    

}
