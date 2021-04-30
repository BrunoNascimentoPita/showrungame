using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchScript : MonoBehaviour
{

    public void EscolherFase1()
    {
        SceneManager.LoadScene("Fase1");
    }

    public void EscolherFase2()
    {
        SceneManager.LoadScene("Fase2");
    }

    public void EscolherFase3()
    {
        SceneManager.LoadScene("Fase3");
    }

    public void Sair()
    {
        Application.Quit();
    }

}
