using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelPoints : MonoBehaviour
{   
    public string lvlName;
    public string lvlName1;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(lvlName);
             Time.timeScale = 1;
        }
    } 
    public void changeSceneChoose(){
         SceneManager.LoadScene(lvlName1);
           Time.timeScale = 1;
    }
    public void changeScene(){
         SceneManager.LoadScene("_MenuInicial");
          Time.timeScale = 1;
    }
    public void level2(){
         SceneManager.LoadScene("Fase2");
          Time.timeScale = 1;
    }
      public void tryagain(){
         SceneManager.LoadScene("Fase1");
         Time.timeScale = 1;
    }

public void level3(){
         SceneManager.LoadScene("Fase3");
          Time.timeScale = 1;
    }
    public void final(){
         SceneManager.LoadScene("Final");
          Time.timeScale = 1;
    }



}
