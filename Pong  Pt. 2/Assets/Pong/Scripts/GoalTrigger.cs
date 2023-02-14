using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class GoalTrigger : MonoBehaviour
{
    
    
    public GameManager gameManager;

   

    private void OnTriggerEnter(Collider other)
    {
        gameManager.OnGoalTrigger(this);
    }

  


}
