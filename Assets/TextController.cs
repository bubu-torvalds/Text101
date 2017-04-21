using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour
{

	public Text text;

	// Use this for initialization
	void Start ()
	{
		text.text = "Bienvenue dans cette aventure textuelle.";
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			
			text.text = "Tu te trouves à l'arret de tram de Chavant, tu dois trouver quelque-chose, " +
						"mais tu ne sais pas encore quoi. Il y a un banc, un morceau de papier coincé dans la vitre et une affiche.\n\n" +
						"Appui sur B pour voir le Banc, P pour voir le Papier, A pour voir l'Affiche.";
		
		}
	}
}
