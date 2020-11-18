using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeRotate : MonoBehaviour
{
    // public GameObject cake;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CakeRotation(GameObject cake)
    {
        cake.transform.Rotate(0.0f, 20.0f, 0.0f, Space.Self);
    }
}
