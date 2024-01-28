using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ArtifactManager : MonoBehaviour
{

    private TextMeshProUGUI text;
    private Animator animator;
    public static int _artifactsCollected;
    
    // Start is called before the first frame update
    void Start()
    {
        _artifactsCollected = 0;
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

    public void CollectArtifact()
    {
        _artifactsCollected++;
    }
}
