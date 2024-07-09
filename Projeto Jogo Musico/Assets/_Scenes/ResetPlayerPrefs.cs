using UnityEngine;

public class ResetPlayerPrefs : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Check if the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // This will delete all keys and values from the PlayerPrefs
            PlayerPrefs.DeleteAll();

            // If you want to delete a specific key instead of all keys, use:
            // PlayerPrefs.DeleteKey("your_key");

            // Log to console to confirm reset
            Debug.Log("PlayerPrefs have been reset.");
        }
    }
}
