using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerCtrl5 : MonoBehaviour
{
    public GameObject joint1, joint2;


    // Start is called before the first frame update
    void Start()
    {  //�ʱⰪ�� �޾ƿ��� ��Ȱ

    }

    // Update is called once per frame
    void Update()
    {
        //�յ� ����
        switch (FlexData.f5)
        {
            case -3:
                //�հ����� ���� ������ ��
                joint1.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
                joint2.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
                break;
            case -2:
                //�հ����� ���� ������ ��
                joint1.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
                joint2.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
                break;
            case -1:
                //�հ����� ���� ������ ��
                joint1.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
                joint2.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
                break;
            case 0:
                //�հ����� ���� ������ ��
                joint1.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
                joint2.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
                break;
            case 1:
                joint1.transform.localRotation = Quaternion.Euler(new Vector3(0, 15, 0));
                joint2.transform.localRotation = Quaternion.Euler(new Vector3(0, 15, 0));
                break;
            case 2:
                joint1.transform.localRotation = Quaternion.Euler(new Vector3(0, 30, 0));
                joint2.transform.localRotation = Quaternion.Euler(new Vector3(0, 30, 0));
                break;
            case 3:
                joint1.transform.localRotation = Quaternion.Euler(new Vector3(0, 45, 0));
                joint2.transform.localRotation = Quaternion.Euler(new Vector3(0, 45, 0));
                break;
            case 4:
                joint1.transform.localRotation = Quaternion.Euler(new Vector3(0, 60, 0));
                joint2.transform.localRotation = Quaternion.Euler(new Vector3(0, 60, 0));
                break;

            case 5:
                joint1.transform.localRotation = Quaternion.Euler(new Vector3(0, 70, 0));
                joint2.transform.localRotation = Quaternion.Euler(new Vector3(0, 70, 0));
                break;
            case 6:
                joint1.transform.localRotation = Quaternion.Euler(new Vector3(0, 90, 0));
                joint2.transform.localRotation = Quaternion.Euler(new Vector3(0, 90, 0));
                break;
        }
    }
}
