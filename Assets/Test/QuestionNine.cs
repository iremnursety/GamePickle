using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Test
{
    public class QuestionNine : MonoBehaviour
    {
        [SerializeField] private List<int> intList = new List<int>();
        [SerializeField] private TextMeshProUGUI textListInt;

        private void Start()
        {
            intList.Add(0);
        }

        public void ChangeText()
        {
            textListInt.text = "Value: " + intList[2];
        }

    }
}
