using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonImageController : MonoBehaviour {

    public GameObject model;

    public void ButtonClick()
    {
        Modules.modelPainting = model;
        Modules.maskTexture = model.GetComponent<ModelController>().maskTexture;
        Modules.texturePainting = model.GetComponent<ModelController>().mainTexture;

        FindObjectOfType<MainContainController>().painContain.SetActive(true);
        FindObjectOfType<MainContainController>().mainContain.SetActive(false);
    }

}
