using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ShowContainController : MonoBehaviour {
    public Transform point;//diem dat show model
	void Start () {
        GameObject model = (GameObject)Instantiate(Modules.modelPainting, point.position, point.rotation);
        model.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        model.name = Modules.modelPainting.name;
        model.GetComponent<ModelController>().renderModel.sharedMaterial.mainTexture = Modules.TextureMain(model.name);
        
	}

    //Xu ly button
    public void ButtonBackMainClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
