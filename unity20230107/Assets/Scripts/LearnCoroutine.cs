using System.Collections;
using UnityEngine;

namespace JAY
{
    public class LearnCoroutine : MonoBehaviour
    {
        private string testDialogue = "那裡好像有門...趕緊離開好了...";

        private void Awake()
        {
            StartCoroutine(ShowDialogueUseFor());
        }
        private IEnumerator Test()
        {
            print("<color=#33ff33>第一行程式<color>");
            yield return new WaitForSeconds(2);
            print("<color=#ff3333>第二行程式<color>");
            yield return new WaitForSeconds(3);
            print("<color=#3333ff>第三行程式<color>");
        }

        private IEnumerator ShowDialogue()
        {
            print(testDialogue[0]);
            yield return new WaitForSeconds(0.1f);
            print(testDialogue[1]);
            yield return new WaitForSeconds(0.1f);
            print(testDialogue[2]);
            yield return new WaitForSeconds(0.1f);
        }

        private IEnumerator ShowDialogueUseFor()
        {
            for (int i = 0; i < testDialogue.Length; i++)
            {
                print(testDialogue[i]);
                yield return new WaitForSeconds(0.2f);
            }
        }
    }
}

