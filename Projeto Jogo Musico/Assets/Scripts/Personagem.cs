using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Personagem : MonoBehaviour
{
    // Start is called before the first frame update
     private float velocidade=3;
     Vector3 posicao= new Vector3 (0,0,0);
       Vector3 proximo1= new Vector3 (32.7f,-4,0);
       Vector2 proximo1rotate= new Vector2 (0,180);
         Vector3 proximo2= new Vector3 (0,-8,0);
           Vector2 proximo2rotate= new Vector2 (0,0);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector2.right * velocidade * Time.deltaTime); 
    }
    
    void OnTriggerEnter2D(Collider2D other) 
    {
     if (other.gameObject.tag == "obstaculo")
    {
 this.gameObject.transform.position = posicao;
    }
      if (other.gameObject.tag == "proximo1")
    {
 this.gameObject.transform.position = proximo1;
 this.gameObject.transform.eulerAngles = proximo1rotate;
    }
     if (other.gameObject.tag == "proximo2")
    {
 this.gameObject.transform.position = proximo2;
 this.gameObject.transform.eulerAngles = proximo2rotate;
    }
    }
}
