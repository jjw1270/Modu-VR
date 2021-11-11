using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandUP : MonoBehaviour
{
    public GameObject finger6, finger7, finger8;
    public GameObject finger2, finger3, finger4;

    public Quaternion six, seven, eight;
    public Quaternion two, three, four;

    public float finger_speed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        six = finger6.transform.rotation;
        seven = finger7.transform.rotation;
        eight = finger8.transform.rotation;

        two = finger2.transform.rotation;
        three = finger3.transform.rotation;
        four = finger4.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {

        //변경사항!
        if (Input.GetKey(KeyCode.W))
        {
            finger6.transform.rotation *= Quaternion.Euler(new Vector3(0f, -8f*Time.deltaTime, 0f));
            finger7.transform.rotation *= Quaternion.Euler(new Vector3(0f, 0f, 8f*Time.deltaTime));
            finger8.transform.rotation *= Quaternion.Euler(new Vector3(0f, 8f*Time.deltaTime, 0f));
        }
        if (Input.GetKey(KeyCode.S))
        {
            finger6.transform.rotation = six;
            finger7.transform.rotation = seven;
            finger8.transform.rotation = eight;
        }



        if (Input.GetKey(KeyCode.Q))
        {
            finger2.transform.rotation = Quaternion.Euler(new Vector3(0f, -80f, 0f));
            finger3.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 80f));
            finger4.transform.rotation = Quaternion.Euler(new Vector3(0f, 80f, 0f));
        }
        if (Input.GetKey(KeyCode.A))
        {
            finger2.transform.rotation = two;
            finger3.transform.rotation = three;
            finger4.transform.rotation = four;
        }
    }
}
