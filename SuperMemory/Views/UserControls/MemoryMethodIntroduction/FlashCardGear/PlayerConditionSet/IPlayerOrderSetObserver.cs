using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet
{
    public interface IPlayerOrderSetObserver
    {
        void onPlayerOrderStateChanged(int curOrderState);
    }
}
