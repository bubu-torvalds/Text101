using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour
{

	public Text text;
	private enum States {chavant, banc, papier, affiche, papier_chavant, shannon, bobine, momento, change_scene};
	private States myState;

	// Use this for initialization
	void Start ()
	{
		myState = States.chavant;
	}
	
	// Update is called once per frame
	void Update ()
	{
		print (myState);
		
		if (myState == States.chavant) {
			state_chavant();
		} else if (myState == States.banc) {
			state_banc();
		} else if (myState == States.affiche) {
			state_affiche();
		} else if (myState == States.papier) {
			state_papier();
		} else if (myState == States.papier_chavant) {
			state_papier_chavant();
		} else if (myState == States.shannon) {
			state_shannon();
		} else if (myState == States.bobine) {
			states_bobine();
		} else if (myState == States.momento) {
			states_momento();
		}
		
	}
	
	void state_chavant() {
	
		text.text = "Tu te trouves à l'arret de tram de Chavant, tu dois trouver quelque-chose, " +
					"mais tu ne sais pas encore quoi. Il y a un banc, un morceau de papier coincé dans la vitre et une affiche.\n\n" +
					"Appui sur B pour voir le Banc, P pour voir le Papier, A pour voir l'Affiche.";
					
		if (Input.GetKeyDown (KeyCode.B)) {			
			myState = States.banc;						
		} else if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.affiche;
		} else if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.papier;
		}	
	}
	
	void state_banc() {
		
		text.text = "C'est juste un banc d'arret de tram, il est sale et peu intéressant.\n\n" +
					"Appui sur R pour retourner à Chavant.";
		
		if (Input.GetKeyDown (KeyCode.R)) {			
			myState = States.chavant;						
		} 			
	}
	
	void state_affiche() {
		
		text.text = "Une affiche de François Fillon avec des cornes et #RendsLargent tagé dessus.\n\n" +
					"Appui sur R pour retourner à Chavant.";
		
		if (Input.GetKeyDown (KeyCode.R)) {			
			myState = States.chavant;						
		} 			
	}
	
	void state_papier() {
		
		text.text = "En regardant le papier, tu vois quelque chose griffonné dessus. C'est peut-etre un indice, qui sait ?\n\n" +
					"Appui sur L pour Lire le papier, ou sur R pour retourner à Chavant.";
		
		if (Input.GetKeyDown (KeyCode.R)) {			
			myState = States.chavant;						
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.papier_chavant;
		}			
	}
	
	void state_papier_chavant() {
		
		text.text = "'Lieu pour un premier verre.' Voilà tout ce qui est écrit sur ce papier.\n\n" +
					"Appui sur N pour aller vers le Nord, sur E pour aller vers l'Est ou sur O pour aller vers l'Ouest.";
		
		if (Input.GetKeyDown (KeyCode.N)) {			
			myState = States.shannon;						
		} else if (Input.GetKeyDown (KeyCode.E)) {
			myState = States.bobine;
		} else if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.momento;
		}
	
	}
	
}
