using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Health", order = 1)]

public class HealthData : ScriptableObject//, ISerializationCallbackReceiver
{
    public float HP;
    public float maxHP;
    public float minHP = 0;
    public float maxHealthPerHeal = 100;


    public UnityEvent changeHP;
    public UnityEvent damageEvent;
    public UnityEvent healthEvent;
    public UnityEvent isMinHPEvent;
    public UnityEvent isMaxHPEvent;



    //public float InitialValue;

    //public float RuntimeValue;

    //public void OnAfterDeserialize()
    //{
    //    RuntimeValue = InitialValue;
    //}

    //public void OnBeforeSerialize()
    //{

    //}
}


