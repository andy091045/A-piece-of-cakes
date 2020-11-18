using UnityEngine;
using System.Collections;
using System;
using System.IO;
using UnityEngine.UI;

/// <summary>
/// 截圖儲存安卓手機相簿
/// </summary>
public class CaptureScreenshotMgr : MonoBehaviour
{
    public Text text;
    string _name = "";

    /// <summary>
    /// 儲存截圖圖片，並且重新整理相簿 Android
    /// </summary>
    /// <param name="name">若空就按照時間命名</param>
    public void CaptureScreenshot()
    {
        _name = "";
        _name = "Screenshot_" + GetCurTime() + ".png";


#if UNITY_STANDALONE_WIN      //PC平臺
       // 編輯器下
       // string path = Application.persistentDataPath + "/" + _name;       
        string path = Application.dataPath + "/" + _name;
        ScreenCapture.CaptureScreenshot(path, 0);
        Debug.Log("圖片儲存地址" + path);

#elif UNITY_ANDROID     //安卓平臺
        //Android版本
        StartCoroutine(CutImage(_name));
        //在手機上顯示路徑
        // text.text = "圖片儲存地址" + Application.persistentDataPath.Substring(0, Application.persistentDataPath.IndexOf("Android")) + "/DCIM/Camera/" + _name;
        text.text = "圖片儲存地址" + Application.persistentDataPath.Substring(0, Application.persistentDataPath.IndexOf("Android")) + "/截圖/" + _name;
#endif
    }
    //截圖並儲存
    IEnumerator CutImage(string name)
    {
        //圖片大小  
        Texture2D tex = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, true);
        yield return new WaitForEndOfFrame();
        tex.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0, true);
        tex.Apply();
        yield return tex;
        byte[] byt = tex.EncodeToPNG();

        string path = Application.persistentDataPath.Substring(0, Application.persistentDataPath.IndexOf("Android"));

        //  File.WriteAllBytes(path + "/DCIM/Camera/" + name, byt);   //儲存到  安卓手機的  DCIM/下的Camera   資料夾下
        File.WriteAllBytes(path + "/截圖/" + name, byt);         //儲存到安卓手機的 檔案管理下面的  《截圖》資料夾下      
        string[] paths = new string[1];
        paths[0] = path;
        ScanFile(paths);
    }
    //重新整理圖片，顯示到相簿中
    void ScanFile(string[] path)
    {
        using (AndroidJavaClass PlayerActivity = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        {
            AndroidJavaObject playerActivity = PlayerActivity.GetStatic<AndroidJavaObject>("currentActivity");
            using (AndroidJavaObject Conn = new AndroidJavaObject("android.media.MediaScannerConnection", playerActivity, null))
            {
                Conn.CallStatic("scanFile", playerActivity, path, null, null);
            }
        }

    }
    /// <summary>
    /// 獲取當前年月日時分秒，如20181001444
    /// </summary>
    /// <returns></returns>
    string GetCurTime()
    {
        return DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString()
            + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
    }

}