using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurnOnAndOFWatch : MonoBehaviour
{
  public TMP_Text textTimer;
  
public void turnOnWatch()
  {
    textTimer.alpha = 1;
  }

public  void turnOffWatch()
  {
    textTimer.alpha = 0;
  }
}
