using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public WebCamTexture mCamera = null;
    public Renderer plane;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Script has been started");
        mCamera = new WebCamTexture();
        plane.material.mainTexture = mCamera;
        mCamera.Play();

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            string path = Application.dataPath + "/avatar.png";
            
            Texture2D tex;
            tex = new Texture2D(plane.material.mainTexture.width, plane.material.mainTexture. height);
            tex.SetPixels(mCamera.GetPixels());
            var bytes = tex.EncodeToPNG();
            System.IO.File.WriteAllBytes(path, bytes);
        }
    }
}
