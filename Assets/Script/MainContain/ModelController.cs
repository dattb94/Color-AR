using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using unitycoder_MobilePaint;
public class ModelController : MonoBehaviour {
    public Texture2D mainTexture, maskTexture;
    public Renderer renderModel;
    public string nameModel = "";

    // Use this for initialization
    void Start() {
        nameModel = gameObject.name;
        print(Application.persistentDataPath);
        //khoi tao main texture.

        if (!File.Exists(Application.persistentDataPath + "/Texture2D/" + nameModel + ".png"))
        {
            mainTexture = new Texture2D(960, 688, TextureFormat.ARGB32, false);
            for (int i = 0; i < 960; i++)
                for (int j = 0; j < 688; j++)
                    mainTexture.SetPixel(i, j, Color.white);
            mainTexture.Apply();
        }
        else {
            var bytes = File.ReadAllBytes(Application.persistentDataPath + "/Texture2D/" + nameModel + ".png");
            mainTexture = new Texture2D(960, 688);
            mainTexture.LoadImage(bytes);
            mainTexture.Apply();
        }
        if (GameObject.Find("MainContainController"))
        {

            renderModel.sharedMaterials[0].mainTexture = this.mainTexture;
        }
        else {
            if (FindObjectOfType<MobilePaint>())
                renderModel.sharedMaterials[0].mainTexture = FindObjectOfType<MobilePaint>().tex;
        }
    }

    // Update is called once per frame
    void Update() {
       
    }
}
