using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShot : MonoBehaviour
{
    public Camera camera;
    public Rect rect;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void print1()
    {
        CaptureCamera();
    }
    Texture2D CaptureCamera()
    {
        // 創建一個RenderTexture對象
        RenderTexture rt = new RenderTexture((int)rect.width, (int)rect.height, 0);
        // 臨時設置相關相機的targetTexture為rt, 並手動渲染相關相機
        camera.targetTexture = rt;
        camera.Render();
        //ps: --- 如果這樣加上第二個相機，可以實現只截圖某幾個指定的相機一起看到的圖像。
        //ps: camera2.targetTexture = rt;
        //ps: camera2.Render();
        //ps: -------------------------------------------------------------------

        // 激活這個rt, 並從中中讀取像素。
        RenderTexture.active = rt;
        Texture2D screenShot = new Texture2D((int)rect.width, (int)rect.height, TextureFormat.RGB24, false);
        screenShot.ReadPixels(rect, 0, 0);// 註：這個時候，它是從RenderTexture.active中讀取像素
        screenShot.Apply();

        // 重置相關參數，以使用camera繼續在屏幕上顯示
        camera.targetTexture = null;
        //ps: camera2.targetTexture = null;
        RenderTexture.active = null; // JC: added to avoid errors
        GameObject.Destroy(rt);
        // 最後將這些紋理數據，成一個png圖片文件
        byte[] bytes = screenShot.EncodeToPNG();
        string filename = Application.dataPath + "/Photo/Screenshot.png";
        System.IO.File.WriteAllBytes(filename, bytes);
        Debug.Log(string.Format("截屏了一張照片: {0}", filename));
        return screenShot;
    }
}
