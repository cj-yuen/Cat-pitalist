using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanelButton : MonoBehaviour
{
    // id of panel we want to show
    public string PanelID;

    // cached panels manager
    private PanelManager _panelManager;

    private void Start()
    {
        // cache this
        _panelManager = PanelManager.Instance;
    }

    public void DoShowPanel()
    {
        _panelManager.Instance.ShowPanel(PanelID);
    }
}
 