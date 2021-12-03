using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerCtrl : MonoBehaviour
{
    public GameObject joint1, joint2, joint3;


    // Start is called before the first frame update
    void Start()
    {  //초기값을 받아오는 역활
        
    }

    // Update is called once per frame
    void Update()
    {
        //손등 관절
        switch (FlexData.f1down)
        {
            case 0:
                //손가락이 제일 펴졌을 때
                joint1.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
                break;
            case 1:
                joint1.transform.localRotation = Quaternion.Euler(new Vector3(0, 15, 0));
                break;
            case 2:
                joint1.transform.localRotation = Quaternion.Euler(new Vector3(0, 30, 0));
                break;
            case 3:
                joint1.transform.localRotation = Quaternion.Euler(new Vector3(0, 45, 0));
                break;
            case 4:
                joint1.transform.localRotation = Quaternion.Euler(new Vector3(0, 60, 0));
                break;

            case 5:
                joint1.transform.localRotation = Quaternion.Euler(new Vector3(0, 75, 0));
                break;
            case 6:
                joint1.transform.localRotation = Quaternion.Euler(new Vector3(0, 90, 0));
                break;
        }

        switch (FlexData.f1up)
        {
            case 0:
                //손가락이 제일 펴졌을 때
                joint2.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
                joint3.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
                break;
            case 1:
                joint2.transform.localRotation = Quaternion.Euler(new Vector3(0, 15, 0));
                joint3.transform.localRotation = Quaternion.Euler(new Vector3(0, 15, 0));
                break;
            case 2:
                joint2.transform.localRotation = Quaternion.Euler(new Vector3(0, 30, 0));
                joint3.transform.localRotation = Quaternion.Euler(new Vector3(0, 30, 0));
                break;
            case 3:
                joint2.transform.localRotation = Quaternion.Euler(new Vector3(0, 45, 0));
                joint3.transform.localRotation = Quaternion.Euler(new Vector3(0, 45, 0));
                break;
            case 4:
                joint2.transform.localRotation = Quaternion.Euler(new Vector3(0, 60, 0));
                joint3.transform.localRotation = Quaternion.Euler(new Vector3(0, 60, 0));
                break;

            case 5:
                joint2.transform.localRotation = Quaternion.Euler(new Vector3(0, 75, 0));
                joint3.transform.localRotation = Quaternion.Euler(new Vector3(0, 75, 0));
                break;
            case 6:
                joint2.transform.localRotation = Quaternion.Euler(new Vector3(0, 90, 0));
                joint3.transform.localRotation = Quaternion.Euler(new Vector3(0, 90, 0));
                break;
        }
   
    }
}
