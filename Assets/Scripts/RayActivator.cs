using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayActivator : MonoBehaviour {

    private Camera _camera;

	// Use this for initialization
	void Start () {
        _camera = GetComponent<Camera>(); // Get reference to gameobject's camera component

        //Hiding the mouse cursor at the center of teh screen.
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor
        Cursor.visible = false; // makes cursor invisable
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            // Find middle of the screen using pixelWith and pixelHeight
            Vector3 centerPoint = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);

            Ray ray = _camera.ScreenPointToRay(centerPoint);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit)) // The raycast fills the reference variable with information. hit = the object hit by the ray.
            {
                GameObject hitObject = hit.transform.gameObject;
                CameraChange target = hitObject.GetComponent<CameraChange>();
                if(target != null)
                {
                    target.CameraChanger();
                    target.tempActivateStage();
                    Debug.Log("Target Hit");
                }

            }
        }
	}

    private void OnGUI()
    {
        int size = 12;
        float posX = _camera.pixelWidth / 2 - size / 4;
        float posY = _camera.pixelHeight / 2 - size / 2;

        GUI.Label(new Rect(posX, posY, size, size), "*"); // The command GUI.Label() dusplays text on screen
    }
}
