using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanelsButton : MonoBehaviour
{
    // id of panel we want to show 
    public string PanelID;

    // Cached panels manager
    private PanelManager _panelManager;

    private void Start()
    {
        // cache this 
        _panelManager = PanelManager.Instance;
    }

    public void DoShowPanel()
    {
        PanelManager.Instance.ShowPanel(PanelID);
    }
}
