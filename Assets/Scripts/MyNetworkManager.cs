using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

	public void MyStartHost() {
		Debug.Log("Starting Host at " + Time.timeSinceLevelLoad);
		GetComponent<NetworkManager>();
		StartHost();
		// string theTime = System.DateTime.Now.ToString();
	}

	public override void OnStartHost() {
		Debug.Log("Host started at " + Time.timeSinceLevelLoad);
	}
}
