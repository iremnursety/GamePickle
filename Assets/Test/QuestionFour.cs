using System;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Test
{
    public class QuestionFour : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI textValue;
        public int[] myInts;

        /*
         //Old Code
         public void AddArrayValue(int input)
        {
            // Create the new array with an increased length of 1
            int[] finalInts = new int[myInts.Length + 1];

            // Iterate through myInts re-assigning the values to finalInts
            for (int i = 0; i < myInts.Length; i++)
                finalInts [i] = myInts [i];

            // Add the input value to the newly made last key of the finalInts array
            finalInts [finalInts.Length - 1] = input;

            // Assign finalInts to myInts
            myInts = finalInts;
            
            textValue.text = "Value: " + myInts[myInts.Length];
        }*/

        //AddArrayValue Reworked.
        public void AddArrayRework(int input)
        {
            //Increase myInts lenght.
            Array.Resize(ref myInts, myInts.Length + 1);
            //Adding input end of the array.
            myInts[myInts.Length - 1] = input;

            textValue.text = "Value: " + myInts[myInts.Length - 1];
        }

        public void ChangeLastValue()
        {
            var randomNumber = Random.Range(0, 100);

            //AddArrayValue(randomNumber);
            AddArrayRework(randomNumber);
        }
    }
}