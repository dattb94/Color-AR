using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using unitycoder_MobilePaint;

public class PainContainController : MonoBehaviour {

    public GameObject model;
    public GameObject onPainPlane;

    //public MobilePaint mobilePain;
    public GameObject mainContain, painContain;
    public void ButtonShowClick()
    {
        //mainContain.SetActive(true);
        //painContain.SetActive(false);
        Application.LoadLevel(0);
    }
    IEnumerator WaitSavePng()
    {
        yield return new WaitForEndOfFrame();
        SaveTeture2D();
        model.GetComponent<ModelController>().renderModel.sharedMaterial.mainTexture = FindObjectOfType<MobilePaint>().tex;
        model.SetActive(true);
        onPainPlane.SetActive(false);
    }
    public void SaveTeture2D()
    {

        Texture2D tex = new Texture2D(FindObjectOfType<MobilePaint>().tex.width, FindObjectOfType<MobilePaint>().tex.height);

        if(!System.IO.Directory.Exists(Application.persistentDataPath + "/Texture2D"))
            System.IO.Directory.CreateDirectory(Application.persistentDataPath + "/Texture2D");
        string path = Application.persistentDataPath + "/Texture2D/" +
            Modules.modelPainting.GetComponent<ModelController>().nameModel + ".png";
        //print(tex.width+"  "+ tex.height);
        //for (int i = 0; i < tex.width; i++)
        //    for (int j = 0; j < tex.height; j++)
        //        tex.SetPixel(i, j, FindObjectOfType<MobilePaint>().tex.GetPixel(i, j));
        //tex.Apply();

        //tex.ReadPixels(new Rect(0, 0, tex.width, tex.height), 0, 0);
        //tex.Apply();
        //var bytes = tex.EncodeToPNG();
        //print(bytes.Length);
        //Destroy(tex);
        //System.IO.File.WriteAllBytes(path, bytes);
        //print(path);
        FindObjectOfType<MobilePaint>().GetPixels(Modules.pixels);
        tex.LoadRawTextureData(Modules.pixels);
        tex.ReadPixels(new Rect(0, 0, tex.width, tex.height), 0, 0);
        tex.Apply();
        var bytes = tex.EncodeToPNG();
        Destroy(tex);
        System.IO.File.WriteAllBytes(path, bytes);


        //FindObjectOfType<MobilePaint>().tex.ReadPixels(new Rect(0, 0, FindObjectOfType<MobilePaint>().tex.width, 
        //    FindObjectOfType<MobilePaint>().tex.height), 0, 0);
        //FindObjectOfType<MobilePaint>().tex.Apply();
        //var bytes = FindObjectOfType<MobilePaint>().tex.EncodeToPNG();
        //System.IO.File.WriteAllBytes(path, bytes);
    }

    public void ButtonColorClick(UnityEngine.UI.Image img)
    {
        Modules.penColor = new Color32( (byte)(img.color.r * 255),
                                        (byte)(img.color.g * 255),
                                        (byte)(img.color.b * 255),
                                        255);
    }

}
