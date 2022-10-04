using TMPro;
using UnityEngine;

namespace Test
{
    public class QuestionOne : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI timerText;
        private float _tempTimer;
        private int _actualTimer;

        private void Update()
        {
            Timer();
        }

        private void Timer()
        {
            if (Time.timeScale != 0)
                _tempTimer += Time.deltaTime;

            _actualTimer = (int) _tempTimer;
            timerText.text = "Timer: " + _actualTimer;
        }

        public void TimeZero()
        {
            Time.timeScale = 0f;
        }
        public void TimeOne()
        {
            Time.timeScale = 1f;
        }
    }
}