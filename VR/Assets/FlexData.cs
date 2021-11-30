using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlexData : MonoBehaviour
{
    string flexRawData = null;
    public static int f1down = 0;
    public static int f1up = 0;
    public static int f2down = 0;
    public static int f2up = 0;
    public static int f3down = 0;
    public static int f3up = 0;
    public static int f4down = 0;
    public static int f4up = 0;
    public static int f5 = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        flexRawData = Serial.flexData;
        string[] data = flexRawData.Split(',');
        f1down = int.Parse(data[0]) / 100;
        f1up = int.Parse(data[1]) / 100;
        f2down = int.Parse(data[2]) / 100;
        f2up = int.Parse(data[3]) / 100;
        f3down = int.Parse(data[4]) / 100;
        f3up = int.Parse(data[5]) / 100;
        f4down = int.Parse(data[6]) / 100;
        f4up = int.Parse(data[7]) / 100;
        f5 = int.Parse(data[8]) / 100;

        

        Debug.Log(f1down.ToString() + "," + f1up + "," + f2down + "," + f2up + "," + f3down + "," + f3up + ","
            + f3down + "," + f3up + "," + f4down + "," + f4up + "," + f5);

    }
}
