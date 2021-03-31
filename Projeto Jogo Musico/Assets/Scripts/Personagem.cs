using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    // Start is called before the first frame update
     private float velocidade=1;
     Vector3 posicao= new Vector3 (-16,4,0);
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
  Destroy(gameObject);
    }
    
    }
}
