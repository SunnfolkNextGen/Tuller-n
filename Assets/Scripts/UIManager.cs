using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private Timer _timer;
    // Start is called before the first frame update
    void Start()
    {
        _timer = GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(_timer.timeRemaining);
    }
}
