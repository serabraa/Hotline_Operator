using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberManager : MonoBehaviour


{
    [SerializeField] TMP_Text[] numberCalling;
    int indexOfACall = 1;
    public void DisplayeNunber(){
        numberCalling[indexOfACall].gameObject.SetActive(true);
    }

    public void HideNunber(){
        numberCalling[indexOfACall].gameObject.SetActive(false);
    }

    public void ChangeNumber(){
        indexOfACall++;
    }
}
