using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Personagem : MonoBehaviour
{
    // Seta a velocidade 
      private float velocidade=3;
      private float velocidade1=0;
      public bool isJumping;
    //Seta o pulo
      private float JumpForce=5;
      private Rigidbody2D rig;
     // Seta a posição inicial como ponto de reviver
      Vector3 reviver= new Vector3 (0,0,0);

    //muda a posição do personagem pra primeira passagem e muda a direção//
      Vector3 passagemPraBaixo1= new Vector3 (32.7f,-4,0);
      Vector2 passagemPraBaixo1rotate= new Vector2 (0,180);

    //muda a posição do personagem pra segunda passagem e muda para a direção inicial//
      Vector3 passagemPraBaixo2= new Vector3 (0,-8,0);
      Vector2 passagemPraBaixo2rotate= new Vector2 (0,0);
    
      void Start()
    {
         rig= GetComponent<Rigidbody2D>();
    }

    
      void Update()
    {
      // Determina que o personagem andará 1*segundo de tempo e para pressionando espaço
       if (Input.GetAxisRaw("Jump") > 0)
        {
           transform.Translate(Vector2.right * velocidade1 * Time.deltaTime); 
        }else{
       transform.Translate(Vector2.right * velocidade * Time.deltaTime); 
        }
        Jump();

    }

    // Colisor com is trigger ativo
    
    void OnTriggerEnter2D(Collider2D other) 
    {
      
      // Determina que qualquer objeto com a tag obstaculo faça com que ele der respawn pro inicio
     if (other.gameObject.tag == "obstaculo")
    {
       Time.timeScale = 0;
       GameController.instance.ShowGameOver();
       Destroy(gameObject);
    }
  
    //Determina que quando ele tocar no objeto vazio com a tag passagemPraBaixo1 ele mude a posição do personagem determinada na variável
      if (other.gameObject.tag == "PassagemPraBaixo1")
    {
     this.gameObject.transform.position = passagemPraBaixo1;
     this.gameObject.transform.eulerAngles = passagemPraBaixo1rotate;
    }

     //Determina que quando ele tocar no objeto vazio com a tag passagemPraBaixo2 ele mude a posição do personagem determinada na variável
     if (other.gameObject.tag == "PassagemPraBaixo2")
    {
     this.gameObject.transform.position = passagemPraBaixo2;
     this.gameObject.transform.eulerAngles = passagemPraBaixo2rotate;
    }
    }
    void Jump (){
    if(Input.GetKeyDown(KeyCode.UpArrow) && !isJumping){
    rig.AddForce(new Vector2(0f,JumpForce), ForceMode2D.Impulse);
}
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            isJumping = false;
        }

    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            isJumping = true;
        }
    }
}
