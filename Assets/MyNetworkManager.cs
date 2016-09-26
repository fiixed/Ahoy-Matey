using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

	public void MyStartHost() {
		Debug.Log("Starting Host. " + Time.timeSinceLevelLoad);
		GetComponent<NetworkManager>();
		StartHost();
		// string theTime = System.DateTime.Now.ToString();
	}

	public override void OnStartHost() {
		Debug.Log("Host started. " + Time.timeSinceLevelLoad);
	}

	public override void OnStartClient(NetworkClient myClient) {
		Debug.Log("Client start requested. " + Time.timeSinceLevelLoad);
		InvokeRepeating("PrintDots", 0f, 1f);
		
	}

	public override void OnClientConnect(NetworkConnection conn) {
		Debug.Log("Client is connected to IP: " + conn.address + " at. " + Time.timeSinceLevelLoad);
		CancelInvoke();
	}

	void PrintDots() {
		Debug.Log(".");
	}
}
