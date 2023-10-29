using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMusic : MonoBehaviour
{
    public AudioSource music1;
    public AudioSource music2;
    public AudioSource music3;
    //create an integer so that I know which song it is on. This is to prevent a song starting from the beginning over and over when a key is spammed.
    private int song;

    // Update is called once per frame
    void Update()
    {
        //when key is pressed, play the third track and pause the first and second.
        if (Input.GetKeyDown(KeyCode.B))
        {
            //when the value equals 0, the song is playing. Therefore, I will not play the song again.
            //The other if statements indicate values where a different song is playing, so this song will play.
            if (song == 1)
            {
                music1.Play();
                music2.Pause();
                music3.Pause();
                song = 0;
            }
            if (song == 2)
            {
                music1.Play();
                music2.Pause();
                music3.Pause();
                song = 0;
            }
            if (song == 0)
            {                
                music2.Pause();
                music3.Pause();
                song = 0;
            }
        }

        //when key is pressed, play the first and stop the second and third.
        if (Input.GetKeyDown(KeyCode.N))
        {
            //when the value equals 1, the song is playing. Therefore, I will not play the song again.
            //The other if statements indicate values where a different song is playing, so this song will play.
            if (song == 1)
            {
                music1.Pause();                
                music3.Pause();
                song = 1;
            }
            if (song == 2)
            {
                music1.Pause();
                music2.Play();
                music3.Pause();
                song = 1;
            }
            if (song == 0)
            {
                music1.Pause();
                music2.Play();
                music3.Pause();
                song = 1;
            }
        }

        //when key is pressed, play the second and stop the first and third.
        if (Input.GetKeyDown(KeyCode.M))
        {
            //when the value equals 2, the song is playing. Therefore, I will not play the song again.
            //The other if statements indicate values where a different song is playing, so this song will play.
            if (song == 1)
            {
                music1.Pause();
                music2.Pause();
                music3.Play();
                song = 2;
            }
            if (song == 2)
            {
                music1.Pause();
                music2.Pause();                
                song = 2;
            }
            if (song == 0)
            {
                music1.Pause();
                music2.Pause();
                music3.Play();
                song = 2;
            }
        }
    }
}