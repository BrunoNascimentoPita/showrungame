using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    Personagem Player;
    //Seta pra variável player o personagem
     void Start()
    {
       Player= gameObject.transform.parent.gameObject.GetComponent<Personagem>(); 
    }

    //Checa a colisão do groundcheck com o chao
void OnCollisionEnter2D(Collision2D colisor){
if(colisor.gameObject.layer == 6){
Player.isJumping=false;
}

}
//Checa a saída de colisão do groundcheck com o chao
void OnCollisionExit2D(Collision2D colisor){
if(colisor.gameObject.layer == 6){
Player.isJumping=true;
}

}
   
}
