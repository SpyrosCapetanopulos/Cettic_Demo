using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popUp : MonoBehaviour {

    /* Se registran los Paneles de Login, Register y Popup  */
    public GameObject subPanel = null;
    public GameObject PrincialPanel = null;
    public GameObject popUpPanel = null;
	
    public bool _subPanelOpened = false;
    public bool _principalPanelOpened = false;
    public bool _popupPanelOpened = true;


    public void ToggleSubPanelOpen()
    {

        _subPanelOpened = !_subPanelOpened;
       //_principalPanelOpened = !_principalPanelOpened;
        _popupPanelOpened = !_popupPanelOpened;

        setSubPanelVisibility();
    }

    private void setSubPanelVisibility()
    {
        if (subPanel != null && PrincialPanel != null)
        {
            subPanel.SetActive(_subPanelOpened);
            //PrincialPanel.SetActive(_principalPanelOpened);
            popUpPanel.SetActive(_popupPanelOpened);
        }
    }
}
