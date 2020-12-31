using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputText : MonoBehaviour
{
	public string nameValue;
		
	public void OnChange()
	{
		nameValue = GetComponent<InputField>().text;
		Debug.Log("new things are being typed: " + nameValue);
	}
}
