using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class OperatorCalls : MonoBehaviour
{
    [SerializeField] Button fireworksButton;
    [SerializeField] Button ambulanceButton;
    [SerializeField] Button policeButton;
    [SerializeField] Button reportFakeButton;

    public int verdictOfThePlayer = 0;
    public bool operatorButtonsActive = false;





void Start()
{
    

}

void Update(){
    OperatorButtonsActivityHandler();
}
public void CallPolice(){   //We wanted to make it return int, however OnClick() does not let us do that, so we make it return void but with a int in it
verdictOfThePlayer = 1;
Debug.Log("police");
}
 
public void CallAmbulance(){
verdictOfThePlayer =2;
Debug.Log("ambulance");
 }
public void CallFireworkers(){
Debug.Log("fireworkers");
verdictOfThePlayer =3;
 }

public void ReportFakeCall(){
Debug.Log("fake call");
verdictOfThePlayer =4;
}

public void HideOperatorButtons(){
    reportFakeButton.gameObject.SetActive(false);
    policeButton.gameObject.SetActive(false);
    ambulanceButton.gameObject.SetActive(false);
    fireworksButton.gameObject.SetActive(false);
}
public void DisplayOperatorButtons(){
    reportFakeButton.gameObject.SetActive(true);
    policeButton.gameObject.SetActive(true);
    ambulanceButton.gameObject.SetActive(true);
    fireworksButton.gameObject.SetActive(true);
}
public void SetOperatorButtonsActive(){
    reportFakeButton.interactable = true;
    policeButton.interactable = true;
    ambulanceButton.interactable = true;
    fireworksButton.interactable = true;
}
public void SetOperatorButtonsInActive(){
    reportFakeButton.interactable = false;
    policeButton.interactable = false;
    ambulanceButton.interactable = false;
    fireworksButton.interactable = false;
}

public void DecisionWasMade(){
    operatorButtonsActive =false;
    Camera.main.GetComponent<NumberManager>().HideNunber();
    Camera.main.GetComponent<NumberManager>().ChangeNumber();
}
public void OperatorButtonsActivityHandler(){
    if(operatorButtonsActive == false){
        SetOperatorButtonsInActive();
    }else 
    SetOperatorButtonsActive();
}


}
