using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseAudio : MonoBehaviour
{
    //define the things that I want like which audio to use.
    public AudioSource music1;
    public AudioSource music2;
    public AudioSource music3;
    public AudioSource sound;
    public GameObject Player;

    //when there is a collision with the collider
    void OnTriggerEnter(Collider other)
    {
        //get the location of the player
        float Player_x = Player.transform.position.x;
        float Player_y = Player.transform.position.y;
        float Player_z = Player.transform.position.z;

        //only do what is in {} if the collider is the player which was assigned.
        if (other.tag == "Player")
        {
            //plays the creepy sound and then lowers the volume of the background music. have to use one "=" sign and put an "f" at the end for it to work.
            sound.Play();
            music1.volume = 0.3f;
            music2.volume = 0.3f;
            music3.volume = 0.25f;
        }
        
    }

    //when exiting the collider, stop the sound and then resume the music.
    void OnTriggerExit(Collider other)
    {
        //stops the creepy sound and puts the background music volume to what it was originally.
        //Only one "=" or else you run into issues. The "f" at the end seems to only be necessary for the decimals.
        //If the number is whole, like the number 1, it does not seem to be necessary at all.
        sound.Stop();
        music1.volume = 0.82f;
        music2.volume = 1f;
        music3.volume = 0.55f;
    }
}