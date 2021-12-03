using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    Vector3 defaultRot;
    Vector3 tempRot;
    Vector3 toRot;
    Vector3 preRot;

    public float startX = 0;
    public float startY = 0;
    public float startZ = 0;

    float timer = 0;
    bool isDelayed = false;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(startX + ", " + startY + ", " + startZ + "!!!");

        //defaultRot = new Vector3(GyroData.gyroY + 80, GyroData.gyroX, -GyroData.gyroZ);
        //transform.localRotation = Quaternion.Euler(new Vector3(GyroData.gyroY + 80, GyroData.gyroX, -GyroData.gyroZ+140));
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (!isDelayed)
        {
            if (timer > 0.2)
            {
                //defaultRot = new Vector3(GyroData.gyroY, GyroData.gyroX, -GyroData.gyroZ);
                startX = GyroData.gyroY;
                startY = GyroData.gyroZ;
                startZ = GyroData.gyroX;
                isDelayed = true;
            }

        }

        else
        {
            //transform.localRotation = Quaternion.Euler(new Vector3(GyroData.gyroY - startX, GyroData.gyroX - startY, -GyroData.gyroZ - startZ));
            transform.localRotation = Quaternion.Euler(new Vector3(GyroData.gyroY - startX, GyroData.gyroZ - startY, GyroData.gyroX - startZ));
        }
    }
}
