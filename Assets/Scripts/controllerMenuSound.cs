using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerMenuSound : MonoBehaviour {

	public AudioSource FX;
	public AudioClip hoverFx;
	public AudioClip selectFx;

	public void hoverSound(){
		FX.PlayOneShot(hoverFx);
	}
	public void clickSound(){
		FX.PlayOneShot(selectFx);
	}
}
