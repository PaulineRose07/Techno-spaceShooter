using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDivisionPauline : EnemyBaseClass
{

    [SerializeField] GameObject m_subAsteroids;
    AsteroidsSpawnerPauline m_spawner;
    [SerializeField] private int m_damages;
    [SerializeField] ParticleSystem m_particles;


    internal override void TakeDamage(int m_damagePoints)
    {
        base.TakeDamage(m_damagePoints);
        if (m_lives <= 0)
        {
            m_spawner.UpdateAsteroidCount(-1);
            Destroy(gameObject);
            Instantiate(m_particles, transform.position, Quaternion.identity);
            if (m_subAsteroids != null)
            {
                for (int i = 0; i < 2; i++)
                {
                    var newAsteroid=Instantiate(m_subAsteroids, transform.position, Quaternion.identity);
                    newAsteroid.GetComponent<AsteroidDivisionPauline>().SetSpawner(m_spawner);
                }
            }
        }

    }

    public void SetSpawner(AsteroidsSpawnerPauline _spawner)
    {
        m_spawner = _spawner;
    }

    internal override int GetCollisionDamage()
    {
        return m_damages;
    }
}
