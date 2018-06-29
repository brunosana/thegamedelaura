using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerPlayer : MonoBehaviour {

	Animator Animador;
	public float velocidade;
	Rigidbody2D rb2d;
	void Awake () {
		rb2d = GetComponent<Rigidbody2D>();
		Animador = GetComponent<Animator>();
	}
	
	void Update () {
		Animador.SetBool("parado",true);
		Animador.SetBool("esquerda",false);
		Animador.SetBool("direita",false);
		Animador.SetBool("norte",false);
		Animador.SetBool("sul",false);
		rb2d.velocity = new Vector2(0,0);
		if(Input.GetKey(KeyCode.D)){
            float verify = 0;
            if (Input.GetKey(KeyCode.S)) { verify = -velocidade; }
            else { if (Input.GetKey(KeyCode.W)) { verify = velocidade; } }
			Animador.SetBool("parado",false);
			Animador.SetBool("direita",true);
			rb2d.velocity = new Vector2(velocidade, verify);
		}else if(Input.GetKey(KeyCode.A)){
            float verify = 0;
            if (Input.GetKey(KeyCode.W)) { verify = velocidade; }
            else { if (Input.GetKey(KeyCode.S)) { verify = -velocidade; } }
			Animador.SetBool("parado",false);
			Animador.SetBool("esquerda",true);
			rb2d.velocity = new Vector2(-velocidade, verify);
		}else if(Input.GetKey(KeyCode.W)){
            float verify = 0;
            if (Input.GetKey(KeyCode.A)) { verify = -velocidade; }
            else { if (Input.GetKey(KeyCode.D)) { verify = velocidade; } }
			Animador.SetBool("parado",false);
			Animador.SetBool("norte",true);
			rb2d.velocity = new Vector2(verify ,velocidade);
		}else if(Input.GetKey(KeyCode.S)){
            float verify = 0;
            if (Input.GetKey(KeyCode.A)) { verify = -velocidade; }
            else { if (Input.GetKey(KeyCode.D)) { verify = velocidade; } }
            Animador.SetBool("parado",false);
			Animador.SetBool("sul",true);
			rb2d.velocity = new Vector2(verify,-velocidade);
		}
            
	}
}