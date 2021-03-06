﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private ChessNetworkManager networkManager = null;

    [Header("UI")]
    [SerializeField] private GameObject landingPagePanel = null;
    public void HostLobby(){
        if(networkManager == null){
            networkManager = GameObject.Find("NetworkManager").GetComponent<ChessNetworkManager>();
        }
        networkManager.StartHost();
        landingPagePanel.SetActive(false);
    }
}
