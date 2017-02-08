using UnityEngine;
using Scripts.Utility.Configuration;
using Scripts.Utility.Console;
using Scripts.Utility.LanguageSystem;

public class TEST : MonoBehaviour {
    private Console console;
    private Configurator cfg;
    private ILanguageSystem lm;

	// Use this for initialization
	void Start () {
        console = Console.GetInstance ();
        cfg = Configurator.GetInstance ();
        lm = LanguageManager.GetInstance ();
        lm.LoadTextsFrom ( LanguageFiles.MENU );
        Debug.Log ( Language.Polish.ToString () + " " + Language.English.ToString () );
	}
	
	// Update is called once per frame
	void Update () {
        /*if ( Input.GetKeyDown ( KeyCode.S ) )
            cfg.ChangeLanguage ( Language.English );
        if ( Input.GetKeyDown ( KeyCode.A ) )
            cfg.ChangeLanguage ( Language.Polish);

        if (Input.GetKeyDown (KeyCode.W))
            console.AddLog ( cfg.GetLanguage().ToString (), )
            */


    }
}
