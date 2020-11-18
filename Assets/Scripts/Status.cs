using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    public static Status Instance;
    public bool workDishStatus = false;
    public bool SpongeStatus = false;
    public bool CreamStatus = false;
    public bool ProductStatus = false;
    public bool FinalStatus = false;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
