using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Personagem : MonoBehaviour
{
    // Seta a velocidade 
      public float velocidade;
      private float velocidade1=0;
      public bool isJumping;
      private Animator anim;

    //Seta o pulo
      private float JumpForce=0;
      private Rigidbody2D rig;
     // Seta a posição inicial como ponto de reviver
      Vector3 reviver= new Vector3 (0,0,0);

    //muda a posição do personagem pra primeira passagem e muda a direção//
      Vector3 passagemPraCima1= new Vector3 (27.42f,-5.23f,0);
      Vector2 passagemPraCima1rotate= new Vector2 (0,180);

    //muda a posição do personagem pra segunda passagem e muda para a direção inicial//
      Vector3 passagemPraCima2= new Vector3 (5.11f,-1.19f,0);
      Vector2 passagemPraCima2rotate= new Vector2 (0,0);
    
      void Start()
    {
         rig= GetComponent<Rigidbody2D>();
         anim = GetComponent<Animator>();
    }

    
      void Update()
    {
      // Determina que o personagem andará 1*segundo de tempo e para pressionando espaço
       if (Input.GetAxisRaw("Jump") > 0)
        {
           transform.Translate(Vector2.right * velocidade1 * Time.deltaTime);
           anim.SetBool("walk", true);  
        }
        else
        {
            transform.Translate(Vector2.right * velocidade * Time.deltaTime);
            anim.SetBool("walk", false); 
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
  
    //Determina que quando ele tocar no objeto vazio com a tag passagemPraCima1 ele mude a posição do personagem determinada na variável
      if (other.gameObject.tag == "PassagemPraCima1")
    {
     this.gameObject.transform.position = passagemPraCima1;
     this.gameObject.transform.eulerAngles = passagemPraCima1rotate;
    }

     //Determina que quando ele tocar no objeto vazio com a tag passagemPraCima2 ele mude a posição do personagem determinada na variável
     if (other.gameObject.tag == "PassagemPraCima2")
    {
     this.gameObject.transform.position = passagemPraCima2;
     this.gameObject.transform.eulerAngles = passagemPraCima2rotate;
    }

    if (other.gameObject.tag == "win")
    {
      Debug.Log("Colidiu");
      GameController.instance.ShowWinTela();
      Destroy(gameObject);
      //PlayerPrefs.SetInt("faseAtual", SceneManager.GetActiveScene().buildIndex);
      if(SceneManager.GetActiveScene().buildIndex>PlayerPrefs.GetInt("faseCompletada"))
      {
        PlayerPrefs.SetInt("faseCompletada", SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.Save();
      }
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
