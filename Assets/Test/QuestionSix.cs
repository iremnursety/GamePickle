using TMPro;
using UnityEngine;

namespace Test
{
    public class QuestionSix : MonoBehaviour
    {
        [SerializeField] private int outputVal;
        [SerializeField] private TextMeshProUGUI textOutput;
        private void Start()
        {
            IntOutput();
        }

        public int IntOutput()
        {
            outputVal = 0;

            #if UNITY_EDITOR
            outputVal++;
            #endif

            #if THIS_IS_NOT_SET
            outputVal++;
            #endif

            #if UNITY_IPHONE
            outputVal++;
            #else
            outputVal++;
            #endif

            #if UNITY_ANDROID
            outputVal++;
            #endif

            ChangeText();
            return outputVal;
        }
        private void ChangeText()
        {
            textOutput.text="Output Value: "+outputVal;
        }
    }
}