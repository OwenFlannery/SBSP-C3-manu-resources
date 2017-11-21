﻿using UnityEngine;
using UnityEngine.UI;

public class ManuController : MonoBehaviour {

    public Text name;
    public Text description;
    public Button button;
    public Text cost;

    private ManuModel _manuModel;

    void Awake()
    {
        _manuModel = new ManuModel(name, description, button, cost);
        _manuModel.GetManuView().GetManufactureButton().onClick.AddListener(Manufactureing);
    }

    public ManuModel GetManuModel()
    {
        return _manuModel;
    }

    public void Manufactureing()
    {
        Debug.Log("Manufacturing:" + _manuModel.GetManufacture().GetName());
        /* undecided
        StartCoroutine(_manuModel.GetTimer().StartTimerCouroutine(_manuModel.GetManufacture().GeTimeTOManufacture(), this));
        */
    }


    /*
    public void OnStartTimer()
    {
        _manuModel.GetManuView().DisableResearchButton();
        _manuModel.GetManuView().GetTimeButton().text = "Time left: " + _ManuModel.GetTimer().GetRemainingSecondsInt();
    }

    public void OnIncrementTimer()
    {
        _researchModel.GetResearchView().GetTimeButton().text = "Time left: " + _researchModel.GetTimer().GetRemainingSecondsInt();
    }

    public void OnFinishTimer()
    {
        _researchModel.GetResearchView().GetTimeButton().text = "Researched";
        _researchModel.GetResearch().SetLearned(true);
        _researchModel.GetMainController().OnResearchFinishedEvent();
    }
    */
}
