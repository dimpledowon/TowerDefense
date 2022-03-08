using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScripts : MonoBehaviour
{
    public float damage; // ���� �޴� �������� ��
    public float speed = 1f; // �߻�ü�� �ӵ�
    public Vector3 direction; // �߻�ü�� ���ϰ� �ִ� ����
    public float lifeDuration = 10f; // �߻�ü�� �����ϱ� ������ ����ִ� �ð�

    void Start()
    {
        // ������ ����ȭ �Ѵ�
        direction = direction.normalized;
        // ȸ�� ���� ��ģ��
        float angle = Mathf.Atan2(-direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        // ������ Ÿ�̸Ӹ� �����
        Destroy(gameObject, lifeDuration);
    }

    // �ð��� �ӵ��� ���� �߻�ü�� ��ġ�� ������Ʈ�Ѵ�
    void Update()
    {
        transform.position += direction*Time.deltaTime*speed;
    }
}
