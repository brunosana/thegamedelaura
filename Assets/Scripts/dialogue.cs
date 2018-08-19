using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogue : MonoBehaviour {
    public Transform canvas;
    public Text text;
    public string Name;
    private void Awake()
    {
        canvas.gameObject.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) { talk(); }
    }

    void talk() {
        Time.timeScale = 0;
        canvas.gameObject.SetActive(true);
        if (Name.Equals("Bruno")) { text.text = "SANA \n     " + gameManager.TextSanaOut(); }
        else { if (Name.Equals("Icaro")) { text.text = "ICARO \n     " + gameManager.TextIcaroOut(); } }
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E)) { Time.timeScale = 1;  canvas.gameObject.SetActive(false); }
    }

}
