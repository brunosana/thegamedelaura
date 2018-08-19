using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showMessage : MonoBehaviour {
    public Transform canvas;
    public Transform pressF;
    public GameObject obj;
    private bool isIn = false;
    int n = 0;
    public void show() {
        gameManager.pickPaper();
        pressF.gameObject.SetActive(false);
        canvas.gameObject.SetActive(true);
        Time.timeScale = 0;}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && isIn) { canvas.gameObject.SetActive(false); Time.timeScale = 1; Destroy(obj); n=0; }
        if (Input.GetKey(KeyCode.F) && isIn && n == 0) { n= 1; show(); gameManager.pickedPaper = true; }
    }

    private void Awake()
    {
        canvas.gameObject.SetActive(false);
        pressF.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isIn = true;
        pressF.gameObject.SetActive(true);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        isIn = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isIn = false;
        pressF.gameObject.SetActive(false);
    }
}
