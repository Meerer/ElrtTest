using UnityEngine;
using Photon;

public class RandomMatchmaking : Photon.PunBehaviour {

	// Use this for initialization
	void Start () {
        PhotonNetwork.ConnectUsingSettings("0.1");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnGUI()
    {
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
    }
    public override void OnJoinedLobby()
    {
        PhotonNetwork.JoinRandomRoom();
    }
    void OnPhotonRandomJoinFailed()
    {
        Debug.Log("Can't join random room!");
        PhotonNetwork.CreateRoom(null);
    }
    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        GameObject g = PhotonNetwork.Instantiate("elephant", Vector3.zero, Quaternion.identity, 0);
        g.GetComponent<movementTestOnline>().enabled = true;
        GameObject camera = PhotonNetwork.Instantiate("Main Camera", new Vector3(0,0,-10), Quaternion.identity, 0);
        camera.GetComponent<RtsCameraa>().enabled = true;


    }
}
