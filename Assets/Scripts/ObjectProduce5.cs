using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectProduce5 : MonoBehaviour
{
    public static ObjectProduce5 Instance;
    public GameObject[] sponges;
    public GameObject[] creams;
    public GameObject[] products;
    // GameObject[] sponge = new GameObject[2];     
    // public Transform dot;
    void Awake()
    {
        Instance = this;
    }
    public void cakeProduce(int a, int b, int c, int d, int e, int f)
    {
        if (a == 0)
        {
            //產生巧克力海綿
            // GameObject sponge = Instantiate(sponges[0], dot);
            // sponge.transform.parent = dot;
            Debug.Log("產生巧克力海綿");
            sponges[0].SetActive(true);
            sponges[1].SetActive(false);
            sponges[2].SetActive(false);
            sponges[3].SetActive(false);
        }
        if (a == 1)
        {
            //產生草莓海綿
            // GameObject sponge = Instantiate(sponges[1], dot);
            // sponge.transform.parent = dot; 
            sponges[0].SetActive(false);
            sponges[1].SetActive(true);
            sponges[2].SetActive(false);
            sponges[3].SetActive(false);
        }
        if (a == 2)
        {
            //產生藍莓海綿
            // GameObject sponge = Instantiate(sponges[2], dot);
            // sponge.transform.parent = dot;
            // Debug.Log("產生藍莓海綿");
            sponges[0].SetActive(false);
            sponges[1].SetActive(false);
            sponges[2].SetActive(true);
            sponges[3].SetActive(false);
        }
        if (a == 3)
        {
            //產生原味海綿
            // GameObject sponge = Instantiate(sponges[3], dot);
            // sponge.transform.parent = dot; 
            //  sponge[i] = Instantiate(sponges[3], dot);
            //  sponge[i].transform.parent = dot;
            //   Destroy(sponge[j]);
            sponges[0].SetActive(false);
            sponges[1].SetActive(false);
            sponges[2].SetActive(false);
            sponges[3].SetActive(true);
        }
        if (d == 1)
        {
            if (c == 0)
            {
                creams[0].SetActive(true);
                creams[1].SetActive(false);
                creams[2].SetActive(false);
                Debug.Log("巧克力奶油");
            }
            if (c == 1)
            {
                creams[0].SetActive(false);
                creams[1].SetActive(true);
                creams[2].SetActive(false);
                Debug.Log("白奶油");
            }
            if (c == 2)
            {
                creams[0].SetActive(false);
                creams[1].SetActive(false);
                creams[2].SetActive(true);
                Debug.Log("黃奶油");
            }
        }
        if (f == 1)
        {
            if (e == 0)
            {
                products[0].SetActive(true);
                products[1].SetActive(false);
                products[2].SetActive(false);
                products[3].SetActive(false);
                products[4].SetActive(false);
            }
            if (e == 1)
            {
                products[0].SetActive(false);
                products[1].SetActive(true);
                products[2].SetActive(false);
                products[3].SetActive(false);
                products[4].SetActive(false);
            }
            if (e == 2)
            {
                products[0].SetActive(false);
                products[1].SetActive(false);
                products[2].SetActive(true);
                products[3].SetActive(false);
                products[4].SetActive(false);
            }
            if (e == 3)
            {
                products[0].SetActive(false);
                products[1].SetActive(false);
                products[2].SetActive(false);
                products[3].SetActive(true);
                products[4].SetActive(false);
            }
            if (e == 4)
            {
                products[0].SetActive(false);
                products[1].SetActive(false);
                products[2].SetActive(false);
                products[3].SetActive(false);
                products[4].SetActive(true);
            }
        }
    }
}
