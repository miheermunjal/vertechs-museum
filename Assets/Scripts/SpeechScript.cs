using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechScript : MonoBehaviour {

    TextMesh textMesh;

	// Use this for initialization
	void Start () {
        textMesh = GetComponent<TextMesh>();
	}

    public void ExhibitOneText()
    {
        textMesh.text = "The Mona Lisa";
        textMesh.color = Color.blue;
    }

    public void ExhibitTwoText()
    {
        textMesh.text = "Lady with Primroses";
        textMesh.color = Color.green;
    }

    public void ExhibitThreeText()
    {
        textMesh.text = "The Last Supper";
        textMesh.color = Color.red;
    }

    public void startText()
    {
        textMesh.text = "Welcome to MR Museum!";
        textMesh.color = Color.white;
    }

    public void ColorBlue()
    {
        textMesh.color = Color.blue;
    }

    public void ColorRed()
    {
        textMesh.color = Color.red;
    }

    public void ColorGreen()
    {
        textMesh.color = Color.green;
    }
}
