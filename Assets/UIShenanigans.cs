using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIShenanigans : MonoBehaviour {

    public Text[] allText;
    public Font[] allFonts;
    public Color[] allColors;

	// Update is called once per frame
	void Update () {
        if (Random.Range(0, 2) == 1) return;

        foreach (Text t in allText)
        {
            t.font = allFonts[Random.Range(0, allFonts.Length)];
            t.color = allColors[Random.Range(0, allColors.Length)];
            t.fontStyle = (Random.Range(0, 3) == 0 ? FontStyle.Bold : (Random.Range(0, 3) == 0 ? FontStyle.Italic : FontStyle.BoldAndItalic));
        }
	}
}
