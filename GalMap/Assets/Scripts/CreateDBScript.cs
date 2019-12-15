using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class CreateDBScript : MonoBehaviour {

	public Text DebugText;

	// Use this for initialization
	void Start () {
		StartSync();
	}

    private void StartSync()
    {
        var ds = new DBHandler();
        
        var planets = ds.getPlanets();
        ToConsole (planets);
    }
	
	private void ToConsole(IEnumerable<Planet> people){
		foreach (var person in people) {
			ToConsole(person.ToString());
		}
	}
	
	private void ToConsole(string msg){
		DebugText.text += System.Environment.NewLine + msg;
		Debug.Log (msg);
	}
}
