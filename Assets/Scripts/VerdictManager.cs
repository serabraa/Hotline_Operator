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
    if(numbersOfTrueVerdicts + numberOfFalseVerdicts >=3) ////I know its bad code, its just for demo purposes
    {  
        FinishResult();
    }
}

public void FinishResult(){
    displayingNumberOfVerdicts.SetText(numbersOfTrueVerdicts+" true verdicts");
    ResultImage.SetActive(true);
}
public void IncrementTrueVerdicts(){
numbersOfTrueVerdicts++;
}
public void IncrementFalseVerdicts(){
numberOfFalseVerdicts++;
}
}
