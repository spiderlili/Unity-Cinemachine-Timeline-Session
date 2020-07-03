using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelinePlayer : MonoBehaviour
{
    private PlayableDirector director;
    public GameObject controlPanel;


    void Awake()
    {
        //set playable director reference, register the callback functions to be invoked when director start/stop
        director = GetComponent<PlayableDirector>();
        director.played += DirectorPlayed;
        director.stopped += DirectorStopped;
    }

    private void DirectorStopped(PlayableDirector playableDirector)
    {
        controlPanel.SetActive(true); //show the ui panel after the timeline has stopped
    }

    private void DirectorPlayed(PlayableDirector playableDirector)
    {
        controlPanel.SetActive(false); //hide the ui used to start the timeline once timeline has started playing
    }

    public void StartTimeline()
    {
        director.Play();
    }

}
