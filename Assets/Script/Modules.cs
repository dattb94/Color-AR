using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Modules : MonoBehaviour {
    public static GameObject modelPainting;

    public static Texture2D texturePainting=null;
    public static Texture2D maskTexture = null;

    public static Texture2D TextureMain(string _name)
    {
        Texture2D resuilt = new Texture2D(968, 688);
        if (File.Exists(Application.persistentDataPath + "/Texture2D/" + _name + ".png"))
        {
            var bytes = File.ReadAllBytes(Application.persistentDataPath + "/Texture2D/" + _name + ".png");
            resuilt = new Texture2D(960, 688);
            resuilt.LoadImage(bytes);
            resuilt.Apply();
        }
        else {
            resuilt = Texture2D.whiteTexture;
            resuilt.Apply();
        }

        return resuilt;
    }//lay 1 texture2D tu file png trong thu muc Texture2D 

    public static Color32 penColor;

    public static byte[] pixels;
}
