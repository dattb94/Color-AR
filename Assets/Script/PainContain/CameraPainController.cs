using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using unitycoder_MobilePaint;
public class CameraPainController : MonoBehaviour {
    public static bool save=false;
    public static bool saveDone=false;

    // Use this for initialization
    void OnPostRender()
    {
        if (save)
        {
            FindObjectOfType<MobilePaint>().SaveTexture();
            save = false;
        }
    }
}
