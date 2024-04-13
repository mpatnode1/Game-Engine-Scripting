using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Week11
{

    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        public UnityEvent LoseGameOverEvent;

        public UnityEvent WinGameOverEvent;

        public UnityEvent OnRestart;

        private int score;

        private void Awake()
        {
            instance = this;
        }

        private void Start()
        {
            
        }

        [ContextMenu("Test DiedGameOver Event")]
        void DiedGameOver()
        {
            LoseGameOverEvent.Invoke();
        }

        [ContextMenu("Test WinGameOver Event")]
        void WinGameOver()
        {
            WinGameOverEvent.Invoke();
        }

        [ContextMenu("Test Restart Event")]
        public void Restart()
        {
            OnRestart.Invoke();
        }

        public static void AddLoseGameOverEventListener(UnityAction action)
        {
            instance.LoseGameOverEvent.AddListener(action);
        }

        public static void AddWinGameOverEventListener(UnityAction action)
        {
            instance.WinGameOverEvent.AddListener(action);
        }
    }
}