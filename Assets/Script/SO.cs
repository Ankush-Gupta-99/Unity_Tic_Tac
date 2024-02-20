using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LInput", menuName = "LastInput")]
public class SO : ScriptableObject
{
    public enum LastValue
    {
        x,
        o,
        na
    }
    public LastValue lastValue;
}
