using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Logger : MonoBehaviour {

    private Camera cameraOrtho;
    public Text cameraLoggerText;
    public Text counterText;

	// Use this for initialization
	void Start () {

        //cameraLoggerText = GetComponent<Text>();
        cameraOrtho = GetComponent<Camera>();
        int nCubes = (GameObject.FindGameObjectsWithTag("cube").Length);
        counterText.text = "Num Cubes: " + nCubes.ToString() + "\n" +
             "Num Pairs: " + (nCubes / 2).ToString() + "\n" +
             "Leftovers: " + (nCubes % 2).ToString();
    }
	
	// Update is called once per frame
	void Update () {
 
        cameraLoggerText.text = "CSize: " + cameraOrtho.orthographicSize + "\n" +
            "CPosition: " + cameraOrtho.transform.localPosition + "\n" +
            "CRotation: " + cameraOrtho.transform.localRotation+ "\n";

        //Transform parentTransform = cameraOrtho.GetComponentInParent<GameObject>().transform;
        Transform parentTransform = (GameObject.FindGameObjectWithTag("targetCamera").transform);

        cameraLoggerText.text += 
            "CParentPos: " + parentTransform.transform.localPosition + "\n" +
            "CParentRot: " + parentTransform.transform.localRotation + "\n";

    }
}
