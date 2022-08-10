using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalPowerCalculation : MonoBehaviour
{
    public GameObject Wind_Farm;
    public Text Total_Power_text;
    [Range(0.0f, 800000.0f)]
    public static float Total_Power;
    public static float Total_Power_Needed;
    // Start is called before the first frame update
    void Start()
    {
        Total_Power_Needed = 250.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Total_Power = Wind_Farm.transform.GetChild(0).gameObject.GetComponent<TurbineSetting>().WindOutPut + Wind_Farm.transform.GetChild(1).gameObject.GetComponent<TurbineSetting>().WindOutPut
              + Wind_Farm.transform.GetChild(2).gameObject.GetComponent<TurbineSetting>().WindOutPut + Wind_Farm.transform.GetChild(3).gameObject.GetComponent<TurbineSetting>().WindOutPut
              + Wind_Farm.transform.GetChild(4).gameObject.GetComponent<TurbineSetting>().WindOutPut + Wind_Farm.transform.GetChild(5).gameObject.GetComponent<TurbineSetting>().WindOutPut
              + Wind_Farm.transform.GetChild(6).gameObject.GetComponent<TurbineSetting>().WindOutPut + Wind_Farm.transform.GetChild(7).gameObject.GetComponent<TurbineSetting>().WindOutPut
              + Wind_Farm.transform.GetChild(8).gameObject.GetComponent<TurbineSetting>().WindOutPut + Wind_Farm.transform.GetChild(9).gameObject.GetComponent<TurbineSetting>().WindOutPut
              + Wind_Farm.transform.GetChild(10).gameObject.GetComponent<TurbineSetting>().WindOutPut;

        Total_Power_text.text = ((Total_Power / 100000).ToString("0.00") + " MW");
    }

}
