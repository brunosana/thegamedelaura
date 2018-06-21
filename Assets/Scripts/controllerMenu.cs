using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controllerMenu : MonoBehaviour {

	public void jogar(){
		SceneManager.LoadScene("02Scene");
		Debug.Log("Caregando...");	
	}
	public void opcoes(){
		Debug.Log("Item ainda não configurado");	
	}
	public void sair(){
		//Application.Quit();
		Debug.Log("Jogo Encerrado");
	}
}
