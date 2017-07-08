using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainContainController : MonoBehaviour {
    public List<GameObject> models;
    public GameObject go_Models;
    void Start()
    {
        models = new List<GameObject>();
        for (int i = 0; i < go_Models.transform.childCount; i++)
        {
            models.Add(go_Models.transform.GetChild(i).gameObject);
        }

    }
    //Xu ly button
    public GameObject mainContain, painContain;

    public GameObject listImagePainBox;
    public void ButtonShowListImagePain()
    {
        listImagePainBox.SetActive(true);
    }
    public void ButtonHideListImagePain()
    {
        listImagePainBox.SetActive(false);
    }

    public void ButtonImagePain(GameObject _model)
    {
        //Modules.modelPainting = _model;
        //Modules.maskTexture = _model.GetComponent<ModelController>().maskTexture;
        //Modules.texturePainting = _model.GetComponent<ModelController>().mainTexture;

        //mainContain.SetActive(false);
        //painContain.SetActive(true);



    }
    //public void ButtonImagePain

    //
}
