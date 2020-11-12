using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class PisanieTekstu : MonoBehaviour 
{

	Text txt;
	string schowek;
	bool trigger;


	private void Start()
	{
		trigger = false;
	}
	private void Update()
	{
		if (gameObject.activeInHierarchy)
		{
			if (trigger == false)
			{
				// weź tekst początkowy
				txt = GetComponent<Text>();
				schowek = txt.text;
				txt.text = "";


				StartCoroutine("PlayText");
				trigger = true;
			}
		} else
		{
			trigger = false;
		}
	}

	IEnumerator PlayText()
{
	foreach (char c in schowek)
	{
		txt.text += c;
		yield return new WaitForSeconds(0.125f);
	}
}

}