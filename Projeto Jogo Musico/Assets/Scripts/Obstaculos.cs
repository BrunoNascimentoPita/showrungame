using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float zRotation;

    private AudioSource sound;


    void Awake()
    {
        sound = GetComponent<AudioSource>();
    } 

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        rotationObst();
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            sound.Play();
            Destroy(this.gameObject, 0.1f);
        }

    }

    private void rotationObst()
    {
        zRotation = zRotation + Time.deltaTime * 50;
        transform.rotation = Quaternion.Euler(0, 0, zRotation);
    }
}
