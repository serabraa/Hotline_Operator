using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InstructionsManager : MonoBehaviour
{
    [SerializeField] GameObject instructionsPanel;
    // [SerializeField] RectTransform rectTransform;


    public void DisplayInstructionsPanel(){
        instructionsPanel.SetActive(true);    
    }
    public void HideInstructionsPanel(){
        instructionsPanel.SetActive(false);
    }
}
