using UnityEngine;

public class LevelSelector : MonoBehaviour
{
    public AudioController audioController;

    void OnEnable()
    {
        audioController.PlayMusicSelectFase();
    }
}
