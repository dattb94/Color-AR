using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PainContainController : MonoBehaviour {

    public GameObject mainContain, painContain, showContain;
    void Update()
    {
        if (CameraPainController.saveDone)
        {
            CameraPainController.saveDone = false;
            showContain.SetActive(true);
            painContain.SetActive(false);
        }
    }

    //xu ly button
    public void ButtonSaveClick()
    {
        CameraPainController.save = true;
    }
    public void ButtonColorClick(UnityEngine.UI.Image img)
    {
        Modules.penColor = new Color32( (byte)(img.color.r * 255),
                                        (byte)(img.color.g * 255),
                                        (byte)(img.color.b * 255),
                                        255);
    }

}
