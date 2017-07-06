using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using unitycoder_MobilePaint;

public class PainContainController : MonoBehaviour {

    public GameObject model;
    public GameObject onPainPlane;

    public MobilePaint mobilePain;
    public void ButtonShowClick()
    {
        model.GetComponent<ModelController>().renderModel.sharedMaterial.mainTexture = FindObjectOfType<MobilePaint>().tex;
        model.SetActive(true);
        onPainPlane.SetActive(false);
    }
}
