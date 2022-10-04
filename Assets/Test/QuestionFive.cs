using TMPro;
using UnityEngine;

namespace Test
{
    public class QuestionFive : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI textAdvert;
        [SerializeField] private float timer;
        [SerializeField] private bool isAdvertLoading;
        [SerializeField] private bool isAdvertReadyForDisplay;
        private void Start()
        {
            ResetBool();
            
        }
        private void Update()
        {
            StartAdvert();
        }
        
        // Does nothing if the advert is not ready for display
        private void DisplayAdvert()
        {
            Debug.Log("DisplayAdvert");
            ResetBool();
        }

        // Load the advert ready for display (time for advert to load is affected by network speed)
        public void LoadAdvert()
        {
            isAdvertLoading = true;
            //StartCoroutine(StartAdvert());
            Debug.Log("LoadAdvert");
        }
        
        private void EnterLevel()
        {
            ResetBool();
            Debug.Log("EnterLevel");
        }
        
        public void ReadyForDisplay()
        {
            isAdvertReadyForDisplay = true;
        }

        private void ResetBool()
        {
            timer = 0f;
            isAdvertLoading = false;
            isAdvertReadyForDisplay = false;
        }

        private void StartAdvert()
        {
            if (isAdvertLoading)
            {
                Timer();
            }
        }

        private void Timer()
        {
            timer+= Time.unscaledDeltaTime;
            if (timer >= 3)
                CheckState();
        }

        private void CheckState()
        {
            if (!isAdvertReadyForDisplay)
            {
                textAdvert.text = "Advert: Not Loaded";
                EnterLevel();
            }
            else
            {
                textAdvert.text = "Advert:Loaded";
                DisplayAdvert();
            }
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

/*IEnumerator StartAdvert()
        {
            if (isAdvertLoading)
            {
                yield return new WaitForSeconds(3f);
                if (!isAdvertReadyForDisplay)
                {
                    textAdvert.text = "Advert: Not Loaded";
                    EnterLevel();
                }
                else
                {
                    textAdvert.text = "Advert:Loaded";
                    DisplayAdvert();
                }
            }
            yield return null;
        }*/