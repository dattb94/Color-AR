using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainContainController : MonoBehaviour {


    //Xu ly button
    public GameObject mainContain, painContain;

    public void ButtonImagePain(GameObject _model)
    {
        Modules.modelPainting = _model;
        mainContain.SetActive(false);
        painContain.SetActive(true);
    }
    //public void ButtonImagePain

    //
}
