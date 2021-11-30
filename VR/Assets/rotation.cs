using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public GameObject hand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //transform.Rotate(new Vector3(GyroData.gyroX, -GyroData.gyroZ, GyroData.gyroY));
        transform.rotation = Quaternion.Euler(GyroData.gyroX+180, GyroData.gyroZ, GyroData.gyroY);
    }
}
