using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class readAndWrite : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        string path = Application.dataPath + "/CakeData/test.txt";
        if (!File.Exists(path))
        {
            string createText = "Hello and Welcome\n";
            File.WriteAllText(path, createText);
        }
        string appendText = "This is extra text\n";
        File.AppendAllText(path, appendText);
        string readText = File.ReadAllText(path);
        Debug.Log(readText);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ReadData()
    {

    }
    public void WriteData()
    {

    }
}
