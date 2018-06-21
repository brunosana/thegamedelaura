using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogSystem : MonoBehaviour {
    public Text msg;
    public Canvas c;
    bool isRunning;
    public static bool start;
	void Awake () {
        c.enabled = false;
        isRunning = false;
        msg.text = "";
    }

    public void interact() {
        //controllerPlayer.setcanMove(false);
        //controllerNPC.setcanMove(false);
        c.enabled = true;
        msg.text = "Laura eu quero pica, aperte Y para me dar pica.";
        isRunning = true;
        Time.timeScale = 0f;
    }
    // Update is called once per frasme
    void Update () {
        if (start) {
            interact();
            start = false;
        }

        if (isRunning) {
            if (Input.GetKeyDown(KeyCode.Y)) {
                c.enabled = false;
                controllerPlayer.setcanMove(true);
                controllerNPC.setcanMove(true);
                Time.timeScale = 1f;
            }
        }		
	}

}
