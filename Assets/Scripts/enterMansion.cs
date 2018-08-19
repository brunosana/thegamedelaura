using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enterMansion : MonoBehaviour {
    public Transform canvas;
    private bool isIn = false;
    private void Awake()
    {
        canvas.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.F) && isIn && gameManager.mapHaveKey) {SceneManager.LoadScene("02Scene");}
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        canvas.gameObject.SetActive(true);
        isIn = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canvas.gameObject.SetActive(false);
        isIn = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        isIn = true;
    }
}
