using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

namespace Assets.Scripts
{
    [RequireComponent(typeof(NavMeshAgent), typeof(FininteStateMachine))]
    public class NPC: MonoBehaviour
    {
        NavMeshAgent _navMeshAgent;
        FininteStateMachine _finiteStateMachine;
        public void Awake()
        {
            _navMeshAgent = this.GetComponent<NavMeshAgent>();
            _finiteStateMachine = this.GetComponent<FininteStateMachine>();
        }

        public void Start()
        {

        }

        public void Update()
        {

        }
    }
}
