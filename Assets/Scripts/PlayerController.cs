using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotation;

    public bool isAble;
    public GameObject prefab;

    void Start()
    {
        isAble = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles += new Vector3(0, rotation, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles -= new Vector3(0, rotation, 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            GameObject clon;
            clon = Instantiate(prefab);
            clon.transform.position = transform.position - new Vector3(0, 0, -1);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "EnablerCube")
        {
            isAble = true;

        }   else if (other.gameObject.name == "DisablerCube")
            { 
                isAble = false;
            }
    }
}
