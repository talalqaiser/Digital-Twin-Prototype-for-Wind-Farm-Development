using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONReader : MonoBehaviour
{

    public TextAsset WeatherFile;
    [System.Serializable]
    public class Days
    {
        public class Hours
        {
            public string datetime;
            public float temp;
            public float windspeed, winddir;
        }
    }

    public class Dayslist
    {
        public Days[] days;
    }

    public Dayslist m_dayslist = new Dayslist();


    // Start is called before the first frame update
    void Start()
    {
        m_dayslist = JsonUtility.FromJson<Dayslist>(WeatherFile.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
