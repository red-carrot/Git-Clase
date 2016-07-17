using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Colisiones : MonoBehaviour 
{
	void OnCollisionEnter (Collision coli)
	{
		cambiarNivel ();
	}

	void cambiarNivel ()
	{
		SceneManager.LoadScene ("escena2");
	}
}
