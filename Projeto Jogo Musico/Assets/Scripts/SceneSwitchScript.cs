using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchScript : MonoBehaviour
{

    public void EscolherFase()
    {
        SceneManager.LoadScene("Fase1");
    }

    public void Sair()
    {
        Application.Quit();
    }

}
