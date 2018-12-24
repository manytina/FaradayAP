using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadFile : MonoBehaviour {

    public TextAsset textFile;
    public int layoutHeight;

    private GameObject clonePanel;
    private string[] days;

    private int count = 0;

	// Use this for initialization
	void Start () {
        days = textFile.text.Split(char.Parse("\n"));
        clonePanel = transform.GetChild(0).gameObject;

        string[] items = days[0].Split(char.Parse("@"));

        float textOffset = (float)(layoutHeight / items.Length * 2.0f);
        gameObject.GetComponent<GridLayoutGroup>().cellSize = new Vector2(100, textOffset);
        
        Text textObject = clonePanel.transform.GetChild(0).gameObject.GetComponent<Text>();
        textObject.text = items[0];

        for (int i = 1; i < items.Length; i++)
        {
            GameObject panel = Instantiate(clonePanel) as GameObject;
            panel.transform.parent = gameObject.transform;
            Text obj = panel.transform.GetChild(0).gameObject.GetComponent<Text>();
            obj.text = items[i];
        }
        
	}
	
	// Update is called once per frame
	void Update () {
        count++;
        if (count != 200) return;

        for(int i = 1; i < transform.childCount; i++)
        {
            GameObject.Destroy(transform.GetChild(i).gameObject);
        }

        string[] items = days[1].Split(char.Parse("@"));

        float textOffset = (float)(layoutHeight / items.Length * 2.0f);
        gameObject.GetComponent<GridLayoutGroup>().cellSize = new Vector2(100, textOffset);

        Text textObject = clonePanel.transform.GetChild(0).gameObject.GetComponent<Text>();
        textObject.text = items[0];

        for (int i = 1; i < items.Length; i++)
        {
            GameObject panel = Instantiate(clonePanel) as GameObject;
            panel.transform.parent = gameObject.transform;
            Text obj = panel.transform.GetChild(0).gameObject.GetComponent<Text>();
            obj.text = items[i];
        }

	}
}
