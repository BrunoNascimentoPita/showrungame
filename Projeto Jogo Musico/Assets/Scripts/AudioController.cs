using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioController : MonoBehaviour
{
    private static AudioController instance;

    public AudioSource BGM;
    public AudioClip musicMenuInicial;
    public AudioClip musicSelectFase;
    public AudioClip musicFase1;
    public AudioClip musicFase2;
    public AudioClip musicFase3;

    private int currentSceneIndex = 1;
    private Dictionary<int, AudioClip> sceneMusicMap;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        sceneMusicMap = new Dictionary<int, AudioClip>
        {
            { 0, musicMenuInicial },
            { 1, musicSelectFase },
            { 2, musicFase1 },
            { 3, musicFase2 },
            { 4, musicFase3 },
        };
    }

    void Start()
    {
        UpdateMusic();
    }

    void Update()
    {
        if (currentSceneIndex != SceneManager.GetActiveScene().buildIndex)
        {
            UpdateMusic();
        }
    }

    void UpdateMusic()
    {
        int newSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (sceneMusicMap.ContainsKey(newSceneIndex))
        {
            if (BGM.clip != sceneMusicMap[newSceneIndex])
            {
                changeBGM(sceneMusicMap[newSceneIndex]);
            }
        }
        else if (newSceneIndex == 5)
        {
            BGM.Stop();
        }

        currentSceneIndex = newSceneIndex;
    }

    public void PlayMusicSelectFase()
    {
        if (BGM.clip != musicSelectFase)
        {
            changeBGM(musicSelectFase);
        }
    }

    void changeBGM(AudioClip music)
    {
        BGM.Stop();
        BGM.clip = music;
        BGM.Play();
    }
}
