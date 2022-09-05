using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "ScriptableObject/EnemyData", order = 1)]
public class EnemyData : ScriptableObject
{
    [SerializeField]
    private string mobName;
    [SerializeField]
    private int health;
    [SerializeField]
    private float speed;

    private string MobName { get => mobName; set => mobName = value; }
    public int Health { get => health; set => health = value; }
    public float Speed { get => speed; set => speed = value; }
}
