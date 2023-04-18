using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{
    [SerializeField]
    private string _previousScene;
    [SerializeField]
    private List<StateStruct> _states = new List<StateStruct>();

    [Serializable]
    public enum SettingsState
    {
        Game,
        Controls,
        Video
    }

    [Serializable]
    public struct StateStruct
    {
        public GameObject GameObject;
        public SettingsState State;
        public Button Button;
    }


    private SettingsState _currentState;

    private void Awake()
    {
        SwitchSettingsState(0);
    }

    public void CloseSettings()
    {
        SceneManager.LoadScene(_previousScene);
    }

    public void SwitchSettingsState(int state)
    {
        _currentState = (SettingsState)state;
        foreach (StateStruct stateGameObject in _states)
        {
            stateGameObject.GameObject.SetActive(false);
        }
    }

    private GameObject GetStateGameObject(SettingsState state)
    {
        return _states.Find(sgo => sgo.State == state).GameObject;
    }

    private Button GetStateButton(SettingsState state)
    {
        return _states.Find(sgo => sgo.State == state).Button;
    }
}
