using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
   //public GameObject fadeToBlackSquare;
   public Animator animator;
    
   
   public TMP_Text textTimer;
   
    public float timeRemaining = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining += Time.deltaTime;
        if (timeRemaining >= 257)
        {
            TimeHasRunOut();
        }
        displayTime();
    }
    
    // ReSharper disable Unity.PerformanceAnalysis
    void TimeHasRunOut()
    {
        if (ArtifactManager._artifactsCollected > 2)
        {
            SceneManager.LoadScene("EntertainedScene");
        }
        else
        {
            Debug.Log("Time has run out!");
            animator.Play("FadeOut");
        }
        
        
    }   

    public void displayTime()
    {
        float minutes = Mathf.FloorToInt(timeRemaining / 60);
        float seconds = Mathf.FloorToInt(timeRemaining % 60);
        textTimer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    

    
}
