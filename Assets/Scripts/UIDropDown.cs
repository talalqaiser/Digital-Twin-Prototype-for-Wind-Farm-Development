using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIDropDown : MonoBehaviour
{

    //public TextMeshProUGUI output;
    public GameObject Inventory, WindController, TurbineController, Disp_Ind_Total_Power, Power_Storage;
    public static bool Check;

    [System.Obsolete]

    public void HandleInputData(int val)
    {
        if(val == 0)
        {
            WindController.transform.gameObject.active = false;
            TurbineController.transform.gameObject.active = false;
            Inventory.transform.gameObject.active = false;
            Disp_Ind_Total_Power.gameObject.active = false;
            Power_Storage.gameObject.active = false;
            Check = true;
        }
        
        if (val == 1)
        {
            WindController.transform.gameObject.active = false;
            TurbineController.transform.gameObject.active = false;
            Inventory.transform.gameObject.active = true;
            Disp_Ind_Total_Power.gameObject.active = false;
            Power_Storage.gameObject.active = false;
            Check = true;
        }
        if (val == 2)
        {
            Inventory.transform.gameObject.active = false;
            TurbineController.transform.gameObject.active = false;
            WindController.transform.gameObject.active = true;
            Disp_Ind_Total_Power.gameObject.active = false;
            Power_Storage.gameObject.active = false;
            Check = true;
        }
        if (val == 3)
        {
            Inventory.transform.gameObject.active = false;
            WindController.transform.gameObject.active = false;
            TurbineController.transform.gameObject.active = false;
            Disp_Ind_Total_Power.gameObject.active = true;
            Power_Storage.gameObject.active = false;
            Check = true;
        }
        if (val == 4)
        {
            Inventory.transform.gameObject.active = false;
            WindController.transform.gameObject.active = false;
            TurbineController.transform.gameObject.active = false;
            Disp_Ind_Total_Power.gameObject.active = false;
            Power_Storage.gameObject.active = true;
            Check = false;
        }

    }
    void Start()
    {
 
    }


}
