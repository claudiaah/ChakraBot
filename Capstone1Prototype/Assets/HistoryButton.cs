using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HistoryButton : MonoBehaviour
{

    public GameObject historyPanel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OpenHistory()
    {
        historyPanel.SetActive(true);

    }

    public void CloseInfoScreen()
    {
        historyPanel.SetActive(false);

    }

}
