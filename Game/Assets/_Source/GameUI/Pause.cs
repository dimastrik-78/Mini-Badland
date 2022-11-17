using System;
using UnityEngine;

namespace _Source.GameUI
{
    public class Pause : MonoBehaviour
    {
        public static Action OnPause;
        public static Action OnContinue;
        public static Action OnRestart;
        
        [SerializeField] private GameObject pausePanel;
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape) && !pausePanel.activeSelf)
            {
                OnPause?.Invoke();
                
                pausePanel.SetActive(true);
            }
            else if (Input.GetKeyDown(KeyCode.Escape) && pausePanel.activeSelf)
            {
                OnContinue?.Invoke();
                
                pausePanel.SetActive(false);
            }
        }

        public void Continue()
        {
            OnContinue?.Invoke();
            
            pausePanel.SetActive(false);
        }

        public void ResetLevel()
        {
            OnRestart?.Invoke();
        }
    }
}
