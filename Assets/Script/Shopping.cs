using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shopping : MonoBehaviour
{
    public TradePillForLife pillpanel;
    public PosLajuService pospanel;

   

    public void choosePill()
    {
        pillpanel.PillPanel.SetActive(true);
        pospanel.PosLajuPanel.SetActive(false);
    }

    public void choosePos()
    {
        pillpanel.PillPanel.SetActive(false);
        pospanel.PosLajuPanel.SetActive(true);
    }

}
