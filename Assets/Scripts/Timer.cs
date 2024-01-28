using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
   //public GameObject fadeToBlackSquare;
   public Animator animator;
    
    public float timeRemaining = 300;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        
        if (timeRemaining <= 0)
        {
            TimeHasRunOut();
        }
    }
    
    // ReSharper disable Unity.PerformanceAnalysis
    void TimeHasRunOut()
    {
        Debug.Log("Time has run out!");
        animator.Play("FadeOut");
        //StartCoroutine(FadeToBlack(false,1));
    }   

    

    // public IEnumerator FadeToBlack(bool fadeToBlack,int fadeSpeed)
    // {
    //     Color objectColor = fadeToBlackSquare.GetComponent<Image>().color;
    //     float fadeAmount;
    //
    //     if (fadeToBlack)
    //     {
    //         while (fadeToBlackSquare.GetComponent<Image>().color.a < 1)
    //         {
    //             fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);
    //
    //             objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
    //             fadeToBlackSquare.GetComponent<Image>().color = objectColor;
    //             yield return null;
    //         }
    //         
    //     }
    //     else
    //     {
    //         while (fadeToBlackSquare.GetComponent<Image>().color.a > 0)
    //         {
    //             fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);
    //
    //             objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
    //             fadeToBlackSquare.GetComponent<Image>().color = objectColor;
    //             yield return null;
    //         }
    //     }
    // }
}
