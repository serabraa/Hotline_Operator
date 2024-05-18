using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class VerdictManager : MonoBehaviour
{
[SerializeField] GameObject ResultImage;
[SerializeField] TMP_Text displayingNumberOfVerdicts;
int numbersOfTrueVerdicts = 0;
int numberOfFalseVerdicts = 0;



public void Update()
{

    
        FinishResult();
    
}

public void FinishResult(){
    if(Camera.main.GetComponent<VoiceManager>().StillCallsLeft() == false && Camera.main.GetComponent<VoiceManager>().AudioSourceIsNotPlaying()) {  
    displayingNumberOfVerdicts.SetText(numbersOfTrueVerdicts+" true verdicts");
    ResultImage.SetActive(true);
    }
}
public void IncrementTrueVerdicts(){
numbersOfTrueVerdicts++;
}
public void IncrementFalseVerdicts(){
numberOfFalseVerdicts++;
}
}
