using UnityEngine;

namespace KID
{
    /// <summary>
    /// 練習類別
    /// </summary>
    public class Practice_8_Class : MonoBehaviour
    {
        private void Awake()
        {
            Practice_8_Boss bossDeagon = new Practice_8_Boss("龍獸", "龍之吐息", 2999);
            Practice_8_Boss bossBird = new Practice_8_Boss("烈空座", "光束砲", 3999);

            Debug.Log($"<color=#f93>{bossDeagon.name}, 招式：{bossDeagon.skill}</color>");
            Debug.Log($"<color=#f93>{bossBird.name}, 招式：{bossBird.skill}</color>");
        }
    }

    /// <summary>
    /// 大魔王類別
    /// </summary>
    public class Practice_8_Boss 
    {
        public string name;
        public string skill;
        public float hp;

        public Practice_8_Boss(string _name, string _skill, float _hp)
        {
            name = _name;
            skill = _skill;
            hp = _hp;
        }
    }
}
