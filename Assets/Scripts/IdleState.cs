using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    [CreateAssetMenu(fileName = "IdleState", menuName ="unity-FSM/States/Idle", order = 1)]
    public class IdleState : FSM
    {
        public override bool EnterState()
        {
            base.EnterState();
            UnityEngine.Debug.Log("ENTER IDLE STATE");
            return true;
        }
        public override void UpdateState()
        {
            UnityEngine.Debug.Log("UPDATING IDLE STATE");
            //throw new NotImplementedException();
        }

        public override bool ExitState()
        {
            base.ExitState();
            UnityEngine.Debug.Log("EXITING IDLE STATE");
            return true;
        }
    }
}
