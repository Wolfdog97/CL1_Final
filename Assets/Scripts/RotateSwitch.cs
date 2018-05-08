using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSwitch : MonoBehaviour {

    public List<GameObject> objsToRotate;
    public List<GameObject> switches;
    public List<ColorChanger> colorTriggers;

    public Animator anim;

    public bool onContact;

    public float degrees = 90f;



    private void Update()
    {
        int numColored = 0;
        foreach (ColorChanger thisColorChanger in colorTriggers)
        {
            if (thisColorChanger.isColored == true)
            {
                numColored++;
            }
        }

        if (numColored == colorTriggers.Count)
        {

            foreach (GameObject obj in objsToRotate)
            {

                obj.SetActive(false);

                Debug.Log("this is running");
                //anim.SetBool("rotateActive", true);
                //anim.SetBool("idle", false);
            }

        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (onContact)
        {
            Debug.Log("Contact!");
            RotateObject();
        }
    }

    public void RotateObject()
    {
        foreach (GameObject obj in objsToRotate)
        {
            obj.transform.Rotate(0, 90f, 0);
        }
    }

    public void colorSwitch()
    {
        
        int numColored = 0;
        foreach (ColorChanger thisColorChanger in colorTriggers)
        {
            if (thisColorChanger.isColored == true)
            {
                numColored++; 
            }
        }

        if (numColored == colorTriggers.Count)
        {
            
            foreach (GameObject obj in objsToRotate)
            {
                obj.transform.Rotate(0, 90f, 0);
                break;
            }
           
        }

	}
}
