using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour
{

	public Text text;
	private enum States {chavant_0, banc, affiche, tram, chavant_1, nord, est, ouest, bobine, chavant_2, chavant_3};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.chavant_0;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		
		if (myState == States.chavant_0) {
			chavant();
		} else if (myState == States.banc) {
			banc();
		} else if (myState == States.tram) {
			tram();
		} else if (myState == States.affiche) {
			papier();
		} else if (myState == States.chavant_1) {
			chavant_1();
		} else if (myState == States.nord) {
			nord();
		} else if (myState == States.est) {
			est();
		} else if (myState == States.ouest) {
			ouest();
		} else if (myState == States.chavant_2) {
			chavant_2();
		} else if (myState == States.chavant_3) {
			chavant_3();
		} else if (myState == States.bobine) {
			bobine();
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
			myState = States.chavant_0;						
		} 			
	}
	
	void tram() {
		
		text.text = "Le tram qui arrive est un C. Evidemment c'est toujours celui que l'on attend pas qui arrive en premier.\n\n" +
					"Appui sur R pour observer autre chose.";
		
		if (Input.GetKeyDown (KeyCode.R)) {			
			myState = States.chavant_0;						
		} 			
	}
	
	void papier() {
		
		text.text = "En approchant de l'affiche, tu remarques un morceau de papier avec quelque chose de griffonné dessus.\n\n" +
					"Appui sur L pour Lire le papier, ou sur R pour observer autre chose.";
		
		if (Input.GetKeyDown (KeyCode.R)) {			
			myState = States.chavant_0;						
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.chavant_1;
		}			
	}
	
	void chavant_1() {
		
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
	
	void chavant_2() {
		text.text = "Bon c'est toujours le meme arret de tram finalement.\n\n" +
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
			myState = States.chavant_2;
		}	
	}
	
	void ouest() {
	
		text.text = "Te voilà sur les berges du Drac. C'est un bon endroit pour faire du roller/vélo, mais pour le Molkky, j'en doute.\n\n" + 
					"Appui sur C pour retourner à Chavant.";
			
		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.chavant_2;
		}
	}
	
	void est() {
		
		text.text = "Le parc Mistral, effectivement haut lieu du Molkky Grenoblois. Mais soudain une goutte tombe, puis une autre, et une autre. " +
					"Bientot c'est un vrai déluge. Ca ne te rappelle rien ? Peut-etre que tu peux te mettre à l'abris quelque part ?\n\n" + 
					"Appui sur B pour t'approcher de la Bobine, sur C pour retourner à Chavant.";
		
		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.chavant_3;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.bobine;
		}
		
	}
	
	void chavant_3() {
	
		text.text = "Il pleut et les abris sont bondés... Mauvaise idée...\n\n" +
					"Appui sur R pour retourner vers le Parc Mistral.";
		
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.est;
		}
		
	}
	
	void bobine() {
	
		text.text = "La terrasse couverte est pleine et il n'y a pas de chaises, l'intérieur n'est pas mieux.\n" + 
					"\n\n" +
					"Appui sur R pour retourner vers le Parc Mistral.";
		
	}
	
}
