using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateCake : MonoBehaviour
{
    public Flavor flavor;
    // Start is called before the first frame update
    void Start()
    {
        if (flavor == Flavor.chocolate)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public enum Flavor
    {
        chocolate, strawberry, blueberry, original
    }
}
