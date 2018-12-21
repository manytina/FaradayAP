using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadFile : MonoBehaviour {

    public TextAsset textFile;
    public GameObject clonePanel;
    public int layoutHeight;

	// Use this for initialization
	void Start () {
        string text = textFile.text;
        string[] items = text.Split(char.Parse("@"));

        float textOffset = (float)(layoutHeight / items.Length * 2.0f);
        gameObject.GetComponent<GridLayoutGroup>().cellSize = new Vector2(100, textOffset);

        Vector3 localPosition = new Vector3(50.0f, -textOffset / 2.0f, 0.0f);
        Text textObject = clonePanel.transform.GetChild(0).gameObject.GetComponent<Text>();
        textObject.text = items[0];
        textObject.rectTransform.localPosition = localPosition;

        for (int i = 1; i < items.Length; i++) {
            GameObject panel = Instantiate(clonePanel) as GameObject;
            panel.transform.parent = gameObject.transform;
            Text obj = panel.transform.GetChild(0).gameObject.GetComponent<Text>();
            obj.text = items[i];
            obj.rectTransform.localPosition = localPosition;
        }
	}
	
	// Update is called once per frame
	void Update () {
//		Text textUI = gameObject.GetComponent<Text>();
//		textUI.text = text;


	}
}
