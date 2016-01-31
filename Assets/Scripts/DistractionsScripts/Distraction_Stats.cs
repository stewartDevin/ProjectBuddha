using UnityEngine;
using System.Collections;

public class Distraction_Stats : MonoBehaviour {

    public enum DistractionType { NULL, Noise, Projectile, Smell, Zent };
    public DistractionType distractionType = DistractionType.NULL;

    public int damage = 1;

    public float moveSpeed = 1.0f;
    
}
