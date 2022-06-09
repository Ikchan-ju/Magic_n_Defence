using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condition : MonoBehaviour
{
    public bool isTrue = false;

    public enum Description{
        larger, smaller, equal, // (Where T:NumBlock) Each larger & smaller cases contain equal case. Equal case is a special one which can amplitude input source.
         strong, weak, // (where T: ElementalBlock) These cases are judged by the scenario that Tinput attacks Treference.
    }

    public Description description;

    // public void Estimate(NumBlock input, NumBlock reference)
    // {
    //     isTrue = input.Comparison(reference);
    // }
    public void Estimate(AttributionBlock input, AttributionBlock reference)
    {
        isTrue = input.Comparison(reference);
    }
}