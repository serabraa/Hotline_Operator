using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using TMPro;

using UnityEngine.EventSystems;
using System;

public class InstructionsManager : MonoBehaviour
{
    [SerializeField] GameObject instructionsPanel;
    [SerializeField] TMP_Text instructionTMPText;
    [SerializeField] TMP_Text currentPageTMPText;
    string [] instructions = new string[10];
    // [SerializeField] RectTransform rectTransform;
    int NumberOfPages = 0;
    int currentPage = 0;


    void Start()
    {

        DisplayingCurrentPage();
        SettingTextes();
    }
    

    public void SettingTextes(){
        instructions[0]="Report fake calls ending with 812";
        instructionTMPText.SetText(instructions[0]);
        NumberOfPages++;
        instructions[NumberOfPages]= "Jeff is a liar";
        NumberOfPages++;
        instructions[NumberOfPages]= "All work and no play makes Sergo a dull boy";
    }

    

    public void NextButtonLogic(){
        if(currentPage+1 <= NumberOfPages ){
            currentPage++;
            DisplayAnotherInstruction(currentPage);
            DisplayingCurrentPage();
        }
    }
    
    public void BackButtonLogic(){
        if(currentPage-1 >= 0 ){
            currentPage--;
            DisplayAnotherInstruction(currentPage);
            DisplayingCurrentPage();
        }
    }
    public void DisplayInstructionsPanel(){
        instructionsPanel.SetActive(true);    
    }
    public void HideInstructionsPanel(){
        instructionsPanel.SetActive(false);
    }

    public void DisplayAnotherInstruction( int indexOfAnInstruction){
        instructionTMPText.SetText(instructions[indexOfAnInstruction]);
    }
    public void DisplayingCurrentPage(){
        currentPageTMPText.SetText(currentPage+1+ "");
    }
}
