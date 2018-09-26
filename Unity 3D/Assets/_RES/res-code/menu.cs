using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour {

	public void GoToMainMenu(){
		Application.LoadLevel("2-menu");
	}

	public void GoToARCamera(){
		Application.LoadLevel("3-arcamera");
	}
	
	public void GoToVideo(){
		Application.LoadLevel("4-video");
	}
	
	public void GoToManual(){
		Application.LoadLevel("5-manual");
	}
	
	public void GoToAbout(){
		Application.LoadLevel("6-about");
	}

	public void ExitApplication(){
		Application.Quit ();
	}
	
	public void ContactClick(){
		Application.OpenURL("tel://+6289680001588");
	}
	
	public void LocationClick(){
		Application.OpenURL("https://goo.gl/maps/XfePJ5PN4W22");
	}
	
	public void MarkerDownloadClick(){
		Application.OpenURL("https://drive.google.com/open?id=1n9MqLSlCdzsG7cmNqgtsrK4ARMD5zle2");
	}
	
	public void AppDownloadClick(){
		Application.OpenURL("https://play.google.com/store?hl=en");
	}

}
