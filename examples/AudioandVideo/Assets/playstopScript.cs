using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;


public class playstopScript : MonoBehaviour
{
    public Button playStopVideo;
    bool psvToggle = false;
    public Button playStopSound;
     bool pssToggle = false;

    public Button playStopBoth;
    bool psbToggle = false;


    public VideoPlayer waves;
    public AudioSource waveSound;

    void OnAwake()
    {
        //OnAwake is a state in unity before the start function. 
        //isLooping sets the video or sound to continuously loop(true) or not(false).
        waves.playOnAwake = false;
        waves.isLooping = true;

        waveSound.playOnAwake = false;
        waveSound.loop = true;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
        playStopVideo.onClick.AddListener(() => {
            if(psvToggle == false){
                psvToggle = true;
                waves.Play();
            }else{
                psvToggle = false;
                //waves.Stop();
                waves.Pause();
                waves.frame = 0;
            }
        });
        playStopSound.onClick.AddListener(() => {
            if(pssToggle == false){
                pssToggle = true;
                waveSound.Play();
            }else{
                pssToggle = false;
                //waveSound.Stop();
                waveSound.Pause();
                waveSound.time = 0;
            }
        });

        playStopBoth.onClick.AddListener(() => {
            if(psbToggle == false){
                psbToggle = true;
                waves.Play();
                waveSound.Play();
            }else{
                psbToggle = false;
                waveSound.Stop();
                waves.Stop();
                
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
