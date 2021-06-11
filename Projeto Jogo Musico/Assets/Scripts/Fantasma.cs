using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasma : MonoBehaviour
{

    public float tempoMinimo = 3f;
    public float tempoMaximo;
    public float speed;
    private float tempo = 0;
    private AudioSource sound;


    void Awake()
    {
        sound = GetComponent<AudioSource>();
    } 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.left * speed * Time.deltaTime;

        tempo += Time.deltaTime;

        if (tempo< tempoMinimo)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

        if(tempo> tempoMinimo)
        {
        transform.position += Vector3.up * speed * Time.deltaTime;
        }

        if(tempo > tempoMaximo)
        {
            tempo = 0;
        }

    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            sound.Play();
            Destroy(this.gameObject, 0.1f);
        }

    }
}
