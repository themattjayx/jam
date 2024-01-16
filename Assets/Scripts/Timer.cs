using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    private AudioSource ambience;                           
    private AudioSource music;                    

    public GameObject comicBubble;                  //for disabling the initial hint
    public CharacterMovement scriptMovement;        //reference to the TopDownMovement script for accessing variable
    
    public float timeValue;                         //181 for 3 minutes
    public TextMeshProUGUI timerText;               //TextMeshProGUI used instead of Text

    public GameObject mainUI;
    
    // Start is called before the first frame update
    void Start()
    {
        AudioSource[] audios = GetComponents<AudioSource>();                //way of getting multiple audio sources
        ambience = audios[0];
        ambience.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (scriptMovement != null && scriptMovement.timerTriggered)
        {
            comicBubble.SetActive(false);
            mainUI.SetActive(true);
            if (timeValue > 0)
            {
                timeValue = timeValue - Time.deltaTime;
            }
            else
            {
                timeValue = 0;
                SceneManager.LoadScene("OverScene");
            }
        }
        DisplayTime(timeValue);
    }

    void DisplayTime(float timeDisplay)
    {
        if (timeDisplay < 0)
        {
            timeDisplay = 0;
        }
        
        float minutes = Mathf.FloorToInt(timeDisplay / 60);
        float seconds = Mathf.FloorToInt(timeDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
