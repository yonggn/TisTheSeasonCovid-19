using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosLajuService : MonoBehaviour
{
    public GameObject PosLajuPanel;
    public GameObject WriteMessage;
    public GameObject PayMessage;
    public GameObject MessageSuccess;
    public GameObject NotToPay1;
    public GameObject NotToPay2;
    public GameObject NotToPay3;
    public GameObject PackageService;
    public GameObject CheckMessage;
    private PlayerController ply;
    public GameObject nomoney;


    public void EnterPosLaju()
    {
        PosLajuPanel.SetActive(true);
        WriteMessage.SetActive(false);
        PayMessage.SetActive(false);
        MessageSuccess.SetActive(false);
        NotToPay1.SetActive(false);
        NotToPay2.SetActive(false);
        NotToPay3.SetActive(false);
        PackageService.SetActive(false);
        CheckMessage.SetActive(false);
    }

    public void Button1Choose()
    {
        PosLajuPanel.SetActive(false);
        WriteMessage.SetActive(true);
        PayMessage.SetActive(false);
        MessageSuccess.SetActive(false);
        NotToPay1.SetActive(false);
        NotToPay2.SetActive(false);
        NotToPay3.SetActive(false);
        PackageService.SetActive(false);
        CheckMessage.SetActive(false);
    }

    public void Button2Choose()
    {
        PosLajuPanel.SetActive(false);
        WriteMessage.SetActive(false);
        PayMessage.SetActive(false);
        MessageSuccess.SetActive(false);
        NotToPay1.SetActive(false);
        NotToPay2.SetActive(false);
        NotToPay3.SetActive(false);
        PackageService.SetActive(true);
        CheckMessage.SetActive(false);
    }

    public void Button3Choose()
    {
        PosLajuPanel.SetActive(false);
        WriteMessage.SetActive(false);
        PayMessage.SetActive(false);
        MessageSuccess.SetActive(false);
        NotToPay1.SetActive(false);
        NotToPay2.SetActive(false);
        NotToPay3.SetActive(false);
        PackageService.SetActive(false);
        CheckMessage.SetActive(true);
    }

    public void FinishWriteMessage()
    {
        if(FindObjectOfType<DisplayPills>().pillNo<10)
        {
            nomoney.SetActive(true);
        }
        PosLajuPanel.SetActive(false);
        WriteMessage.SetActive(false);
        PayMessage.SetActive(true);
        MessageSuccess.SetActive(false);
        NotToPay1.SetActive(false);
        NotToPay2.SetActive(false);
        NotToPay3.SetActive(false);
        PackageService.SetActive(false);
        CheckMessage.SetActive(false);
        
   
    }
    public void MessagePay()
    {
        PosLajuPanel.SetActive(false);
        WriteMessage.SetActive(false);
        PayMessage.SetActive(false);
        MessageSuccess.SetActive(true);
        NotToPay1.SetActive(false);
        NotToPay2.SetActive(false);
        NotToPay3.SetActive(false);
        PackageService.SetActive(false);
        CheckMessage.SetActive(false);
        FindObjectOfType<DisplayPills>().ReducedPill();
        
       
    }


    public void NotToPay()
    {
        PosLajuPanel.SetActive(false);
        WriteMessage.SetActive(false);
        PayMessage.SetActive(false);
        MessageSuccess.SetActive(false);
        NotToPay1.SetActive(true);
        NotToPay2.SetActive(false);
        NotToPay3.SetActive(false);
        PackageService.SetActive(false);
        CheckMessage.SetActive(false);
    }

    public void NotToPay_2()
    {
        PosLajuPanel.SetActive(false);
        WriteMessage.SetActive(false);
        PayMessage.SetActive(false);
        MessageSuccess.SetActive(false);
        NotToPay1.SetActive(false);
        NotToPay2.SetActive(true);
        NotToPay3.SetActive(false);
        PackageService.SetActive(false);
        CheckMessage.SetActive(false);
    }

    public void NotToPay_3()
    {
        PosLajuPanel.SetActive(false);
        WriteMessage.SetActive(false);
        PayMessage.SetActive(false);
        MessageSuccess.SetActive(false);
        NotToPay1.SetActive(false);
        NotToPay2.SetActive(false);
        NotToPay3.SetActive(true);
        PackageService.SetActive(false);
        CheckMessage.SetActive(false);
    }
}
