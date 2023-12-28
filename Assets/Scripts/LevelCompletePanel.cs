using System.Collections;
using System.Collections.Generic;
using Game;
using dotmob;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelCompletePanel : ShowHidable
{
    [SerializeField] private Image _toastTxt;
    [SerializeField] private TextMeshProUGUI _levelTxt;
    [SerializeField] private List<string> _toasts = new List<string>();



    private void Awake()
    {
        _levelTxt.text = $" Level {LevelManager.Instance.Level.no}"; 
    }

    protected override void OnShowCompleted()
    {
        base.OnShowCompleted();
        // _toastTxt.text = _toasts.GetRandom();
        _toastTxt.gameObject.SetActive(true);

        AdsManager.ShowOrPassAdsIfCan();
    }


    public void OnClickContinue()
    {
        UIManager.Instance.LoadNextLevel();
    }

    public void OnClickMainMenu()
    {
        GameManager.LoadScene("MainMenu");
        SharedUIManager.PausePanel.Hide();
    }
}