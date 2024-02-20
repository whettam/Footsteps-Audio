using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{

    public GameObject footstep;
    public GameObject fastSteps;

    // Start is called before the first frame update
    void Start()
    {
        stopFootsteps();
    }

    // Update is called once per frame
    void Update()
    {
        //footsteps start after pressing "wasd"
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {
            //fast walk - stops slow footsteps and starts fast footsteps when shift held
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                stopSlow();
                fastFootsteps();
            }
            else 
            {
                stopFast();
                footsteps();
            }
        }
        //stop audio if "wasd" not pressed
        else 
        {
            stopFootsteps();
        }
    }

    //normal footstep audio
    void footsteps()
    {
        footstep.SetActive(true);
    }
    //fast footsteps audio
    void fastFootsteps()
    {
        fastSteps.SetActive(true);
    }
    //stop normal footstep audio
    void stopSlow()
    {
        footstep.SetActive(false);
    }
    //stop fast footsteps
    void stopFast() {
        fastSteps.SetActive(false);
    }
    //stop both normal and fast footstep audio
    void stopFootsteps()
    {
        stopFast();
        stopSlow();
    }
}
