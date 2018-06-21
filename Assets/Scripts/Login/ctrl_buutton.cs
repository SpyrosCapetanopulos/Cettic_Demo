using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ctrl_buutton : MonoBehaviour {

    public GameObject subPanel = null;
    public GameObject PrincialPanel = null;
    public bool _subPanelOpened = false;
    public bool _principalPanelOpened = true;


    public void ToggleSubPanelOpen(){
        
        _subPanelOpened = !_subPanelOpened;
        _principalPanelOpened = !_principalPanelOpened;


        setSubPanelVisibility();
    }

    private void setSubPanelVisibility()
    {
        if (subPanel != null && PrincialPanel != null)
        {
            subPanel.SetActive(_subPanelOpened);
            PrincialPanel.SetActive(_principalPanelOpened);
        }
    }
}
