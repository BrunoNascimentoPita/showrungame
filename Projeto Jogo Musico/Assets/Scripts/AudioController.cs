using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioController : MonoBehaviour
{
    private static AudioController instance;

    public AudioSource BGM;
    public AudioClip musicFase1;
    public AudioClip musicFase2;
    public AudioClip musicFase3;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);

        }

        else
        {
            Destroy(gameObject);
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
           BGM.Stop();
        }

        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
           BGM.Stop(); 
        }

        if(SceneManager.GetActiveScene().buildIndex == 2)
        {
           if (BGM.clip != musicFase1)
           {
               changeBGM(musicFase1);
           }  
        }

        if(SceneManager.GetActiveScene().buildIndex == 3)
        {
           if (BGM.clip != musicFase2)
           {
               changeBGM(musicFase2);
           }  
        }

        if(SceneManager.GetActiveScene().buildIndex == 4)
        {
           if (BGM.clip != musicFase3)
           {
               changeBGM(musicFase3);
           }  
        }

        void changeBGM(AudioClip music)
        {
            BGM.Stop();
            BGM.clip = music;
            BGM.Play();
        }




    }
}
