using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class FininteStateMachine: MonoBehaviour
    {
        [SerializeField]

        FSM _startingState;
        FSM _currentState;

        public void Awake()
        {
            _currentState = null;
        }
        public void Start()
        {
            if(_startingState != null)
            {
                EnterState(_startingState);
            }
        }

        public void Update()
        {
            if(_currentState != null)
            {
                _currentState.UpdateState();
            }
        }
        #region STATE MANAGEMENT

        public void EnterState(FSM nextState)
        {
            if(nextState == null)
            {
                return;
            }
            _currentState = nextState;
            _currentState.EnterState();
        }

        #endregion

    }
}
