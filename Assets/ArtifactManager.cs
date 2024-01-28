using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ArtifactManager : MonoBehaviour
{

    private TextMeshProUGUI text;
    private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Announce(string message)
    {
        text.text = message;
        animator.Play("TextAnimation");
    }
}
