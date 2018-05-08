using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

    public GameObject player;
    public Camera overHeadCam;

    public GameObject stage;
    

    public KeyCode testSwitchKey = KeyCode.T;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(testSwitchKey))
        {
            CameraChanger();
            tempActivateStage();
        }
	}

    public void CameraChanger()
    {
        if (player.activeSelf)
        {
            overHeadCam.gameObject.SetActive(true);
            player.SetActive(false);

            Cursor.lockState = CursorLockMode.None; // locking the cursor
            Cursor.visible = true; // making it invisable/visable
        }
        else if (overHeadCam.gameObject.activeSelf)
        {
            player.SetActive(true);
            overHeadCam.gameObject.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked; // locking the cursor
            Cursor.visible = false; // making it  invisable/visable
        }
    }

    public void tempActivateStage()
    {
        if (!stage.activeSelf)
        {
            stage.SetActive(true);
        }
        else if (stage.activeSelf)
        {
            stage.SetActive(false);
        }
    }
}
