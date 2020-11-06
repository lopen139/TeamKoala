using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioScript : MonoBehaviour
{
    private bool play;
    public RawImage buttonImage;
    public AudioSource audio;
    public Texture sprite1;
    public Texture sprite2;

    void Start()
    {
        play = false;
    }

    public void ToggleAudio()
    {
        play = !play;
        if(play)
        {
            audio.Play();
            buttonImage.texture = sprite2;
        }
        else 
        {
            audio.Stop();
            buttonImage.texture = sprite1;
        }
    }
}
