using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    //define the cameras. make a private variable that tells you what camera you are on. This way, the rearview camera goes back to the correct one.
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    private int CamMode;

    // Update is called once per frame
    void Update()
    {        
        //if key pressed, set all cameras besides the one you want to not active. Also, sets CamMode variable to 0.
        // third person cam is 0 because when the game starts CamMode is at 0 and third person cam is the one it starts with.
        if (Input.GetKeyDown(KeyCode.J))
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);
            CamMode = 0;
        }

        //same as above, just different key and CamMode value. Third person is 0, and first person is 1.
        if (Input.GetKeyDown(KeyCode.K))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(false);
            CamMode = 1;
        }

        //same as above except don't change CamMode value.
        if (Input.GetKeyDown(KeyCode.L))
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
        }

        //when key is released, go back to the camera you were using. This is where CamMode comes into play.
        if (Input.GetKeyUp(KeyCode.L))
        {
            cam3.SetActive(false);

            //if the CamMode variable is 0 (value for third person cam), go back to the third person cam. Also, set the value to third person cam just to be sure.
            if (CamMode == 0)
            {
                cam1.SetActive(true);
                cam2.SetActive(false);
                CamMode = 0;
            }

            ////if the CamMode variable is 1 (value for first person cam), go back to the first person cam. Also, set value to first person cam just to be sure.
            if (CamMode == 1)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
                CamMode = 1;
            }
        }
    }
}