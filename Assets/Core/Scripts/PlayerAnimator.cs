using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
// 자기이름. 프로젝트 명.컴포넌트의 기능 이름 
namespace YJ.Applications.Players
{
    public class PlayerAnimator : MonoBehaviour
    {
        private Animator _animator;
        public bool IsWalk = true;

        private void Start()
        {
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.LeftShift))
                IsWalk = true;
            else
                IsWalk = false;

            if (Input.GetKey(KeyCode.Mouse0))
                _animator.Play("Smash");

            //Mathf.Abs 절대값
            float h = Mathf.Abs(Input.GetAxis("Horizontal"));
            float v = Mathf.Abs(Input.GetAxis("Vertical"));

            // 삼항 연산자. 조건문 ?? True : false
            // 10 > 3 ? 25 :14 -> 25
            var max = h > v ? h : v;
            max = IsWalk ? Mathf.Clamp(max, 0, 0.5f) : max;
           


            _animator.SetFloat("Movement", max);
            
        }
    }


}
