using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;

using UnityEngine;



using UnityEngine.UI;


public class VoiceManager : MonoBehaviour
{
//     if(answerTheCall.interactable == true){
// answerTheCall.interactable = false;}
//  else {answerTheCall.interactable =true;}
    [SerializeField] AudioClip[] calls ;
    
    [SerializeField] AudioSource audioSource;
    [SerializeField]Button answerButton;
    [SerializeField]Button declineButton;
    

    int defaultPitch = 1;
    int ringtoneNumber = 0;
    int callNumber = 1;
    float ringtoneVolume = 0.05f;
    float voiceVolume = 0.5f;
    bool cooroutineHasStarted =false;
    int trueResult =0;

    // Start is called before the first frame update
    void Start()
    {

        SetPhoneInactive();
        DefaultRingtoneSettings();
        

    }

    // Update is called once per frame
    void Update()
    {
        
        RingtonePlays();                //ringtone plays on loop, boolean coorutineHasStarted becomes true
        CheckingNumbersOfCalls();




    }
    


    IEnumerator RingtonePlaysCoorutine(float delayinSecond){        //ringtone and NUMBER displaying cooroutine
        yield return new WaitForSeconds(delayinSecond);
        audioSource.clip = calls[ringtoneNumber];
        audioSource.Play();
        Camera.main.GetComponent<NumberManager>().DisplayeNunber();
        Camera.main.GetComponent<MapManager>().DisplayCallersLocation();
        SetPhoneActive();
    }

    public void RingtonePlays(){            //ringtone plays on loop, boolean coorutineHasStarted becomes true

        if(cooroutineHasStarted == false){
        DefaultRingtoneSettings();
        StartCoroutine(RingtonePlaysCoorutine(5));
        cooroutineHasStarted = true;
        }
    }
 

    public void DefaultRingtoneSettings(){      //just volume adjustment and loop
    audioSource.volume = ringtoneVolume;
    audioSource.clip = calls[ringtoneNumber];
    audioSource.loop = true;
    audioSource.pitch = defaultPitch;
    }


    public void SetPhoneInactive(){
    answerButton.interactable = false;
    declineButton.interactable = false;
 }
    public void SetPhoneActive(){
    answerButton.interactable = true;
    declineButton.interactable = true;
 }

    public void DefaultCallSettings(){
        audioSource.volume = voiceVolume;
        audioSource.loop = false;
        audioSource.clip = calls[callNumber];
        audioSource.pitch = RandomPitchNumber();
    }

    public void DeclineCall(){
        audioSource.Stop();
        SetPhoneInactive();
        Camera.main.GetComponent<NumberManager>().HideNunber();
        Camera.main.GetComponent<MapManager>().HideCallersLocation();
        cooroutineHasStarted=false;
    }

    public void AnswerCall(){
        SetPhoneInactive();
        DefaultCallSettings();
        audioSource.Play();        
        callNumber++;
        Camera.main.GetComponent<OperatorCalls>().operatorButtonsActive = true;
        
    }

 
    //1 police
    //2 ambulance
    //3 fireworkers
    //4 fake call
    public void CheckingNumbersOfCalls(){        //numbers represent the result of the call, f.e. if voice 1 is number 1, then it means that it is a police call
        if(calls[1].Equals(audioSource.clip)){
            trueResult = 4; // manually setting the call numbers
        }
        if(calls[2].Equals(audioSource.clip)){
            trueResult = 3; 
        }
        if(calls[3].Equals(audioSource.clip)){
            trueResult = 1; 
        }
        if(calls[4].Equals(audioSource.clip)){
            trueResult = 2; 
        }
        if(calls[5].Equals(audioSource.clip)){
            trueResult = 1; 
        }
        if(calls[6].Equals(audioSource.clip)){
            trueResult = 2; 
        }
        if(calls[7].Equals(audioSource.clip)){
            trueResult = 4; 
        }
        
    }

    public void ReusltOfTheChoice(){        //this works with button's onClick() and checks if the verdict is right, and setting the cooroutine for the next call
        audioSource.Stop(); // this line is for stopping the call after a operator button was clicked
        if(StillCallsLeft()){        //if it is the last call, no need for the ringtone cooroutine
            cooroutineHasStarted = false;
            }
            Debug.Log(cooroutineHasStarted);
        if(Camera.main.GetComponent<OperatorCalls>().verdictOfThePlayer == trueResult){
            Camera.main.GetComponent<VerdictManager>().IncrementTrueVerdicts();
            Debug.Log("True verdict");
            
        }else {
        Camera.main.GetComponent<VerdictManager>().IncrementFalseVerdicts();
        Debug.Log("False verdict");}

        
    }
    
    public float RandomPitchNumber(){
        float pitchNumber = UnityEngine.Random.Range(0.9f, 1.10f);
        return pitchNumber;
    }

    public Boolean StillCallsLeft()
    {
        if(calls[callNumber]!=null){
            return true;
        }else return false;
    }
    public Boolean AudioSourceIsNotPlaying(){
        if(audioSource.isPlaying)
        {
        return false;
        }
        else return true;
    }


}
