using UnityEngine;
using System.Collections;
using System.IO;

public class theOneScriptToRuleThemAll : MonoBehaviour {
	public bool editor;
	public string dataLocation;
	// Use this for initialization
	void Start () {
		dataLocation = Application.persistentDataPath;
		string debugString = "Initializing from: " + dataLocation;
		Debug.Log (debugString);
		if (editor) {
			initEditor ();
		} else {
			initGame ();
		}
	}
	void initEditor() {
		if (!File.Exists (dataLocation + "levels.spectrum")) {
			File.Create (dataLocation+"levels.spectrum");
		}

		string levelsDataLocation = dataLocation + "levels.spectrum";
		Debug.Log (levelsDataLocation);
		StreamWriter writer = new StreamWriter (dataLocation+"levels.spectrum");
		writer.WriteLine ("yo yo");
		writer.WriteLine ("Mega Ho");
		writer.Close ();
		Debug.Log ("written");
		StreamReader reader = new StreamReader (dataLocation+"levels.spectrum");
		string line = reader.ReadLine ();
		Debug.Log (line);
		line = reader.ReadLine ();
		Debug.Log (line);



	}
	void initGame () {
	}
}
