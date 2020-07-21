using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
	public Text scoreText;
	public Text userInput;

	int i =20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Change()
    {
        scoreText.text = userInput.text.ToString();
    }
}
