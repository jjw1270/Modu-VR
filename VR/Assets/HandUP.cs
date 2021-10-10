using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandUP : MonoBehaviour
{
    public GameObject finger6, finger7, finger8;
    public Quaternion six, seven, eight;
    // Start is called before the first frame update
    void Start()
    {
        six = finger6.transform.rotation;
        seven = finger7.transform.rotation;
        eight = finger8.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            finger6.transform.rotation = Quaternion.Euler(new Vector3(0f, -80f, 0f));
            finger7.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 80f));
            finger8.transform.rotation = Quaternion.Euler(new Vector3(0f, 80f, 0f));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            finger6.transform.rotation = six;
            finger7.transform.rotation = seven;
            finger8.transform.rotation = eight;
        }
    }
}
