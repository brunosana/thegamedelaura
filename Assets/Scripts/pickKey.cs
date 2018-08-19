using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickKey : MonoBehaviour {
    public GameObject obj;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) { gameManager.endQuest(); gameManager.mapHaveKey = true;  Destroy(obj); }
    }
}
