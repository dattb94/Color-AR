using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListImagePainController : MonoBehaviour
{
    public MainContainController mainControl;

    public GameObject buttonImage;

    // Use this for initialization
    void Start()
    {
        print(Application.persistentDataPath);
        mainControl = FindObjectOfType<MainContainController>();

        for (int i = 0; i < mainControl.models.Count; i++)
        {
            GameObject btn = (GameObject)Instantiate(buttonImage);
            btn.transform.SetParent(gameObject.transform);
            btn.GetComponent<ButtonImageController>().model = mainControl.models[i];

            btn.name = "Image" + mainControl.models[i].GetComponent<ModelController>().nameModel;

            Sprite main = Sprite.Create(mainControl.models[i].GetComponent<ModelController>().mainTexture,
                new Rect(0, 0, mainControl.models[i].GetComponent<ModelController>().mainTexture.width,
                            mainControl.models[i].GetComponent<ModelController>().mainTexture.height),
                new Vector2(0, 0));

            Sprite mask = Sprite.Create(mainControl.models[i].GetComponent<ModelController>().maskTexture,
                new Rect(0, 0, mainControl.models[i].GetComponent<ModelController>().maskTexture.width,
                            mainControl.models[i].GetComponent<ModelController>().maskTexture.height),
                new Vector2(0, 0));

            btn.GetComponent<Image>().sprite = main;
            btn.transform.GetChild(0).GetComponent<Image>().sprite = mask;

            SetData();
        }
    }
    void SetData()
    {
        int row = 0;
        if (transform.childCount % 3 == 0)
            row = transform.childCount / 3;
        else 
            row = (int)transform.childCount / 3 + 1;
        GetComponent<RectTransform>().sizeDelta = new Vector2(GetComponent<RectTransform>().sizeDelta.x, 
            row*GetComponent<GridLayoutGroup>().cellSize.y+ GetComponent<GridLayoutGroup>().padding.top+ GetComponent<GridLayoutGroup>().spacing.y*row);
    }
}
