using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private HealthData data;

    //public delegate void ChangeHP(float message);
    //public event ChangeHP changeHP;
    //public event ChangeHP damageEvent;
    //public event ChangeHP healthEvent;

    //public float HP => data.HP1;
    public HealthData Data { get => data; private set => data = value; }

    private void Start()
    {
        if (data == null) Debug.Log("not set data");
    }


    public void getHealth(float health)
    {
        if (health < 0) return;

        health = health > data.maxHealthPerHeal ? data.maxHealthPerHeal : health;
        data.HP = (data.HP + health) >= data.maxHP ? data.maxHP : (data.HP + health);

        // Events
        data.changeHP?.Invoke();
        data.healthEvent?.Invoke();
        if (data.HP >= data.maxHP) data.isMinHPEvent?.Invoke();
        //changeHP?.Invoke(data.HP);
        //healthEvent?.Invoke(health);
    }

    public void getDamage(float health)
    {
        if (health < 0) return;

        data.HP = (data.HP - health) <= data.minHP ? data.minHP : (data.HP - health);

        // Events
        data.changeHP?.Invoke();
        data.damageEvent?.Invoke();
        if (data.HP <= data.minHP) data.isMinHPEvent?.Invoke();
        //changeHP?.Invoke(data.HP);
        //damageEvent?.Invoke(health);
    }


}
// дописать условия на включение и откоючение некоторых полей например отключить макс хил за раз
// решить трабл с записью на диск когда над временные данные 