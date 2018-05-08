using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageTriggerScript : MonoBehaviour {

    public CameraChange switchCam;

    private void OnTriggerEnter(Collider other)
    {
        switchCam.CameraChanger();
        switchCam.tempActivateStage();
    }

}
