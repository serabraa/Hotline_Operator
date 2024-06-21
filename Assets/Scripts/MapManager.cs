using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapManager : MonoBehaviour
{
    [SerializeField] GameObject mapPanel;
    [SerializeField] Image [] callersLocations;
    int indexOfACaller = 0;

    public void DisplayMapPanel()
    {
        mapPanel.SetActive(true);
    }
    public void HideMapPanel()
    {
        mapPanel.SetActive(false);
    }


    public void DisplayCallersLocation()
    {
        callersLocations[indexOfACaller].gameObject.SetActive(true);
    }
    public void HideCallersLocation()
    {
        callersLocations[indexOfACaller].gameObject.SetActive(false);
    }
    public void ChangeCallersLocation()
    {
        indexOfACaller++;
    }
}
