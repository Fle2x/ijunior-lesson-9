using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
[RequireComponent(typeof(Player))]

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthSlider;
    [SerializeField] private Player _player;

    private void Start()
    {
        _healthSlider.minValue = _player.minHealth;
        _healthSlider.maxValue = _player.maxHealth;
        _healthSlider.value = _player.currentHealth;
    }

    public void SetHealthSlider(float health)
    {
        _healthSlider.value = health;
    }
}
