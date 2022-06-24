using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TVController : MonoBehaviour
{
    public VideoClip videoClip;
    public AudioClip audioClip;

    // start is called before the first frame update
    void Start()
    {
        VideoPlayer videoPlayer = GameObject.Find("Video Player").GetComponent<VideoPlayer>();
        AudioSource audioSource = videoPlayer.GetComponent<AudioSource>();
        videoPlayer.clip = videoClip;
        audioSource.clip = audioClip;
        videoPlayer.enabled = true;
    }
}
