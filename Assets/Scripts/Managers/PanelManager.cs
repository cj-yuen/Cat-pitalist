using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : Singleton<PanelManager>
{
    // list of all panels
    public List<PanelModel> Panels;

    // hold all curr instances
    private Queue<PanelInstanceModel> _queue = new Queue<PanelInstanceModel>();

    public void ShowPanel(string panelID)
    {
        PanelModel panelModel = Panels.FirestOrDefault(panel => panel.PanelID == panelID);

        if(panelModel != null)
        {
            // Create new instance
            var newInstancePanel = Instantiate(panelModel.PanelPrefab, transform);

            // Add this new panel to queue
            _queue.Enqueue(new.PanelInstanceModel
            {
                PanelID = panelID,
                PanelInstance = newInstancePanel
            });
        } 
        else
        {
            Debug.LogWarning($"Trying to use panelID = {panelID}, but it does not exist in Panels list");
        }
    }
}