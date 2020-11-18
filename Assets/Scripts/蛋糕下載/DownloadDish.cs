using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DownloadDish : MonoBehaviour
{
    string path;
    string jsonString;
    public Flavor flavor;
    public CreamFlavor creamflavor;
    public ProductFlavor productflavor;
    CakeInfo1 data1;

    // Start is called before the first frame update
    void Start()
    {
        path = Application.dataPath + "/CakeData/CakeInfo1.json";

    }

    // Update is called once per frame
    void Update()
    {
        // jsonString = File.ReadAllText(path);
        // data1 = JsonUtility.FromJson<CakeInfo1>(jsonString);
        // if (flavor == Flavor.chocolate)
        // {
        //     data1._CakeP1[0]._type = 0;
        //     ObjectProduce.Instance.cakeProduce(
        //      data1._CakeP1[0]._type,
        //      data1._CakeP1[0]._status,
        //      data1._CakeP1[1]._type,
        //      data1._CakeP1[1]._status);
        // }

        // if (flavor == Flavor.blueberry)
        // {
        //     data1._CakeP1[0]._type = 2;
        //     ObjectProduce.Instance.cakeProduce(
        //      data1._CakeP1[0]._type,
        //      data1._CakeP1[0]._status,
        //      data1._CakeP1[1]._type,
        //      data1._CakeP1[1]._status);
        // }

    }

    public void ReadCake()
    {
        jsonString = File.ReadAllText(path);
        data1 = JsonUtility.FromJson<CakeInfo1>(jsonString);
        if (Status.Instance.SpongeStatus == true)
        {
            ObjectProduce1.Instance.cakeProduce(
            data1._CakeP1[0]._type,
            data1._CakeP1[0]._status,
            data1._CakeP1[1]._type,
            data1._CakeP1[1]._status,
            data1._CakeP1[2]._type,
            data1._CakeP1[2]._status);
            ObjectProduce2.Instance.cakeProduce(
            data1._CakeP1[0]._type,
            data1._CakeP1[0]._status,
            data1._CakeP1[1]._type,
            data1._CakeP1[1]._status,
            data1._CakeP1[2]._type,
            data1._CakeP1[2]._status);
            ObjectProduce3.Instance.cakeProduce(
            data1._CakeP1[0]._type,
            data1._CakeP1[0]._status,
            data1._CakeP1[1]._type,
            data1._CakeP1[1]._status,
            data1._CakeP1[2]._type,
            data1._CakeP1[2]._status);
            ObjectProduce4.Instance.cakeProduce(
            data1._CakeP1[0]._type,
            data1._CakeP1[0]._status,
            data1._CakeP1[1]._type,
            data1._CakeP1[1]._status,
            data1._CakeP1[2]._type,
            data1._CakeP1[2]._status);
        }
        if (Status.Instance.CreamStatus == true)
        {
            ObjectProduce1.Instance.cakeProduce(
            data1._CakeP1[0]._type,
            data1._CakeP1[0]._status,
            data1._CakeP1[1]._type,
            data1._CakeP1[1]._status,
            data1._CakeP1[2]._type,
            data1._CakeP1[2]._status);
            ObjectProduce2.Instance.cakeProduce(
            data1._CakeP1[0]._type,
            data1._CakeP1[0]._status,
            data1._CakeP1[1]._type,
            data1._CakeP1[1]._status,
            data1._CakeP1[2]._type,
            data1._CakeP1[2]._status);
            ObjectProduce3.Instance.cakeProduce(
            data1._CakeP1[0]._type,
            data1._CakeP1[0]._status,
            data1._CakeP1[1]._type,
            data1._CakeP1[1]._status,
            data1._CakeP1[2]._type,
            data1._CakeP1[2]._status);
        }
        if (Status.Instance.ProductStatus == true)
        {
            ObjectProduce1.Instance.cakeProduce(
            data1._CakeP1[0]._type,
            data1._CakeP1[0]._status,
            data1._CakeP1[1]._type,
            data1._CakeP1[1]._status,
            data1._CakeP1[2]._type,
            data1._CakeP1[2]._status);
            ObjectProduce2.Instance.cakeProduce(
            data1._CakeP1[0]._type,
            data1._CakeP1[0]._status,
            data1._CakeP1[1]._type,
            data1._CakeP1[1]._status,
            data1._CakeP1[2]._type,
            data1._CakeP1[2]._status);
            ObjectProduce3.Instance.cakeProduce(
            data1._CakeP1[0]._type,
            data1._CakeP1[0]._status,
            data1._CakeP1[1]._type,
            data1._CakeP1[1]._status,
            data1._CakeP1[2]._type,
            data1._CakeP1[2]._status);
            ObjectProduce4.Instance.cakeProduce(
            data1._CakeP1[0]._type,
            data1._CakeP1[0]._status,
            data1._CakeP1[1]._type,
            data1._CakeP1[1]._status,
            data1._CakeP1[2]._type,
            data1._CakeP1[2]._status);
            ObjectProduce5.Instance.cakeProduce(
            data1._CakeP1[0]._type,
            data1._CakeP1[0]._status,
            data1._CakeP1[1]._type,
            data1._CakeP1[1]._status,
            data1._CakeP1[2]._type,
            data1._CakeP1[2]._status);
        }
        if (Status.Instance.FinalStatus == true)
        {
            ObjectProduce1.Instance.cakeProduce(
                data1._CakeP1[0]._type,
                data1._CakeP1[0]._status,
                data1._CakeP1[1]._type,
                data1._CakeP1[1]._status,
                data1._CakeP1[2]._type,
                data1._CakeP1[2]._status);
        }
    }

    public void UpdateCake()
    {
        jsonString = File.ReadAllText(path);
        data1 = JsonUtility.FromJson<CakeInfo1>(jsonString);
        //0巧個力，1藍莓，2草莓，3原味
        if (flavor == Flavor.chocolate)
        {
            data1._CakeP1[2]._status = 0;
            data1._CakeP1[1]._status = 0;
            data1._CakeP1[0]._type = 0;
            string newdata1 = JsonUtility.ToJson(data1);
            File.WriteAllText(path, newdata1);
        }
        if (flavor == Flavor.strawberry)
        {
            data1._CakeP1[2]._status = 0;
            data1._CakeP1[1]._status = 0;
            data1._CakeP1[0]._type = 1;
            string newdata1 = JsonUtility.ToJson(data1);
            File.WriteAllText(path, newdata1);
        }
        if (flavor == Flavor.blueberry)
        {
            data1._CakeP1[2]._status = 0;
            data1._CakeP1[1]._status = 0;
            data1._CakeP1[0]._type = 2;
            string newdata1 = JsonUtility.ToJson(data1);
            File.WriteAllText(path, newdata1);
        }
        if (flavor == Flavor.original)
        {
            data1._CakeP1[2]._status = 0;
            data1._CakeP1[1]._status = 0;
            data1._CakeP1[0]._type = 3;
            string newdata1 = JsonUtility.ToJson(data1);
            File.WriteAllText(path, newdata1);
        }
    }
    public void UpdateCream()
    {
        jsonString = File.ReadAllText(path);
        data1 = JsonUtility.FromJson<CakeInfo1>(jsonString);
        if (Status.Instance.CreamStatus == true)
        {
            data1._CakeP1[2]._status = 0;
            data1._CakeP1[1]._status = 1;
            if (creamflavor == CreamFlavor.chocolate)
            {
                data1._CakeP1[1]._type = 0;
                string newdata1 = JsonUtility.ToJson(data1);
                File.WriteAllText(path, newdata1);
            }
            if (creamflavor == CreamFlavor.white)
            {
                data1._CakeP1[1]._type = 1;
                string newdata1 = JsonUtility.ToJson(data1);
                File.WriteAllText(path, newdata1);
            }
            if (creamflavor == CreamFlavor.casda)
            {
                data1._CakeP1[1]._type = 2;
                string newdata1 = JsonUtility.ToJson(data1);
                File.WriteAllText(path, newdata1);
            }
        }
    }
    public void UpdateProduct()
    {
        jsonString = File.ReadAllText(path);
        data1 = JsonUtility.FromJson<CakeInfo1>(jsonString);
        if (Status.Instance.ProductStatus == true)
        {
            data1._CakeP1[2]._status = 1;
            if (productflavor == ProductFlavor.butter)
            {
                data1._CakeP1[2]._type = 0;
                string newdata1 = JsonUtility.ToJson(data1);
                File.WriteAllText(path, newdata1);
            }
            if (productflavor == ProductFlavor.yellowbutter)
            {
                data1._CakeP1[2]._type = 1;
                string newdata1 = JsonUtility.ToJson(data1);
                File.WriteAllText(path, newdata1);
            }
            if (productflavor == ProductFlavor.chobutter)
            {
                data1._CakeP1[2]._type = 2;
                string newdata1 = JsonUtility.ToJson(data1);
                File.WriteAllText(path, newdata1);
            }
            if (productflavor == ProductFlavor.cherry)
            {
                data1._CakeP1[2]._type = 3;
                string newdata1 = JsonUtility.ToJson(data1);
                File.WriteAllText(path, newdata1);
            }
            if (productflavor == ProductFlavor.chobar)
            {
                data1._CakeP1[2]._type = 4;
                string newdata1 = JsonUtility.ToJson(data1);
                File.WriteAllText(path, newdata1);
            }
        }
    }
    public enum Flavor
    {
        chocolate, strawberry, blueberry, original
    }
    public enum CreamFlavor
    {
        chocolate, white, casda
    }
    public enum ProductFlavor
    {
        butter, yellowbutter, chobutter, cherry, chobar
    }
}
[System.Serializable]
public class Mapping1
{
    public string _name;
    public int _type;
    public int _status;
}
[System.Serializable]
public class CakeInfo1
{
    public Mapping1[] _CakeP1;
}

