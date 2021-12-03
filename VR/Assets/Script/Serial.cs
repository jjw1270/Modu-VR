using UnityEngine;
using System;
using System.IO.Ports;

public class Serial : MonoBehaviour
{
    public static string comPort = "COM19";
    SerialPort m_SerialPort = new SerialPort(comPort, 115200, Parity.None, 8, StopBits.One);
    string m_Data = null;
    public static string gyroData = null;
    public static string flexData = null;

    void Start()
    {
        m_SerialPort.Open();
    }

    private void Update()
    {
        try
        {
            if (m_SerialPort.IsOpen)
            {
                m_Data = m_SerialPort.ReadLine();
                m_SerialPort.ReadTimeout = 30;
                string[] data = m_Data.Split('|');
                gyroData = data[0];
                flexData = data[1];
                //Debug.Log(m_Data);
            }
        }

        catch (Exception e)
        {
            //Debug.Log(e);
        }
    }

    void OnApplicationQuit()
    {
        m_SerialPort.Close();
    }
}
