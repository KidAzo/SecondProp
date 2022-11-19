using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health;
    Enemy _enemy;

    void Awake()
    {
        _enemy = GetComponent<Enemy>();
    }



    public void TakeDamage(float attackDamage)
    {
        health -= attackDamage;
        if (health > 0) return;

        this.gameObject.SetActive(false);
        EnemyDedector.Instance.EnemyList.Remove(_enemy);
    }
}
