using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroData : MonoBehaviour
{
    string gyroRawData = null;
    public static float gyroX = 0;
    public static float gyroY = 0;
    public static float gyroZ = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Serial.gyroData.IndexOf("R") != -1) { }
        else
        {
            gyroRawData = Serial.gyroData;
            string[] data = gyroRawData.Split(',');
            gyroX = float.Parse(data[0]);
            gyroY = float.Parse(data[1]);
            gyroZ = float.Parse(data[2]);
        }
        //Debug.Log("X : " + gyroX + " Y : " + gyroY + " Z : " + gyroZ);
        
    }
}
