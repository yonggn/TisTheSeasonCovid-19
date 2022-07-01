using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TradePillForLife : MonoBehaviour
{
    public GameObject PillPanel;
    public GameObject PillSuccess;
    private PlayerController ply;
    public int pilled;
   
   public void OpenTradePill()
    {
        PillPanel.SetActive(true);
        PillSuccess.SetActive(false);
    }

    public void ConfirmToTrade()
    {
        PillSuccess.SetActive(true);
        PillPanel.SetActive(false);
        FindObjectOfType<DisplayPills>().ReducedPill();
        FindObjectOfType<DisplayPills>().AddLife();
    }
}
