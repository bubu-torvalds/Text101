using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour
{

	public Text text;
	private enum States {chavant, banc, affiche, tram, papier_chavant, nord, est, ouest, change_scene};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.chavant;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		
		if (myState == States.chavant) {
			chavant();
		} else if (myState == States.banc) {
			banc();
		} else if (myState == States.tram) {
			tram();
		} else if (myState == States.affiche) {
			papier();
		} else if (myState == States.papier_chavant) {
			papier_chavant();
		} else if (myState == States.nord) {
			nord();
		} else if (myState == States.est) {
			est();
		} else if (myState == States.ouest) {
			ouest();
		}
		
	}
	
	void chavant() {
	
		text.text = "Tu te trouves à l'arret de tram de Chavant, tu dois trouver quelque-chose, mais tu ne sais pas encore quoi." +
					"Il y a un banc, une affiche de publicité de JC Decaux et un tram qui arrive.\n\n" +
					"Appui sur B pour observer le Banc, A pour observer l'affiche, T pour observer le Tram.";
					
		if (Input.GetKeyDown (KeyCode.B)) {			
			myState = States.banc;						
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.tram;
		} else if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.affiche;
		}	
	}
	
	void banc() {
		
		text.text = "C'est juste un banc d'arret de tram, il est sale et peu intéressant, mais nous y avons passé pas mal de temps au début, à attendre.\n\n" +
					"Appui sur R pour observer autre chose.";
		
		if (Input.GetKeyDown (KeyCode.R)) {			
			myState = States.chavant;						
		} 			
	}
	
	void tram() {
		
		text.text = "Le tram qui arrive est un C. Evidemment c'est toujours celui que l'on attend pas qui arrive en premier.\n\n" +
					"Appui sur R pour observer autre chose.";
		
		if (Input.GetKeyDown (KeyCode.R)) {			
			myState = States.chavant;						
		} 			
	}
	
	void papier() {
		
		text.text = "En approchant de l'affiche, tu remarques un morceau de papier avec quelque chose de griffonné dessus.\n\n" +
					"Appui sur L pour Lire le papier, ou sur R pour observer autre chose.";
		
		if (Input.GetKeyDown (KeyCode.R)) {			
			myState = States.chavant;						
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.papier_chavant;
		}			
	}
	
	void papier_chavant() {
		
		text.text = "'On peut parfois y rencontrer un champion de Molkky.' Voilà tout ce qui est écrit sur ce papier.\n\n" +
					"Appui sur N pour aller vers le Nord, sur E pour aller vers l'Est ou sur O pour aller vers l'Ouest.";
		
		if (Input.GetKeyDown (KeyCode.N)) {			
			myState = States.nord;						
		} else if (Input.GetKeyDown (KeyCode.E)) {
			myState = States.est;
		} else if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.ouest;
		}
	
	}
	
	void nord() {
		
		text.text = "Te voilà sur les berges de l'Isère. C'est joli, mais il peut probable de trouver un joueur de Molkky ici, non ?\n\n" + 
					"Appui sur C pour retourner à Chavant.";
					
		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.papier_chavant;
		}	
	}
	
	void ouest() {
	
		text.text = "Te voilà sur les berges du Drac. C'est un bon endroit pour faire du roller/vélo, mais pour le Molkky, j'en doute.\n\n" + 
					"Appui sur C pour retourner à Chavant.";
			
		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.papier_chavant;
		}
	}
	
	void est() {
		
		
		
	}
	
}
